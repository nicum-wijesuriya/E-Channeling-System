-- MySQL dump 10.13  Distrib 5.7.9, for Win64 (x86_64)
--
-- Host: localhost    Database: amc
-- ------------------------------------------------------
-- Server version	5.7.13-log

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
-- Table structure for table `speciality`
--

DROP TABLE IF EXISTS `speciality`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `speciality` (
  `SID` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(60) DEFAULT NULL,
  PRIMARY KEY (`SID`)
) ENGINE=InnoDB AUTO_INCREMENT=61 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `speciality`
--

LOCK TABLES `speciality` WRITE;
/*!40000 ALTER TABLE `speciality` DISABLE KEYS */;
INSERT INTO `speciality` VALUES (1,'Cardiac Electrophysiologists'),(2,'Cardiologists'),(3,'Cardiothoracic Surgeons '),(4,'Chest Physicians '),(5,'Chest Specialists '),(6,'Dental Surgeons '),(7,'Dermatologists '),(8,'Dermatology & Hair Specialists '),(9,'Diabetes & Endocrinology Physician '),(10,'Diabetologists & Endocrinologists '),(11,'Dietician & Nutritionists '),(12,'Dieticians '),(13,'ENT Surgeons '),(14,'Eye Surgeon '),(15,'Gastroenterological Surgeon '),(16,'Gastroenterologists (Medical) '),(17,'Gastrointestinal Surgeons '),(18,'Gynaecologists '),(19,'Haematologists '),(20,'Immunologists '),(21,'Interventional Cardiologists '),(22,'Medical Microbiologists '),(23,'Nephrologist & Physicians '),(24,'Nephrologists '),(25,'Neuro Physicians '),(26,'Neurosurgeons '),(27,'Obstetrician Gynaecologist & Infertility Specialists '),(28,'Oncological Surgeons '),(29,'Oncologists (Cancer Specialists) '),(30,'Oral Maxillofacial Surgeons '),(31,'Orthodontists '),(32,'Orthopaedic Surgeons '),(33,'Paediatric  Cardiologists '),(34,'Paediatric Cardiothoracic Surgeons '),(35,'Paediatric Neurologists '),(36,'Paediatric Orthopaedic Surgeons '),(37,'Paediatric Surgeons '),(38,'Paediatricians '),(39,'Parasitologists '),(40,'Physician & Endocrinologist/Diabetologist '),(41,'Physician and Immunologist '),(42,'Physicians '),(43,'Physiotherapists '),(44,'Plastic Surgeons '),(45,'Psychiatrists '),(46,'Psychologists '),(47,'Rheumatologists '),(48,'Sexual Medicine '),(49,'Speech & Language Therapists '),(50,'Speech Therapists '),(51,'Speech, Language Pathologist & Audiologists '),(52,'Speech, Pathologist & Therapists '),(53,'Sport Medicine '),(54,'STD Specialists '),(55,'Surgeons '),(56,'Thoracic Surgeon '),(57,'Transplant & Genitourinary Surgeons '),(58,'Urologists '),(59,'Vaccinologist '),(60,'Vascular Surgeons ');
/*!40000 ALTER TABLE `speciality` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2016-07-27 12:10:30
