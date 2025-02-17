CREATE TABLE "Users" (
	"User_ID"	INTEGER,
	"First_Name"	TEXT,
	"Last_Name"	TEXT,
	"Email"	TEXT,
	"Password"	TEXT,
	"Role"	INTEGER,
	"Address"	TEXT,
	PRIMARY KEY("User_ID")
);

CREATE TABLE "Admin" (
	"Admin_ID"	INTEGER,
	"User_ID"	INTEGER,
	PRIMARY KEY("Admin_ID"),
	FOREIGN KEY("User_ID") REFERENCES "Users"("User_ID")
);

CREATE TABLE "Notifications" (
	"Notification_ID"	INTEGER,
	"User_ID"	INTEGER,
	"Message"	TEXT,
	"Time"	TEXT,
	"Read"	INTEGER,              -- Sqlite does not contain native boolean support, treat the int as a 1,0 bool
	PRIMARY KEY("Notification_ID"),
	FOREIGN KEY("User_ID") REFERENCES "Users"("User_ID")
);



CREATE TABLE "Recruiter" (
	"Recruitment_ID"	INTEGER,
	"User_ID"	INTEGER,
	PRIMARY KEY("Recruitment_ID"),
	FOREIGN KEY("User_ID") REFERENCES "Users"("User_ID")
);

CREATE TABLE "Employee" (				-- Location Of Employee Table May Need Updating 
	"Student_ID"	INTEGER,
	"Recruitment_ID"	INTEGER,
	PRIMARY KEY("Student_ID"),
	FOREIGN KEY("Recruitment_ID") REFERENCES "Recruiter"("Recruitment_ID")
);

CREATE TABLE "Student Workers" (
	"VisaStatus_ID"	INTEGER,
	"Recruitment_ID"	INTEGER,
	PRIMARY KEY("VisaStatus_ID"),
	FOREIGN KEY("Recruitment_ID") REFERENCES "Recruiter"("Recruitment_ID")
);

CREATE TABLE "RightToWorkDocuments" (
	"RTW_ID"	INTEGER,
	"Student_ID"	INTEGER,
	"Document_URL"	TEXT,
	"Upload_Date"	TEXT,
	PRIMARY KEY("RTW_ID"),
	FOREIGN KEY("Student_ID") REFERENCES "Employee"("Student_ID")
);
CREATE TABLE "VisaStatus" (
	"VisaStatusID"	INTEGER,
	"Student_ID"	INTEGER,
	"Status"	INTEGER,	 -- Sqlite does not contain native boolean support, treat the int as a 1,0 bool
	"ExpiryDate"	INTEGER,
	PRIMARY KEY("VisaStatusID"),
	FOREIGN KEY("Student_ID") REFERENCES "Employee"("Student_ID")
);

CREATE TABLE "WorkingHoursOffers" (
	"Offer_ID"	INTEGER,
	"Student_ID"	INTEGER,
	"Hours_Offered"	REAL,
	"Status"	INTEGER,	-- Sqlite does not contain native boolean support, treat the int as a 1,0 bool
	"Offer_Date"	TEXT,
	PRIMARY KEY("Offer_ID"),
	FOREIGN KEY("Student_ID") REFERENCES "Employee"("Student_ID")
);

CREATE TABLE "Timesheets" (
	"Timesheet_ID"	INTEGER,
	"Student_ID"	INTEGER,
	"Recruitment_ID"	INTEGER,
	"Hours_Worked"	REAL,
	"Status"	INTEGER,	-- Sqlite does not contain native boolean support, treat the int as a 1,0 bool
	"Date_Uploaded"	TEXT,
	"Date_Reviewed"	TEXT,
	PRIMARY KEY("Timesheet_ID"),
	FOREIGN KEY("Recruitment_ID") REFERENCES "Recruiter"("Recruitment_ID"),
	FOREIGN KEY("Student_ID") REFERENCES "Employee"("Student_ID")
);