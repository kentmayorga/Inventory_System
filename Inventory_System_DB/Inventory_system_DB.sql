-- MySQL dump 10.13  Distrib 8.0.41, for Win64 (x86_64)
--
-- Host: localhost    Database: mydb
-- ------------------------------------------------------
-- Server version	8.0.41

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
-- Table structure for table `cart`
--

DROP TABLE IF EXISTS `cart`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `cart` (
  `id` int NOT NULL AUTO_INCREMENT,
  `product_id` int DEFAULT NULL,
  `user_id` int DEFAULT NULL,
  `quantity` int DEFAULT '1',
  `added_at` timestamp NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`id`),
  KEY `user_id` (`user_id`),
  KEY `product_id` (`product_id`),
  CONSTRAINT `cart_ibfk_1` FOREIGN KEY (`user_id`) REFERENCES `users` (`id`),
  CONSTRAINT `cart_ibfk_2` FOREIGN KEY (`product_id`) REFERENCES `products` (`ProductID`)
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cart`
--

LOCK TABLES `cart` WRITE;
/*!40000 ALTER TABLE `cart` DISABLE KEYS */;
INSERT INTO `cart` VALUES (5,1,1,20,'2025-03-22 09:24:47'),(6,2,1,5,'2025-03-22 09:24:51'),(7,1,3,15,'2025-03-22 10:42:59'),(8,2,3,5,'2025-03-22 10:43:06'),(9,1,4,20,'2025-04-07 03:09:04');
/*!40000 ALTER TABLE `cart` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `products`
--

DROP TABLE IF EXISTS `products`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `products` (
  `ProductID` int NOT NULL AUTO_INCREMENT,
  `Name` varchar(255) DEFAULT NULL,
  `Description` varchar(500) DEFAULT NULL,
  `Price` decimal(10,2) DEFAULT NULL,
  `Stock` int DEFAULT NULL,
  `ImagePath` varchar(255) DEFAULT NULL,
  `sold` int DEFAULT NULL,
  PRIMARY KEY (`ProductID`)
) ENGINE=InnoDB AUTO_INCREMENT=21 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `products`
--

LOCK TABLES `products` WRITE;
/*!40000 ALTER TABLE `products` DISABLE KEYS */;
INSERT INTO `products` VALUES (1,'Coffee Grinder','Grinds coffee beans to desired consistency.',400.00,1000,'C:\\Users\\Lendon A. Manga\\Source\\Repos\\Inventory_System\\Inventory_CoffeshopEquipment\\Invent-coffee\\Invent coffee\\Ass\\Coffee grinder.jpg',55),(2,'Coffee Scale','Digital Scale for prescise coffee measurements.',400.00,1000,'C:\\Users\\Lendon A. Manga\\Source\\Repos\\Inventory_System\\Inventory_CoffeshopEquipment\\Invent-coffee\\Invent coffee\\Ass\\Coffee scale.jpg',10),(3,'Espresso Tamper','Compresses coffee grounds for even extraction',300.00,1000,'C:\\Users\\Lendon A. Manga\\Source\\Repos\\Inventory_System\\Inventory_CoffeshopEquipment\\Invent-coffee\\Invent coffee\\Ass\\Empresso tamper.jpeg',0),(4,'Milk Frothing Pitcher','Stainless steel pitcher for streaming and frothing milk.',400.00,1000,'C:\\Users\\Lendon A. Manga\\Source\\Repos\\Inventory_System\\Inventory_CoffeshopEquipment\\Invent-coffee\\Invent coffee\\Ass\\Milk frothing.jpg',0),(5,'Knock Box','Used to disposed of used coffee grounds.',500.00,1000,'C:\\Users\\Lendon A. Manga\\Source\\Repos\\Inventory_System\\Inventory_CoffeshopEquipment\\Invent-coffee\\Invent coffee\\Ass\\Knock box.jpg',0),(6,'Coffee Dripper ','Used for pour-over coffee brewing.',450.00,1000,'C:\\Users\\Lendon A. Manga\\Source\\Repos\\Inventory_System\\Inventory_CoffeshopEquipment\\Invent-coffee\\Invent coffee\\Ass\\Coffee dripper.jpg',0),(7,'Thermometer','Measures milk temperature for steaming.',250.00,1000,'C:\\Users\\Lendon A. Manga\\Source\\Repos\\Inventory_System\\Inventory_CoffeshopEquipment\\Invent-coffee\\Invent coffee\\Ass\\Theometer.jpg',0),(8,'Portafilter','Holds coffee grounds for espresso machines.',1000.00,1000,'C:\\Users\\Lendon A. Manga\\Source\\Repos\\Inventory_System\\Inventory_CoffeshopEquipment\\Invent-coffee\\Invent coffee\\Ass\\portafilter.jpg',0),(9,'Shot Glass','Measures espresso shots',20.00,1000,'C:\\Users\\Lendon A. Manga\\Source\\Repos\\Inventory_System\\Inventory_CoffeshopEquipment\\Invent-coffee\\Invent coffee\\Ass\\Shot glass.jpg',0),(10,'Cleaning Brush','Cleans coffee grinders and machines',300.00,1000,'C:\\Users\\Lendon A. Manga\\Source\\Repos\\Inventory_System\\Inventory_CoffeshopEquipment\\Invent-coffee\\Invent coffee\\Ass\\cleaning brush.jpg',0),(11,'Coffee Filters','Paper or metal filters for drip coffee. ',250.00,1000,'C:\\Users\\Lendon A. Manga\\Source\\Repos\\Inventory_System\\Inventory_CoffeshopEquipment\\Invent-coffee\\Invent coffee\\Ass\\coffee filter.jpg',0),(12,'Measuring Spoons','Used for accurate coffee to water ratio.',250.00,1000,'C:\\Users\\Lendon A. Manga\\Source\\Repos\\Inventory_System\\Inventory_CoffeshopEquipment\\Invent-coffee\\Invent coffee\\Ass\\Measuring spoon.jpg',0),(13,'Tamping Mat','Provides a surface for tamping espresso.',300.00,1000,'C:\\Users\\Lendon A. Manga\\Source\\Repos\\Inventory_System\\Inventory_CoffeshopEquipment\\Invent-coffee\\Invent coffee\\Ass\\Tampping map.jpg',0),(14,'Cupping Spoons ','Used for tasting and evaluating coffee.',500.00,1000,'C:\\Users\\Lendon A. Manga\\Source\\Repos\\Inventory_System\\Inventory_CoffeshopEquipment\\Invent-coffee\\Invent coffee\\Ass\\cupping spoon.jpg',0),(15,'Pitcher Rinser ','Cleans milk forthing pitchers quickly.',1500.00,1000,'C:\\Users\\Lendon A. Manga\\Source\\Repos\\Inventory_System\\Inventory_CoffeshopEquipment\\Invent-coffee\\Invent coffee\\Ass\\pitcher rinser.jpg',0),(16,'French Press ','Manual coffee brewing method using immersion.',800.00,1000,'C:\\Users\\Lendon A. Manga\\Source\\Repos\\Inventory_System\\Inventory_CoffeshopEquipment\\Invent-coffee\\Invent coffee\\Ass\\French pree.jpg',0),(17,'Cold Brew Maker ','Equipment for brewing cold coffee over long hours.',1000.00,1000,'C:\\Users\\Lendon A. Manga\\Source\\Repos\\Inventory_System\\Inventory_CoffeshopEquipment\\Invent-coffee\\Invent coffee\\Ass\\Cold brew maker.jpg',0),(18,'Gooseneck Kettle  ','Precision pour-over kettle with a narrow spout.',1000.00,1000,'C:\\Users\\Lendon A. Manga\\Source\\Repos\\Inventory_System\\Inventory_CoffeshopEquipment\\Invent-coffee\\Invent coffee\\Ass\\gooseneck kettle.jpg',0),(19,'Moka Pot   ','Stovetop espresso maker.',800.00,1000,'C:\\Users\\Lendon A. Manga\\Source\\Repos\\Inventory_System\\Inventory_CoffeshopEquipment\\Invent-coffee\\Invent coffee\\Ass\\moka pot.jpg',0),(20,'Aeropress','Portable coffee brewing device for smooth coffee.',700.00,1000,'C:\\Users\\Lendon A. Manga\\Source\\Repos\\Inventory_System\\Inventory_CoffeshopEquipment\\Invent-coffee\\Invent coffee\\Ass\\aeropress.jpg',0);
/*!40000 ALTER TABLE `products` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `users`
--

DROP TABLE IF EXISTS `users`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `users` (
  `id` int NOT NULL AUTO_INCREMENT,
  `username` varchar(50) DEFAULT NULL,
  `password` varchar(50) DEFAULT NULL,
  `role` varchar(20) DEFAULT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `username` (`username`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `users`
--

LOCK TABLES `users` WRITE;
/*!40000 ALTER TABLE `users` DISABLE KEYS */;
INSERT INTO `users` VALUES (1,'kent','ae100c9c6062596a33cf4eefa3ef21d4','user'),(2,'admin','7b0172b419534186a9af2f95b040e7b8','admin'),(3,'kim','7b0172b419534186a9af2f95b040e7b8','user'),(4,'Lendon','ae100c9c6062596a33cf4eefa3ef21d4',NULL);
/*!40000 ALTER TABLE `users` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2025-04-13 19:51:39
