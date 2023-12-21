using System;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace SAF.CustomControls {
    internal static class Extension {
//      Extern functions
        [DllImport("User32.dll")]
        internal static extern int SendMessage(IntPtr hWnd, Int32 wMsg, bool wParam, Int32 lParam);

        public static void SuspendDrawing(this System.Windows.Forms.Control oCtrl) {
            SendMessage(oCtrl.Handle, 0x000B, false, 0);
        }

        public static void ResumeDrawing(this System.Windows.Forms.Control oCtrl) {
            SendMessage(oCtrl.Handle, 0x000B, true, 0);
            oCtrl.Refresh();
        }

        public static int Count(this string sThis, string sNeedle) {
            int iLastPos = 0, iCount = 0;
            while ((iLastPos = sThis.IndexOf(sNeedle, iLastPos)) != -1) {
                iLastPos = iLastPos + sNeedle.Length;
                iCount++;
            }
            return iCount;
        }

        public static Image ImageFromBase64(this string sThis) {
            byte[] rBuffer = Convert.FromBase64String(sThis);
            MemoryStream oStream = new MemoryStream(rBuffer);
            oStream.Position = 0;

            Image oImage = Image.FromStream(oStream);

            oStream.Close();
            return oImage;
        }
    }
}
