using SAF.Vista;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Timers;

namespace SAF {
    public class Statistics {
        public delegate void HandledExceptionHandler(Result oResult);
///     <summary>
///         Ocurre cuando una excepcion es capturada.
///     </summary>
        public event HandledExceptionHandler HandledException;

//      -- Atributos de instancia --
///     <summary> Formulario principal. </summary>
        private fMain oMain;

///     <summary> Timer para volver a ejectura 'void InitCalcs()'. </summary>
        private Timer oReInit = new Timer();

///     <summary> Instancia de ControlFacturas para las operaciones relacionadas con las Facturas. </summary>
        private ControlFacturas CF;
///     <summary> Instancia de ControlNegocios para las operaciones relacionadas con los Negocios. </summary>
        private ControlNegocios CN = new ControlNegocios();
///     <summary> Instancia de ControlCategorias para las operaciones relacionadas con las Categorias. </summary>
        private ControlCategorias CC = new ControlCategorias();

//      -- Propiedades privadas --
///     <summary> Instancia de Usuario del formulario principal. </summary>
        private Usuario User => oMain.User;

///     <summary> Instancia de Permission del formulario principal. </summary>
        private Permission Perms => oMain.Perms;

///     <summary> Instancia de Negocio del formulario principal. </summary>
        private Negocio Shop => oMain.Shop;

//      -- Propiedades publicas --
        public Exception LastError { get; protected set; }

///     <summary> Calcula la suma de montos de las facturas de este mes. </summary>
        public decimal MonthSumPrice {
            get {
                CF.SetWhereFilter(oStart: new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1), oEnd: DateTime.Today);
                Result oResult = CF.SumPrice(out decimal mN);
                if (oResult != Result.Success) {
                    LastError = CF.LastError;
                    if (HandledException != null)
                        HandledException(oResult);
                }
                return mN;
            }
        }

///     <summary> Calcula la suma de montos de las facturas de este dia. </summary>
        public decimal DailySumPrice {
            get {
                CF.SetWhereFilter(oStart: DateTime.Today, oEnd: DateTime.Today);
                Result oResult = CF.SumPrice(out decimal mN);
                if (oResult != Result.Success) {
                    LastError = CF.LastError;
                    if (HandledException != null)
                        HandledException(oResult);
                }
                return mN;
            }
        }

///     <summary> Guarda el maximo diario que se puede hacer dnetro de la categoria actual. </summary>
        public decimal DailyMaxPrice { get; private set; }

///     <summary> Guarda los periodos de vacaciones. </summary>
        public Dictionary<int, int> Holidays { get; private set; }

//      -- Contructor --
///     <summary>
///         Inicializa una nueva instancia de Statistics.
///     </summary>
        public Statistics(fMain oMain) {
            this.oMain = oMain;

            CF = new ControlFacturas(User);

            try {
                InitCalcs();
            }
            catch (Exception oEx) {
                LastError = oEx;
                if (HandledException != null)
                    HandledException(Result.Error);
            }

            oReInit.Elapsed += (source, e) => InitCalcs();
            oReInit.Start();
        }

//      -- Metodos publicos --
///     <summary>
///         Hace los calculos estaticos.
///     </summary>
        public void InitCalcs() {
            oReInit.Interval = Math.Ceiling((DateTime.Now.AddDays(1).Date - DateTime.Now).TotalMilliseconds);

            SetHolidays();
            Holidays.TryGetValue(DateTime.Today.Month, out int iN);
            int iDaysInMonth = DateTime.DaysInMonth(DateTime.Today.Year, DateTime.Today.Month) - iN;
            if (CC.GetPrice(out decimal mN, Shop.CategoriaLetra) == Result.Success)
                DailyMaxPrice = mN / 12 / iDaysInMonth;
            else
                throw CC.LastError;
        }

///     <summary>
///         Obtiene la distancia con la siguiente categoria.
///     </summary>
///     <param name="mPrice"> Monto actual. </param>
///     <returns>
///         double indicando porcentaje / 100.
///     </returns>
        public double GetNextCategoryDistance(decimal mPrice) {
            Result oResult = CC.GetPrice(out decimal mCC, Shop.CategoriaLetra);
            if (oResult != Result.Success) {
                 LastError = CC.LastError;
                if (HandledException != null)
                    HandledException(oResult);
                return 0;
            }
            Holidays.TryGetValue(DateTime.Today.Month, out int iN);
            return (double)(mPrice / (mCC / ((DateTime.IsLeapYear(DateTime.Now.Year) ? 366 : 365) - Holidays.Sum(i => i.Value)) * 
                                             (DateTime.DaysInMonth(DateTime.Today.Year, DateTime.Today.Month) - iN)));
        }

///     <summary>
///         Obtiene los periodos de vacaciones y los guarda en Holidays.
///     </summary>
        public void SetHolidays() {
            Dictionary<int, int> oHolidays = new Dictionary<int, int>();
            if (CN.GetHolidays(out DataTable oHolidaysTable, (int)Shop.ID) == Result.Success) {
                DateTime oStart; DateTime oCurr; DateTime oEnd;
                foreach (DataRow oRow in oHolidaysTable.Rows) {
                    oStart = Convert.ToDateTime(oRow["Fecha de inicio"]);
                    oCurr = oStart;
                    oEnd = Convert.ToDateTime(oRow["Fecha de fin"]);

                    if (oStart.Month == oEnd.Month) {
                        if (oStart.Day <= oEnd.Day && !oHolidays.ContainsKey(oStart.Month))
                            oHolidays.Add(oStart.Month, oEnd.Day - oStart.Day);
                        else
                            oHolidays[oStart.Month] += oEnd.Day - oStart.Day;
                    }
                    else if (oStart.Month < oEnd.Month) {
                        if (!oHolidays.ContainsKey(oStart.Month))
                            oHolidays.Add(oStart.Month, DateTime.DaysInMonth(oStart.Year, oStart.Month) - oStart.Day);
                        else
                            oHolidays[oStart.Month] += DateTime.DaysInMonth(oStart.Year, oStart.Month) - oStart.Day;

                        while ((oCurr = oCurr.AddMonths(1)) <= oEnd.AddMonths(-1)) {
                            if (!oHolidays.ContainsKey(oStart.Month))
                                oHolidays.Add(oCurr.Month, DateTime.DaysInMonth(oCurr.Year, oCurr.Month));
                            else
                                oHolidays[oStart.Month] += DateTime.DaysInMonth(oCurr.Year, oCurr.Month);
                        }

                        if (!oHolidays.ContainsKey(oStart.Month))
                            oHolidays.Add(oEnd.Month, oEnd.Day);
                        else
                            oHolidays[oStart.Month] += oEnd.Day;
                    }
                }
            }

            Holidays = oHolidays;
        }
    }
}
