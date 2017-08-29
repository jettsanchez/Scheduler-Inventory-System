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
-- Table structure for table `tblcivilcase`
--

DROP TABLE IF EXISTS `tblcivilcase`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tblcivilcase` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `CaseNo` int(11) DEFAULT NULL,
  `NameofAccused` varchar(200) DEFAULT NULL,
  `Nature` varchar(200) DEFAULT NULL,
  `DateFiled` varchar(200) DEFAULT NULL,
  `DateRaffled` varchar(200) DEFAULT NULL,
  `DatePretrial` varchar(200) DEFAULT NULL,
  `DateInitialtrial` varchar(200) DEFAULT NULL,
  `Lasttrial` varchar(200) DEFAULT NULL,
  `DateSubmittedDecision` varchar(200) DEFAULT NULL,
  `Remarks` varchar(200) DEFAULT NULL,
  `JudgeAssigned` varchar(200) DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tblcivilcase`
--

LOCK TABLES `tblcivilcase` WRITE;
/*!40000 ALTER TABLE `tblcivilcase` DISABLE KEYS */;
/*!40000 ALTER TABLE `tblcivilcase` ENABLE KEYS */;
UNLOCK TABLES;

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

--
-- Table structure for table `tbldatehearing`
--

DROP TABLE IF EXISTS `tbldatehearing`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tbldatehearing` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `NameofAccused` varchar(200) DEFAULT NULL,
  `DateofHearing` date DEFAULT NULL,
  `Nature` varchar(200) DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbldatehearing`
--

LOCK TABLES `tbldatehearing` WRITE;
/*!40000 ALTER TABLE `tbldatehearing` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbldatehearing` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tblfilterforcivilcase`
--

DROP TABLE IF EXISTS `tblfilterforcivilcase`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tblfilterforcivilcase` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `Topic` varchar(200) DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tblfilterforcivilcase`
--

LOCK TABLES `tblfilterforcivilcase` WRITE;
/*!40000 ALTER TABLE `tblfilterforcivilcase` DISABLE KEYS */;
INSERT INTO `tblfilterforcivilcase` VALUES (1,'CaseNo'),(2,'Name of Accused'),(3,'Nature'),(4,'Date Filed'),(5,'Date Raffled'),(6,'Date of Pretrial'),(7,'Date of InitialTrial'),(8,'Last Trial'),(9,'Judge Assigned');
/*!40000 ALTER TABLE `tblfilterforcivilcase` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tblfilterforcriminalcase`
--

DROP TABLE IF EXISTS `tblfilterforcriminalcase`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tblfilterforcriminalcase` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `Topic` varchar(200) DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tblfilterforcriminalcase`
--

LOCK TABLES `tblfilterforcriminalcase` WRITE;
/*!40000 ALTER TABLE `tblfilterforcriminalcase` DISABLE KEYS */;
INSERT INTO `tblfilterforcriminalcase` VALUES (1,'CriminalCaseNo'),(2,'NameofAccused'),(3,'Nature'),(4,'DateFiled'),(5,'DateRaffled'),(6,'Date of Pre Trial'),(7,'Date of Arraignment'),(8,'Date of Initial Trial'),(9,'Date of Last Trial'),(10,'Date of Submitted Decision'),(11,'Judge Assigned');
/*!40000 ALTER TABLE `tblfilterforcriminalcase` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tblinformation`
--

DROP TABLE IF EXISTS `tblinformation`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tblinformation` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `CaseTitle` varchar(200) DEFAULT NULL,
  `CaseNo` int(100) DEFAULT NULL,
  `Firstname` varchar(200) DEFAULT NULL,
  `Lastname` varchar(200) DEFAULT NULL,
  `Middlename` varchar(200) DEFAULT NULL,
  `NicknameAlias` varchar(200) DEFAULT NULL,
  `CityAddress` varchar(200) DEFAULT NULL,
  `ProvincialAddress` varchar(200) DEFAULT NULL,
  `TelCellno` bigint(20) DEFAULT NULL,
  `Age` bigint(20) DEFAULT NULL,
  `CivilStatus` varchar(200) DEFAULT NULL,
  `Citizenship` varchar(200) DEFAULT NULL,
  `Gender` varchar(50) DEFAULT NULL,
  `DateBirth` varchar(200) DEFAULT NULL,
  `PlaceBirth` varchar(200) DEFAULT NULL,
  `Height` varchar(200) DEFAULT NULL,
  `Weight` varchar(200) DEFAULT NULL,
  `ColorHair` varchar(100) DEFAULT NULL,
  `ColorEyes` varchar(100) DEFAULT NULL,
  `DistinguishingMarks` varchar(100) DEFAULT NULL,
  `Occupation` varchar(100) DEFAULT NULL,
  `EducationalAttainment` varchar(200) DEFAULT NULL,
  `NameMother` varchar(100) DEFAULT NULL,
  `NameFather` varchar(100) DEFAULT NULL,
  `NameSpouse` varchar(100) DEFAULT NULL,
  `PicturePath` varchar(200) DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tblinformation`
--

LOCK TABLES `tblinformation` WRITE;
/*!40000 ALTER TABLE `tblinformation` DISABLE KEYS */;
/*!40000 ALTER TABLE `tblinformation` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbljudge`
--

DROP TABLE IF EXISTS `tbljudge`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tbljudge` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `Judge` varchar(200) DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbljudge`
--

LOCK TABLES `tbljudge` WRITE;
/*!40000 ALTER TABLE `tbljudge` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbljudge` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tblnature`
--

DROP TABLE IF EXISTS `tblnature`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tblnature` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `Nature` varchar(200) NOT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=16 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tblnature`
--

LOCK TABLES `tblnature` WRITE;
/*!40000 ALTER TABLE `tblnature` DISABLE KEYS */;
INSERT INTO `tblnature` VALUES (1,'ALARM & SCANDAL'),(2,'ATTEMPTED HOMICIDE'),(3,'ESTAFA'),(4,'ORAL DEFARATION'),(5,'RESISTANCE/DISOBEDIENCE UPON AN AGENT OF PERSON IN AUTHORITY'),(7,'THEFT'),(8,'UNJUST VEXATION'),(9,'USURPATION OF AUTHORITY'),(10,'VIOLATION OF 1866'),(11,'VIOLATION OF BP 22'),(12,'VIOLATION OF BP6'),(13,'VIOLATION OF PD 1602'),(14,'VIOLATION OF PD 1616');
/*!40000 ALTER TABLE `tblnature` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tblusers`
--

DROP TABLE IF EXISTS `tblusers`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tblusers` (
  `UserID` int(11) NOT NULL AUTO_INCREMENT,
  `Username` varchar(200) NOT NULL,
  `Password` varchar(200) NOT NULL,
  `Usertype` varchar(45) NOT NULL,
  PRIMARY KEY (`UserID`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tblusers`
--

LOCK TABLES `tblusers` WRITE;
/*!40000 ALTER TABLE `tblusers` DISABLE KEYS */;
INSERT INTO `tblusers` VALUES (1,'admin','admin','admin'),(2,'jett','sanchez','ADMIN');
/*!40000 ALTER TABLE `tblusers` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2017-08-23  8:30:36
