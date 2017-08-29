CREATE DATABASE  IF NOT EXISTS `db_mtcsystem` /*!40100 DEFAULT CHARACTER SET utf8 */;
USE `db_mtcsystem`;
-- MySQL dump 10.13  Distrib 5.7.9, for Win32 (AMD64)
--
-- Host: 127.0.0.1    Database: db_mtcsystem
-- ------------------------------------------------------
-- Server version	5.6.21-log

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `tblcriminalcase`
--

DROP TABLE IF EXISTS `tblcriminalcase`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tblcriminalcase` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `CaseNo` int(11) DEFAULT NULL,
  `NameofAccused` varchar(200) DEFAULT NULL,
  `Nature` varchar(200) DEFAULT NULL,
  `DateFiled` varchar(200) DEFAULT NULL,
  `DateRaffled` varchar(200) DEFAULT NULL,
  `DatePretrial` varchar(200) DEFAULT NULL,
  `DateArraignment` varchar(200) DEFAULT NULL,
  `DateInitialtrial` varchar(200) DEFAULT NULL,
  `Lasttrial` varchar(200) DEFAULT NULL,
  `DateSubmittedDecision` varchar(200) DEFAULT NULL,
  `Remarks` varchar(500) DEFAULT NULL,
  `JudgeAssigned` varchar(200) DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tblcriminalcase`
--

LOCK TABLES `tblcriminalcase` WRITE;
/*!40000 ALTER TABLE `tblcriminalcase` DISABLE KEYS */;
/*!40000 ALTER TABLE `tblcriminalcase` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2017-08-23  8:31:18
