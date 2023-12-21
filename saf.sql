-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 27-11-2023 a las 03:15:06
-- Versión del servidor: 10.4.28-MariaDB
-- Versión de PHP: 8.2.4

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `saf`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `categorias`
--

CREATE TABLE `categorias` (
  `letra` char(1) NOT NULL,
  `monto` decimal(10,2) UNSIGNED NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `categorias`
--

INSERT INTO `categorias` (`letra`, `monto`) VALUES
('A', 1414762.00),
('B', 2103025.00),
('C', 2944235.60),
('D', 3656604.00),
('E', 4305799.15),
('F', 5382248.94),
('G', 6458698.71),
('H', 7996484.12),
('I', 8949911.00),
('J', 10257028.00),
('K', 11379612.00);

-- --------------------------------------------------------

--
-- Estructura Stand-in para la vista `categoriasview`
-- (Véase abajo para la vista actual)
--
CREATE TABLE `categoriasview` (
`Letra` char(1)
,`Monto` decimal(10,2) unsigned
);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `facturas`
--

CREATE TABLE `facturas` (
  `ID` int(11) UNSIGNED NOT NULL,
  `fecha` date NOT NULL,
  `monto` decimal(10,2) UNSIGNED NOT NULL,
  `descripcion` varchar(512) DEFAULT NULL,
  `tipoPagoID` int(8) UNSIGNED NOT NULL,
  `usuarioDNI` int(10) UNSIGNED NOT NULL,
  `negocioID` int(4) UNSIGNED NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `facturas`
--

INSERT INTO `facturas` (`ID`, `fecha`, `monto`, `descripcion`, `tipoPagoID`, `usuarioDNI`, `negocioID`) VALUES
(55, '2023-09-10', 123.00, NULL, 1, 1, 1),
(94, '2023-10-02', 12.00, NULL, 2, 1, 1),
(95, '2023-10-02', 3123.00, NULL, 2, 1, 1),
(98, '2023-10-13', 23123.00, NULL, 1, 1, 1),
(99, '2023-10-13', 2312.00, NULL, 1, 1, 1),
(100, '2023-10-13', 123.00, NULL, 1, 1, 1),
(101, '2023-10-13', 32.00, '', 1, 1, 1),
(102, '2023-10-13', 412.00, NULL, 1, 1, 1),
(103, '2023-10-02', 122.00, '', 1, 1, 1),
(104, '2023-10-13', 3213.00, NULL, 1, 1, 1),
(105, '2023-10-13', 12312.00, NULL, 1, 1, 1),
(106, '2023-10-13', 31231.00, NULL, 1, 1, 1),
(107, '2023-10-13', 231.00, NULL, 1, 1, 1),
(108, '2023-10-13', 31231.00, NULL, 1, 1, 1),
(110, '2023-10-13', 4214.00, NULL, 1, 1, 1),
(111, '2023-10-13', 214.00, NULL, 1, 1, 1),
(112, '2023-10-13', 12314.00, NULL, 1, 1, 1),
(113, '2023-10-13', 123.00, NULL, 1, 1, 1),
(114, '2023-10-13', 123.00, NULL, 1, 1, 1),
(115, '2023-10-13', 12312.00, NULL, 1, 1, 1),
(116, '2023-10-13', 3123.00, NULL, 1, 1, 1),
(117, '2023-10-13', 312.00, NULL, 1, 1, 1),
(118, '2023-10-13', 123.00, NULL, 1, 1, 1),
(119, '2023-10-13', 323.00, NULL, 1, 1, 1),
(120, '2023-10-13', 123.00, NULL, 1, 1, 1),
(121, '2023-10-13', 152512.00, NULL, 1, 1, 1),
(122, '2023-10-13', 9999.00, NULL, 1, 1, 1),
(125, '2023-10-14', 5454.00, NULL, 1, 1, 1),
(126, '2023-10-19', 4.00, NULL, 1, 1, 1),
(127, '2023-10-01', 1561.00, NULL, 1, 1, 1),
(128, '2023-10-02', 1142.00, NULL, 1, 1, 1),
(129, '2023-10-03', 241.00, NULL, 1, 1, 1),
(130, '2023-10-04', 241.00, NULL, 1, 1, 1),
(131, '2023-10-05', 142.00, NULL, 1, 1, 1),
(132, '2023-10-06', 5412.00, NULL, 1, 1, 1),
(133, '2023-10-07', 445.00, NULL, 1, 1, 1),
(134, '2023-10-08', 412.00, NULL, 1, 1, 1),
(135, '2023-10-09', 5745.00, NULL, 1, 1, 1),
(136, '2023-10-10', 542.00, NULL, 1, 1, 1),
(137, '2023-10-11', 2472.00, NULL, 1, 1, 1),
(138, '2023-10-12', 74.00, NULL, 1, 1, 1),
(139, '2023-10-13', 712.00, NULL, 1, 1, 1),
(140, '2023-10-14', 745.00, NULL, 1, 1, 1),
(141, '2023-10-15', 241.00, NULL, 1, 1, 1),
(142, '2023-10-16', 14.00, NULL, 1, 1, 1),
(143, '2023-10-17', 454.00, NULL, 1, 1, 1),
(144, '2023-10-18', 142.00, NULL, 1, 1, 1),
(145, '2023-10-19', 42.00, NULL, 1, 1, 1),
(146, '2023-10-25', 1.00, NULL, 1, 1, 1),
(148, '2023-10-25', 123.00, '', 1, 1, 1),
(149, '2023-10-25', 123.00, '', 1, 1, 1),
(150, '2023-10-25', 23.00, '', 1, 1, 1),
(151, '2023-10-25', 3232.00, '', 1, 1, 1),
(152, '2023-10-25', 32.00, '', 1, 1, 1),
(153, '2023-10-25', 32.00, '', 1, 1, 1),
(154, '2023-10-26', 123.00, '', 1, 1, 1),
(161, '2023-11-06', 123.00, '', 1, 1, 1),
(162, '2023-11-06', 1435.00, '', 1, 2, 1),
(163, '2023-11-18', 3852.46, '', 1, 2, 1),
(164, '2023-11-18', 3852.46, '', 2, 2, 1),
(165, '2023-11-18', 3852.46, '', 1, 2, 1),
(166, '2023-11-18', 3852.46, '', 4, 2, 1),
(167, '2023-11-18', 3852.46, '', 4, 2, 1),
(168, '2023-11-18', 3256.00, '', 5, 2, 1),
(169, '2023-11-18', 2526.00, '', 3, 2, 1),
(170, '2023-11-19', 3152.00, '', 1, 2, 1),
(171, '2023-11-19', 3546.00, '', 5, 2, 1),
(172, '2023-11-19', 4264.50, '', 4, 2, 1),
(173, '2023-11-23', 3204.03, '', 3, 2, 1);

-- --------------------------------------------------------

--
-- Estructura Stand-in para la vista `facturasview`
-- (Véase abajo para la vista actual)
--
CREATE TABLE `facturasview` (
`ID` int(11) unsigned
,`Fecha` date
,`Monto` decimal(10,2) unsigned
,`Tipo de pago` varchar(32)
,`Usuario` varchar(77)
,`negocioID` int(4) unsigned
);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `negocios`
--

CREATE TABLE `negocios` (
  `ID` int(4) UNSIGNED NOT NULL,
  `diasSemanales` int(1) UNSIGNED NOT NULL,
  `categoriaLetra` char(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `negocios`
--

INSERT INTO `negocios` (`ID`, `diasSemanales`, `categoriaLetra`) VALUES
(1, 5, 'A');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `negociovacaciones`
--

CREATE TABLE `negociovacaciones` (
  `ID` int(11) UNSIGNED NOT NULL,
  `fechaInicio` date NOT NULL,
  `fechaFin` date NOT NULL,
  `negocioID` int(4) UNSIGNED NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `negociovacaciones`
--

INSERT INTO `negociovacaciones` (`ID`, `fechaInicio`, `fechaFin`, `negocioID`) VALUES
(17, '2023-01-01', '2023-01-31', 1),
(18, '2023-07-15', '2023-07-21', 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tipopago`
--

CREATE TABLE `tipopago` (
  `ID` int(8) UNSIGNED NOT NULL,
  `nombre` varchar(32) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `tipopago`
--

INSERT INTO `tipopago` (`ID`, `nombre`) VALUES
(1, 'Efectivo'),
(2, 'Debito'),
(3, 'Credito'),
(4, 'Mercado Pago'),
(5, 'Cuenta DNI');

-- --------------------------------------------------------

--
-- Estructura Stand-in para la vista `tipopagoview`
-- (Véase abajo para la vista actual)
--
CREATE TABLE `tipopagoview` (
`ID` int(8) unsigned
,`Nombre` varchar(32)
);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tipousuario`
--

CREATE TABLE `tipousuario` (
  `ID` int(1) UNSIGNED NOT NULL,
  `nombre` varchar(32) NOT NULL,
  `permisos` int(2) UNSIGNED NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `tipousuario`
--

INSERT INTO `tipousuario` (`ID`, `nombre`, `permisos`) VALUES
(1, 'Administrador', 15),
(2, 'Empleado', 3);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `usuariologins`
--

CREATE TABLE `usuariologins` (
  `usuarioDNI` int(10) UNSIGNED NOT NULL,
  `fechaHora` datetime NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `usuariologins`
--

INSERT INTO `usuariologins` (`usuarioDNI`, `fechaHora`) VALUES
(1, '2023-11-22 22:46:26'),
(1, '2023-11-22 22:47:19'),
(1, '2023-11-22 22:49:27'),
(1, '2023-11-22 22:53:21'),
(1, '2023-11-22 22:54:37'),
(1, '2023-11-22 22:55:23'),
(1, '2023-11-22 22:56:22'),
(1, '2023-11-22 23:14:09'),
(1, '2023-11-22 23:16:34'),
(1, '2023-11-22 23:22:32'),
(1, '2023-11-22 23:31:00'),
(1, '2023-11-22 23:38:27'),
(1, '2023-11-22 23:40:17'),
(1, '2023-11-22 23:41:09'),
(1, '2023-11-22 23:41:51'),
(1, '2023-11-22 23:43:21'),
(1, '2023-11-22 23:44:08'),
(1, '2023-11-22 23:44:41'),
(1, '2023-11-22 23:54:06'),
(1, '2023-11-24 01:50:44'),
(1, '2023-11-24 15:02:37'),
(1, '2023-11-24 15:33:01'),
(1, '2023-11-24 15:39:23'),
(1, '2023-11-24 15:47:40'),
(1, '2023-11-25 14:55:22'),
(1, '2023-11-25 19:45:49'),
(1, '2023-11-25 19:47:47'),
(1, '2023-11-25 19:48:07'),
(1, '2023-11-25 19:50:07'),
(1, '2023-11-25 19:52:00'),
(1, '2023-11-25 19:53:14'),
(1, '2023-11-25 20:03:14'),
(1, '2023-11-25 20:04:24'),
(1, '2023-11-25 20:12:20'),
(1, '2023-11-25 20:14:10'),
(1, '2023-11-25 20:24:07'),
(1, '2023-11-25 20:32:37'),
(1, '2023-11-25 20:36:34'),
(1, '2023-11-25 20:37:23'),
(1, '2023-11-25 20:39:08'),
(1, '2023-11-25 20:45:34'),
(1, '2023-11-26 17:07:19'),
(1, '2023-11-26 21:17:32'),
(1, '2023-11-26 22:07:46'),
(2, '2023-11-25 20:25:28');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `usuarios`
--

CREATE TABLE `usuarios` (
  `DNI` int(10) UNSIGNED NOT NULL,
  `pass` varchar(256) NOT NULL,
  `nombre` varchar(32) DEFAULT NULL,
  `apellido` varchar(32) DEFAULT NULL,
  `email` varchar(320) DEFAULT NULL,
  `telefono` varchar(20) DEFAULT NULL,
  `detalles` varchar(512) DEFAULT NULL,
  `tipoID` int(1) UNSIGNED NOT NULL,
  `negocioID` int(4) UNSIGNED NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `usuarios`
--

INSERT INTO `usuarios` (`DNI`, `pass`, `nombre`, `apellido`, `email`, `telefono`, `detalles`, `tipoID`, `negocioID`) VALUES
(1, 'naianc1QBx25AwjP1N3xu6S6CX9kJjWFHIGlK+jbSC425JkPkVKj8zgvdQRGP8SJZzM5oipKtWUQZX6Qv8RP08/92eLXGtjYFfacQptpp+tlpNy61RxH7dCr7nExj3pOu3mirz2eVSQVqEpO3JJqso+DhLe+CLn0M6leY3RnetbzFnwCuA04J2Qt7iC6BfXpxM4r4DNkAcWI4HXm2xkb7Rx5QUY/ob7SJYH2g4zFsWAz2WELGNbVR2Ms2vwvYg==', 'root', '', '', '', '', 1, 1),
(2, 'X4Jhrj4TSY3dSaGQNPRFXedKNTJ66LZZCgasvYWd62AfdRgrYMtIOqsfAiVJKVY77s8JkStT4UEZpI4mEJlwmnXeXtpjPPIYaS9k3wpvLFdrxiHXJvSG27674HSKhE+p1AM41XfNYPz+E3sYzAA9RZdIIjoYQqncujJJ7TzZ94zIn1I5osXlQBurM/I8fKXkl32yzdRmPPQ75NQUaZUHqgYR5nPjxPWdQk24weNl0O2D1msA9MgO9ZQ0KpoUTw==', 'Empleado', '', '', NULL, '', 2, 1);

-- --------------------------------------------------------

--
-- Estructura Stand-in para la vista `usuariosview`
-- (Véase abajo para la vista actual)
--
CREATE TABLE `usuariosview` (
`DNI` int(10) unsigned
,`Nombre` varchar(65)
,`Email` varchar(320)
,`Teléfono` varchar(20)
,`Tipo de usuario` varchar(32)
,`negocioID` int(4) unsigned
);

-- --------------------------------------------------------

--
-- Estructura para la vista `categoriasview`
--
DROP TABLE IF EXISTS `categoriasview`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `categoriasview`  AS SELECT `categorias`.`letra` AS `Letra`, `categorias`.`monto` AS `Monto` FROM `categorias` ;

-- --------------------------------------------------------

--
-- Estructura para la vista `facturasview`
--
DROP TABLE IF EXISTS `facturasview`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `facturasview`  AS SELECT `facturas`.`ID` AS `ID`, `facturas`.`fecha` AS `Fecha`, `facturas`.`monto` AS `Monto`, `tipopago`.`nombre` AS `Tipo de pago`, concat(`usuarios`.`DNI`,': ',`usuarios`.`nombre`,' ',`usuarios`.`apellido`) AS `Usuario`, `facturas`.`negocioID` AS `negocioID` FROM ((`facturas` left join `usuarios` on(`facturas`.`usuarioDNI` = `usuarios`.`DNI`)) left join `tipopago` on(`facturas`.`tipoPagoID` = `tipopago`.`ID`)) ;

-- --------------------------------------------------------

--
-- Estructura para la vista `tipopagoview`
--
DROP TABLE IF EXISTS `tipopagoview`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `tipopagoview`  AS SELECT `tipopago`.`ID` AS `ID`, `tipopago`.`nombre` AS `Nombre` FROM `tipopago` ;

-- --------------------------------------------------------

--
-- Estructura para la vista `usuariosview`
--
DROP TABLE IF EXISTS `usuariosview`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `usuariosview`  AS SELECT `usuarios`.`DNI` AS `DNI`, concat(`usuarios`.`nombre`,' ',`usuarios`.`apellido`) AS `Nombre`, `usuarios`.`email` AS `Email`, `usuarios`.`telefono` AS `Teléfono`, `tipousuario`.`nombre` AS `Tipo de usuario`, `usuarios`.`negocioID` AS `negocioID` FROM (`usuarios` left join `tipousuario` on(`usuarios`.`tipoID` = `tipousuario`.`ID`)) ;

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `categorias`
--
ALTER TABLE `categorias`
  ADD PRIMARY KEY (`letra`);

--
-- Indices de la tabla `facturas`
--
ALTER TABLE `facturas`
  ADD PRIMARY KEY (`ID`),
  ADD KEY `TipoPagoID` (`tipoPagoID`),
  ADD KEY `UsuarioDNI` (`usuarioDNI`),
  ADD KEY `NegocioID3` (`negocioID`);

--
-- Indices de la tabla `negocios`
--
ALTER TABLE `negocios`
  ADD PRIMARY KEY (`ID`),
  ADD KEY `CategoriaLetra` (`categoriaLetra`);

--
-- Indices de la tabla `negociovacaciones`
--
ALTER TABLE `negociovacaciones`
  ADD PRIMARY KEY (`ID`),
  ADD KEY `a` (`negocioID`);

--
-- Indices de la tabla `tipopago`
--
ALTER TABLE `tipopago`
  ADD PRIMARY KEY (`ID`);

--
-- Indices de la tabla `tipousuario`
--
ALTER TABLE `tipousuario`
  ADD PRIMARY KEY (`ID`);

--
-- Indices de la tabla `usuariologins`
--
ALTER TABLE `usuariologins`
  ADD PRIMARY KEY (`usuarioDNI`,`fechaHora`);

--
-- Indices de la tabla `usuarios`
--
ALTER TABLE `usuarios`
  ADD PRIMARY KEY (`DNI`),
  ADD KEY `NegocioID2` (`negocioID`),
  ADD KEY `TipoID` (`tipoID`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `facturas`
--
ALTER TABLE `facturas`
  MODIFY `ID` int(11) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=176;

--
-- AUTO_INCREMENT de la tabla `negocios`
--
ALTER TABLE `negocios`
  MODIFY `ID` int(4) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT de la tabla `negociovacaciones`
--
ALTER TABLE `negociovacaciones`
  MODIFY `ID` int(11) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=22;

--
-- AUTO_INCREMENT de la tabla `tipopago`
--
ALTER TABLE `tipopago`
  MODIFY `ID` int(8) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `facturas`
--
ALTER TABLE `facturas`
  ADD CONSTRAINT `NegocioID3` FOREIGN KEY (`negocioID`) REFERENCES `negocios` (`ID`),
  ADD CONSTRAINT `TipoPagoID` FOREIGN KEY (`tipoPagoID`) REFERENCES `tipopago` (`ID`),
  ADD CONSTRAINT `UsuarioDNI` FOREIGN KEY (`usuarioDNI`) REFERENCES `usuarios` (`DNI`);

--
-- Filtros para la tabla `negocios`
--
ALTER TABLE `negocios`
  ADD CONSTRAINT `CategoriaLetra` FOREIGN KEY (`categoriaLetra`) REFERENCES `categorias` (`letra`);

--
-- Filtros para la tabla `negociovacaciones`
--
ALTER TABLE `negociovacaciones`
  ADD CONSTRAINT `NegocioID` FOREIGN KEY (`negocioID`) REFERENCES `negocios` (`ID`);

--
-- Filtros para la tabla `usuariologins`
--
ALTER TABLE `usuariologins`
  ADD CONSTRAINT `UsuarioDNI2` FOREIGN KEY (`usuarioDNI`) REFERENCES `usuarios` (`DNI`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Filtros para la tabla `usuarios`
--
ALTER TABLE `usuarios`
  ADD CONSTRAINT `NegocioID2` FOREIGN KEY (`negocioID`) REFERENCES `negocios` (`ID`),
  ADD CONSTRAINT `TipoID` FOREIGN KEY (`tipoID`) REFERENCES `tipousuario` (`ID`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
