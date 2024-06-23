-- MySQL dump 10.13  Distrib 8.0.30, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: sucrerie
-- ------------------------------------------------------
-- Server version	8.0.30

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
-- Table structure for table `client`
--

DROP TABLE IF EXISTS `client`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `client` (
  `code_c` int NOT NULL,
  `nom` varchar(35) DEFAULT NULL,
  `adresse` varchar(50) DEFAULT NULL,
  `cp` char(5) DEFAULT NULL,
  `ville` varchar(25) DEFAULT NULL,
  `telephone` varchar(16) DEFAULT NULL,
  PRIMARY KEY (`code_c`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `client`
--

LOCK TABLES `client` WRITE;
/*!40000 ALTER TABLE `client` DISABLE KEYS */;
INSERT INTO `client` VALUES (-1,'Vallade','18  allee des rosiers',NULL,'Paris',NULL),(17,'TARINAUX Lucien','12 rue de la Justice','51100','REIMS','03.26.25.48.87'),(46,'MARTUSE','103 avenue Lear','51100','REIMS','03.26.03.25.26'),(47,'RABIN Sandrine','21 rue de la Méditerranée','51100','REIMS','03.26.14.15.25'),(48,'SILLARD Laurence','15 rue Pasentiers','51100','REIMS','03.26.11.11.25'),(49,'COTOY Sylvie','12 rue des écus','51100','REIMS','03.26.10.25.75'),(50,'HELLOU Bernard','21 rue de la Méditerranée','51100','REIMS','03.26.12.25.42'),(51,'HENTION Martine','50 allée des bons enfants','51100','REIMS','03.26.12.25.86'),(52,'SIBAT Evelyne','14 rue de la Baltique','51100','REIMS','03.26.12.23.33'),(53,'MARIN Dominique','24 rue de la Baltique','51100','REIMS','03.26.10.10.23'),(54,'DURDUX Monique','15 allée des Béarnais','51150','VITRY LE FRANCOIS','03.26.42.42.33'),(55,'CANILLE Walter','14 rue Lanterneau','51100','REIMS','03.26.12.12.87'),(56,'BOUQUET Antoinette','1 rue de la Méditerranée','51140','ROMAIN','03.26.78.89.54'),(57,'GAUTON Nadine','5 place des Oiseaux','51200','FISMES','03.26.53.56.55'),(58,'LEGROS Christian','18 place des Oiseaux','51200','FISMES','03.26.44.55.66'),(59,'DUMOITIERS Lucille','12 place Centrale','02320','LONGUEVAL','03.26.86.43.25'),(60,'BOUCHE Carole','4,. rue Brulé','51200','FISMES','03.26.33.96.85'),(61,'Vallade','18  allee des rosiers',NULL,'Paris',NULL),(62,'Vallade','18  allee des rosiers',NULL,'Paris',NULL),(63,'Vallade','18  allee des rosiers',NULL,'Joey Land',NULL),(64,'Vallade','18  allee des rosiers',NULL,'Joey Land',NULL);
/*!40000 ALTER TABLE `client` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2024-06-11 16:15:33
