CREATE TABLE `Users` (
	`User_ID` INT PRIMARY KEY,
	`First_Name` VARCHAR(255),
	`Last_Name` VARCHAR(255),
	`Email` VARCHAR(255),
	`Password` VARCHAR(255),
	`Role` INT,
	`Address` VARCHAR(255)
);

CREATE TABLE `Admin` (
	`Admin_ID` INT PRIMARY KEY,
	`User_ID` INT,
	FOREIGN KEY(`User_ID`) REFERENCES `Users`(`User_ID`)
);

CREATE TABLE `Notifications` (
	`Notification_ID` INT PRIMARY KEY,
	`User_ID` INT,
	`Message` TEXT,
	`Time` TIMESTAMP,
	`Read` BOOLEAN, 
	FOREIGN KEY(`User_ID`) REFERENCES `Users`(`User_ID`)
);

CREATE TABLE `Recruiter` (
	`Recruitment_ID` INT PRIMARY KEY,
	`User_ID` INT,
	FOREIGN KEY(`User_ID`) REFERENCES `Users`(`User_ID`)
);

CREATE TABLE `Employee` (
	`Student_ID` INT PRIMARY KEY,
	`Recruitment_ID` INT,
	FOREIGN KEY(`Recruitment_ID`) REFERENCES `Recruiter`(`Recruitment_ID`)
);

CREATE TABLE `Student_Workers` (
	`VisaStatus_ID` INT PRIMARY KEY,
	`Recruitment_ID` INT,
	FOREIGN KEY(`Recruitment_ID`) REFERENCES `Recruiter`(`Recruitment_ID`)
);

CREATE TABLE `RightToWorkDocuments` (
	`RTW_ID` INT PRIMARY KEY,
	`Student_ID` INT,
	`Document_URL` VARCHAR(255),
	`Upload_Date` TIMESTAMP,
	FOREIGN KEY(`Student_ID`) REFERENCES `Employee`(`Student_ID`)
);

CREATE TABLE `VisaStatus` (
	`VisaStatusID` INT PRIMARY KEY,
	`Student_ID` INT,
	`Status` BOOLEAN, 
	`ExpiryDate` TIMESTAMP,
	FOREIGN KEY(`Student_ID`) REFERENCES `Employee`(`Student_ID`)
);

CREATE TABLE `WorkingHoursOffers` (
	`Offer_ID` INT PRIMARY KEY,
	`Student_ID` INT,
	`Hours_Offered` DECIMAL(10,2),
	`Status` BOOLEAN,
	`Offer_Date` TIMESTAMP,
	FOREIGN KEY(`Student_ID`) REFERENCES `Employee`(`Student_ID`)
);

CREATE TABLE `Timesheets` (
	`Timesheet_ID` INT PRIMARY KEY,
	`Student_ID` INT,
	`Recruitment_ID` INT,
	`Hours_Worked` DECIMAL(10,2),
	`Status` BOOLEAN,
	`Date_Uploaded` TIMESTAMP,
	`Date_Reviewed` TIMESTAMP,
	FOREIGN KEY(`Recruitment_ID`) REFERENCES `Recruiter`(`Recruitment_ID`),
	FOREIGN KEY(`Student_ID`) REFERENCES `Employee`(`Student_ID`)
);
