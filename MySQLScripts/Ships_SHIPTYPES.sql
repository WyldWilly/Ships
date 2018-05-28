CREATE TABLE `shiptypes` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `ShipTypeName` varchar(45) NOT NULL,
  `ShipTypeCode` int(11) NOT NULL,
  `Abbrev` varchar(10) NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
