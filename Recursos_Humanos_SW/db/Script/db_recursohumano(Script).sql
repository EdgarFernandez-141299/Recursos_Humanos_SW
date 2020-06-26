-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';

-- -----------------------------------------------------
-- Schema db_recursohumano
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `db_recursohumano` DEFAULT CHARACTER SET utf8 ;
USE `db_recursohumano`;

-- -----------------------------------------------------
-- Table `db_recursohumano`.`discapacidad`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `db_recursohumano`.`discapacidad` (
  `id_discapacidad` SMALLINT(6) NOT NULL AUTO_INCREMENT,
  `discapacidad` VARCHAR(50) NOT NULL,
  PRIMARY KEY (`id_discapacidad`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `db_recursohumano`.`genero`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `db_recursohumano`.`genero` (
  `id_genero` VARCHAR(2) NOT NULL,
  `genero` VARCHAR(50) NOT NULL,
  PRIMARY KEY (`id_genero`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `db_recursohumano`.`puesto`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `db_recursohumano`.`puesto` (
  `id_puesto` BIGINT(20) NULL,
  `puesto` VARCHAR(50) NOT NULL,
  PRIMARY KEY (`id_puesto`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `db_recursohumano`.`titulo`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `db_recursohumano`.`titulo` (
  `id_titulo_obtenido` SMALLINT(6) NOT NULL AUTO_INCREMENT,
  `titulo` VARCHAR(50) NOT NULL,
  PRIMARY KEY (`id_titulo_obtenido`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `db_recursohumano`.`estado`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `db_recursohumano`.`estado` (
  `id_estado_nac` INT NOT NULL AUTO_INCREMENT,
  `estado` VARCHAR(50) NOT NULL,
  PRIMARY KEY (`id_estado_nac`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `db_recursohumano`.`empleado`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `db_recursohumano`.`empleado` (
  `id_empleado` BIGINT NOT NULL AUTO_INCREMENT,
  `nombre` VARCHAR(50) NOT NULL,
  `apellido_paterno` VARCHAR(50) NULL,
  `apellido_materno` VARCHAR(50) NULL,
  `telefono_local` VARCHAR(12) NULL DEFAULT 'null',
  `telefono_movil` VARCHAR(12) NULL DEFAULT 'null',
  `direccion` VARCHAR(50) NULL DEFAULT 'null',
  `fec_nac` DATE NULL,
  `curp` VARCHAR(18) NULL,
  `observaciones` VARCHAR(100) NULL,
  `email` VARCHAR(50) NULL,
  `ins_fec` DATETIME NULL,
  `codigo_postal` VARCHAR(5) NULL,
  `estado_nacimiento` VARCHAR(5) NULL,
  `id_genero` VARCHAR(2) NOT NULL,
  `id_titulo_obtenido` SMALLINT(6) NOT NULL,
  `nacionalidad` VARCHAR(30) NULL,
  `trabaja_actualmente` TINYINT(1) NULL,
  `id_discapacidad` SMALLINT(6) NOT NULL,
  `red_social` VARCHAR(50) NULL,
  `numero_seguro_social` VARCHAR(45) NULL,
  `unidad_medicina_familiar` VARCHAR(45) NULL,
  `comunidad_indigena` VARCHAR(200) NULL,
  `procede_comunidad_indigena` TINYINT(4) NULL,
  `num_interior` VARCHAR(20) NULL,
  `num_exterior` VARCHAR(20) NULL,
  `id_puesto` BIGINT(20) NOT NULL,
  `rfc` VARCHAR(20) NULL,
  `estatura` SMALLINT(6) NULL,
  `peso` SMALLINT(6) NULL,
  `sueldo_deseado` DECIMAL(10,2) NULL,
  `id_estado_nac` INT NOT NULL,
  PRIMARY KEY (`id_empleado`),
  CONSTRAINT FK_estado_idx FOREIGN KEY (id_estado_nac) REFERENCES estado(id_estado_nac),
  CONSTRAINT FK_puesto_idx FOREIGN KEY (id_puesto) REFERENCES puesto(id_puesto),
  CONSTRAINT FK_discap_idx FOREIGN KEY (id_discapacidad) REFERENCES discapacidad(id_discapacidad),
  CONSTRAINT FK_gen_idx FOREIGN KEY (id_genero) REFERENCES genero(id_genero), 
  CONSTRAINT FK_titul_idx FOREIGN KEY (id_titulo_obtenido) REFERENCES titulo(id_titulo_obtenido) 
)
ENGINE = InnoDB;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;

-- ----------------------------------------------------- 
-- Inserción Tabla `db_recursohumano`.`discapacidad`
-- -----------------------------------------------------
insert into discapacidad values (null,'física');
insert into discapacidad values (null,'sensorial');
insert into discapacidad values (null,'intelectual');
insert into discapacidad values (null,'psíquica');

-- ----------------------------------------------------
-- Inserción Tabla `db_recursohumano`.`genero`
-- -----------------------------------------------------
insert into genero values ('h','masculino');
insert into genero values ('m','femenino');

-- ----------------------------------------------------
-- Inserción Tabla `db_recursohumano`.`puesto`
-- -----------------------------------------------------
insert into puesto values (1,'promotor');
insert into puesto values (2,'gerente comercial');
insert into puesto values (3,'vendedor');
insert into puesto values (4,'jefe de departamento');

-- ----------------------------------------------------
-- Inserción Tabla `db_recursohumano`.`titulo`
-- -----------------------------------------------------
insert into titulo values (null,'maestría');
insert into titulo values (null,'ingeniería/licenciatura');
insert into titulo values (null,'doctorado');
insert into titulo values (null,'secundaría');
insert into titulo values (null,'primaria');
insert into titulo values (null,'preparatoria');

-- ----------------------------------------------------
-- Inserción Tabla `db_recursohumano`.`estado`
-- -----------------------------------------------------
insert into estado values (null,'sonora');
insert into estado values (null,'durango');
insert into estado values (null,'CDMX');
insert into estado values (null,'tabasco');

-- ----------------------------------------------------
-- Inserción Tabla `db_recursohumano`.`empleado`
-- -----------------------------------------------------
insert into empleado values (null,'Edgar Alejandro','Fernández','Avila','26438852','5581388044','Av.Oceania #185');
insert into estado values (null,'durango');
insert into estado values (null,'CDMX');
insert into estado values (null,'tabasco');





