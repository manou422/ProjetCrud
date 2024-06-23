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
-- Table structure for table `produit`
--

DROP TABLE IF EXISTS `produit`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `produit` (
  `referenceproduit` char(4) NOT NULL,
  `designation` varchar(30) DEFAULT NULL,
  `quantite` int DEFAULT NULL,
  `descriptif` varchar(100) DEFAULT NULL,
  `prix_unitaire_ht` decimal(9,2) DEFAULT NULL,
  `stock` int DEFAULT NULL,
  `poids_piece` int DEFAULT NULL,
  PRIMARY KEY (`referenceproduit`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `produit`
--

LOCK TABLES `produit` WRITE;
/*!40000 ALTER TABLE `produit` DISABLE KEYS */;
INSERT INTO `produit` VALUES ('1004','FEU DE JOIE LIQUEUR ASSORT.',500,'G',23.00,50,0),('1007','TENDRE FRUIT',500,'G',18.00,120,0),('1015','CARACAO',500,'G',24.50,50,0),('1016','COKTAIL',500,'G',33.00,40,0),('1017','ORFIN',500,'G',32.00,40,0),('3002','CARRE PECTO',500,'G',29.00,40,0),('3004','ZAN ALESAN',25,'P',15.00,50,20),('3010','PATES GRISES',500,'G',35.00,100,0),('3016','CARAMEL AU LAIT',500,'G',20.00,100,0),('3017','VIOLETTE TRADITION',500,'G',25.00,100,0),('4002','SUCETTE BOULE FRUIT',25,'P',14.00,100,40),('4004','SUCETTE BOULE POP',25,'P',21.00,50,40),('4010','CARAMBAR',40,'P',18.00,20,15),('4011','CARANOUGA',40,'P',18.00,100,15),('4012','CARAMBAR FRUIT',40,'P',18.00,100,15),('4013','CARAMBAR COLA',40,'P',18.00,50,15),('4015','SOURIS REGLISSE',500,'G',24.00,50,0),('4016','SOURIS CHOCO',500,'G',24.00,50,0),('4019','SCHTROUMPFS VERTS',500,'G',24.00,50,0),('4020','CROCODILE',500,'G',21.00,50,0),('4022','PERSICA',500,'G',28.00,20,0),('4025','COLA CITRIQUE',500,'G',21.00,50,0),('4026','COLA LISSE',500,'G',25.00,50,0),('4027','BANANE',1000,'G',23.00,20,0),('4029','OEUF SUR LE PLAT',500,'G',25.00,20,0),('4030','FRAISIBUS',500,'G',25.00,50,0),('4031','FRAISE TSOIN-TSOIN',500,'G',25.00,40,0),('4032','METRE REGLISSE ROULE',500,'G',19.00,50,0),('4033','MAXI COCOBAT',1000,'G',19.00,20,0),('4034','DENTS VAMPIRE',500,'G',22.00,50,0),('4036','LANGUE COLA CITRIQUE',500,'G',21.00,40,0),('4037','OURSON CANDI',1000,'G',21.00,50,0),('4039','SERPENT ACIDULE',500,'G',21.00,20,0),('4042','TETINE CANDI',500,'G',20.00,40,0),('4045','COLLIER PECCOS',15,'P',21.00,50,50),('4052','TWIST ASSORTIS',500,'G',22.00,50,0),('4053','OURSON GUIMAUVE',500,'G',35.00,10,0),('4054','BOULE COCO MULER',500,'G',34.00,10,0),('4055','COCOMALLOW',500,'G',33.00,10,0),('4057','CRIC-CRAC',500,'G',33.00,10,0);
/*!40000 ALTER TABLE `produit` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2024-06-11 16:15:32
