CREATE TABLE `customer` (
  `Id` int(11) NOT NULL,
  `Name` varchar(10) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `PersonalId` varchar(10) NOT NULL,
  `Birthday` date NOT NULL,
  `Address` varchar(100) CHARACTER SET utf8 COLLATE utf8_general_ci DEFAULT NULL,
  `Email` varchar(100) DEFAULT NULL,
  `Phone` varchar(10) NOT NULL,
  `EmergencyContact` varchar(10) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `EmergencyPhone` varchar(10) NOT NULL,
  `GuardianName` varchar(10) DEFAULT NULL,
  `GuardianPersonalId` varchar(10) DEFAULT NULL,
  `GuardianBirthday` datetime DEFAULT NULL,
  `GuardianPhone` varchar(10) DEFAULT NULL,
  `CreateOn` datetime DEFAULT CURRENT_TIMESTAMP,
  `ModifiedOn` datetime DEFAULT CURRENT_TIMESTAMP,
  `MedicalCase` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
