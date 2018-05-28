CREATE TABLE `initable` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `CodeSetName` varchar(45) NOT NULL,
  `CodeSetValue` varchar(45) NOT NULL,
  `CodeSetId` int(11) NOT NULL,
  `Status` tinyint(4) NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
