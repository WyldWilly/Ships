CREATE TABLE `shipindex` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(45) NOT NULL,
  `Registry` varchar(15) NOT NULL,
  `Class` varchar(45) NOT NULL,
  `Type` int(11) NOT NULL,
  `ClassShip` tinyint(4) NOT NULL,
  `Status` tinyint(4) NOT NULL DEFAULT '1',
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
