-- MySQL dump 10.13  Distrib 8.0.36, for Win64 (x86_64)
--
-- Host: localhost    Database: projects
-- ------------------------------------------------------
-- Server version	8.0.36

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `202421`
--

DROP TABLE IF EXISTS `202421`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `202421` (
  `record_time` datetime NOT NULL,
  `expenditure` varchar(20) NOT NULL,
  `category` enum('material','labor') NOT NULL,
  `amount` double NOT NULL,
  `cash_flow` enum('inward','outward') NOT NULL,
  PRIMARY KEY (`record_time`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `202421`
--

LOCK TABLES `202421` WRITE;
/*!40000 ALTER TABLE `202421` DISABLE KEYS */;
INSERT INTO `202421` VALUES ('2024-05-08 18:58:51','gravel','material',15000,'outward'),('2024-05-09 09:41:59','sand','material',1000,'outward'),('2024-05-09 12:56:39','Nails','material',4000,'outward'),('2024-05-12 12:27:09','Door','material',300,'inward'),('2024-05-12 13:54:53','Beam','material',5000,'outward');
/*!40000 ALTER TABLE `202421` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `202422`
--

DROP TABLE IF EXISTS `202422`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `202422` (
  `record_time` datetime NOT NULL,
  `expenditure` varchar(20) NOT NULL,
  `category` enum('material','labor') NOT NULL,
  `amount` double NOT NULL DEFAULT '0',
  `cash_flow` enum('inward','outward') NOT NULL,
  PRIMARY KEY (`record_time`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `202422`
--

LOCK TABLES `202422` WRITE;
/*!40000 ALTER TABLE `202422` DISABLE KEYS */;
INSERT INTO `202422` VALUES ('2024-05-11 10:21:13','Fiber Glass','material',7000,'outward'),('2024-05-12 05:03:35','food','labor',1000,'outward'),('2024-05-13 17:57:33','Windows','material',10000,'outward'),('2024-05-13 17:58:14','Nails','material',100,'outward'),('2024-05-13 17:58:27','Sand','material',15000,'outward');
/*!40000 ALTER TABLE `202422` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `202429`
--

DROP TABLE IF EXISTS `202429`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `202429` (
  `record_time` datetime NOT NULL,
  `expenditure` varchar(20) NOT NULL,
  `category` enum('material','labor') NOT NULL,
  `amount` double NOT NULL DEFAULT '0',
  `cash_flow` enum('inward','outward') NOT NULL,
  PRIMARY KEY (`record_time`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `202429`
--

LOCK TABLES `202429` WRITE;
/*!40000 ALTER TABLE `202429` DISABLE KEYS */;
INSERT INTO `202429` VALUES ('2024-05-20 12:58:32','I beams','material',30000,'outward'),('2024-05-20 13:01:30','6 truckload of sand','material',13800,'outward'),('2024-05-20 13:02:20','4 truckload Gravel','material',10000,'outward'),('2024-05-20 13:02:54','Safety equipments','material',7000,'outward'),('2024-05-20 13:03:46','1st month Payroll','labor',133200,'outward'),('2024-05-20 13:04:51','600 x 3 Holes CHB','material',9000,'outward'),('2024-05-20 13:06:01','Paper works','labor',160000,'outward'),('2024-05-20 13:06:27','Electric Utilities','labor',12000,'outward'),('2024-05-20 13:08:55','120 sacks Cement','material',30480,'outward'),('2024-05-20 13:10:54','30 Phenolic Plywood','material',27900,'outward'),('2024-05-20 13:12:32','clients additional','labor',50000,'inward');
/*!40000 ALTER TABLE `202429` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2024-05-22 22:39:31
-- MySQL dump 10.13  Distrib 8.0.36, for Win64 (x86_64)
--
-- Host: localhost    Database: info
-- ------------------------------------------------------
-- Server version	8.0.36

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `accounts`
--

DROP TABLE IF EXISTS `accounts`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `accounts` (
  `id` int NOT NULL,
  `firstName` varchar(20) NOT NULL,
  `surname` varchar(20) NOT NULL,
  `username` varchar(20) NOT NULL,
  `password` varchar(20) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `accounts`
--

LOCK TABLES `accounts` WRITE;
/*!40000 ALTER TABLE `accounts` DISABLE KEYS */;
INSERT INTO `accounts` VALUES (1,'Angelito','Sanchez','angelitosanchez','admin');
/*!40000 ALTER TABLE `accounts` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `directories`
--

DROP TABLE IF EXISTS `directories`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `directories` (
  `year` int NOT NULL DEFAULT '2024',
  `proj_id` int NOT NULL AUTO_INCREMENT,
  `ProjName` varchar(25) NOT NULL,
  `DateStarted` date DEFAULT NULL,
  `DateEnded` date DEFAULT NULL,
  `ClientName` varchar(20) NOT NULL,
  `Budget` double NOT NULL,
  PRIMARY KEY (`proj_id`,`year`)
) ENGINE=InnoDB AUTO_INCREMENT=31 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `directories`
--

LOCK TABLES `directories` WRITE;
/*!40000 ALTER TABLE `directories` DISABLE KEYS */;
INSERT INTO `directories` VALUES (2024,21,'Casa Milagrosa','2024-05-08','2024-05-20','Grace Gracia',100000),(2024,22,'Cottage','2024-05-08',NULL,'Lualhati Liwanag',100000),(2024,29,'2 Storey Commercial','2024-05-20','2025-11-12','Eduardo Ramos',3200000);
/*!40000 ALTER TABLE `directories` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2024-05-22 22:39:32
