-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Servidor: localhost
-- Tiempo de generación: 16-06-2020 a las 01:56:59
-- Versión del servidor: 10.4.11-MariaDB
-- Versión de PHP: 7.4.4

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `db_Recursohumano`
--
CREATE DATABASE IF NOT EXISTS `db_Recursohumano` DEFAULT CHARACTER SET utf8 COLLATE utf8_general_ci;
USE `db_Recursohumano`;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `discapacidad`
--

CREATE TABLE `discapacidad` (
  `id_discapacidad` smallint(6) NOT NULL,
  `discapacidad` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `discapacidad`
--

INSERT INTO `discapacidad` (`id_discapacidad`, `discapacidad`) VALUES
(1, 'física'),
(2, 'sensorial'),
(3, 'intelectual'),
(4, 'psíquica');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `empleado`
--

CREATE TABLE `empleado` (
  `id_empleado` bigint(20) NOT NULL,
  `nombre` varchar(50) NOT NULL,
  `apellido_paterno` varchar(50) DEFAULT NULL,
  `apellido_materno` varchar(50) DEFAULT NULL,
  `telefono_local` varchar(12) DEFAULT 'null',
  `telefono_movil` varchar(12) DEFAULT 'null',
  `direccion` varchar(50) DEFAULT 'null',
  `fec_nac` date DEFAULT NULL,
  `curp` varchar(18) DEFAULT NULL,
  `observaciones` varchar(100) DEFAULT NULL,
  `email` varchar(50) DEFAULT NULL,
  `ins_fec` datetime DEFAULT NULL,
  `codigo_postal` varchar(5) DEFAULT NULL,
  `estado_nacimiento` varchar(5) DEFAULT NULL,
  `id_genero` varchar(2) NOT NULL,
  `id_titulo_obtenido` smallint(6) NOT NULL,
  `nacionalidad` varchar(30) DEFAULT NULL,
  `trabaja_actualmente` tinyint(1) DEFAULT NULL,
  `id_discapacidad` smallint(6) NOT NULL,
  `red_social` varchar(50) DEFAULT NULL,
  `numero_seguro_social` varchar(45) DEFAULT NULL,
  `unidad_medicina_familiar` varchar(45) DEFAULT NULL,
  `comunidad_indigena` varchar(200) DEFAULT NULL,
  `procede_comunidad_indigena` tinyint(4) DEFAULT NULL,
  `num_interior` varchar(20) DEFAULT NULL,
  `num_exterior` varchar(20) DEFAULT NULL,
  `id_puesto` bigint(20) NOT NULL,
  `rfc` varchar(20) DEFAULT NULL,
  `estatura` smallint(6) DEFAULT NULL,
  `peso` smallint(6) DEFAULT NULL,
  `sueldo_deseado` decimal(10,2) DEFAULT NULL,
  `id_estado_nac` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `estado`
--

CREATE TABLE `estado` (
  `id_estado_nac` int(11) NOT NULL,
  `estado` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `estado`
--

INSERT INTO `estado` (`id_estado_nac`, `estado`) VALUES
(1, 'sonora'),
(2, 'durango'),
(3, 'CDMX'),
(4, 'tabasco');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `genero`
--

CREATE TABLE `genero` (
  `id_genero` varchar(2) NOT NULL,
  `genero` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `genero`
--

INSERT INTO `genero` (`id_genero`, `genero`) VALUES
('m', 'femenino'),
('h', 'masculino');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `puesto`
--

CREATE TABLE `puesto` (
  `id_puesto` bigint(20) NOT NULL,
  `puesto` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `puesto`
--

INSERT INTO `puesto` (`id_puesto`, `puesto`) VALUES
(1, 'promotor'),
(2, 'gerente comercial'),
(3, 'vendedor'),
(4, 'jefe de departamento');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `titulo`
--

CREATE TABLE `titulo` (
  `id_titulo_obtenido` smallint(6) NOT NULL,
  `titulo` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `titulo`
--

INSERT INTO `titulo` (`id_titulo_obtenido`, `titulo`) VALUES
(1, 'maestría'),
(2, 'ingeniería/licenciatura'),
(3, 'doctorado'),
(4, 'secundaría'),
(5, 'primaria'),
(6, 'preparatoria');

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `discapacidad`
--
ALTER TABLE `discapacidad`
  ADD PRIMARY KEY (`id_discapacidad`);

--
-- Indices de la tabla `empleado`
--
ALTER TABLE `empleado`
  ADD PRIMARY KEY (`id_empleado`),
  ADD KEY `FK_estado_idx` (`id_estado_nac`),
  ADD KEY `FK_puesto_idx` (`id_puesto`),
  ADD KEY `FK_discap_idx` (`id_discapacidad`),
  ADD KEY `FK_gen_idx` (`id_genero`),
  ADD KEY `FK_titul_idx` (`id_titulo_obtenido`);

--
-- Indices de la tabla `estado`
--
ALTER TABLE `estado`
  ADD PRIMARY KEY (`id_estado_nac`);

--
-- Indices de la tabla `genero`
--
ALTER TABLE `genero`
  ADD PRIMARY KEY (`id_genero`);

--
-- Indices de la tabla `puesto`
--
ALTER TABLE `puesto`
  ADD PRIMARY KEY (`id_puesto`);

--
-- Indices de la tabla `titulo`
--
ALTER TABLE `titulo`
  ADD PRIMARY KEY (`id_titulo_obtenido`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `discapacidad`
--
ALTER TABLE `discapacidad`
  MODIFY `id_discapacidad` smallint(6) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT de la tabla `empleado`
--
ALTER TABLE `empleado`
  MODIFY `id_empleado` bigint(20) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `estado`
--
ALTER TABLE `estado`
  MODIFY `id_estado_nac` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT de la tabla `titulo`
--
ALTER TABLE `titulo`
  MODIFY `id_titulo_obtenido` smallint(6) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `empleado`
--
ALTER TABLE `empleado`
  ADD CONSTRAINT `FK_discap_idx` FOREIGN KEY (`id_discapacidad`) REFERENCES `discapacidad` (`id_discapacidad`),
  ADD CONSTRAINT `FK_estado_idx` FOREIGN KEY (`id_estado_nac`) REFERENCES `estado` (`id_estado_nac`),
  ADD CONSTRAINT `FK_gen_idx` FOREIGN KEY (`id_genero`) REFERENCES `genero` (`id_genero`),
  ADD CONSTRAINT `FK_puesto_idx` FOREIGN KEY (`id_puesto`) REFERENCES `puesto` (`id_puesto`),
  ADD CONSTRAINT `FK_titul_idx` FOREIGN KEY (`id_titulo_obtenido`) REFERENCES `titulo` (`id_titulo_obtenido`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
