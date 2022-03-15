drop table UserAccount CASCADE CONSTRAINTS;
drop table DeviceModel CASCADE CONSTRAINTS;
drop table PartType CASCADE CONSTRAINTS;
drop table Staff CASCADE CONSTRAINTS;
drop table Customer CASCADE CONSTRAINTS;
drop table RepairJob CASCADE CONSTRAINTS;
drop table Part CASCADE CONSTRAINTS;
drop table RepairMessage CASCADE CONSTRAINTS;
drop table RepairTask CASCADE CONSTRAINTS;
drop table CompatibleWith CASCADE CONSTRAINTS;
drop sequence Repair_seq;

create sequence Repair_seq
minvalue 1
start with 1
increment by 1;

CREATE TABLE UserAccount (
 LoginName VARCHAR(32) PRIMARY KEY,
 Password VARCHAR(32) NOT NULL,
 FName VARCHAR(32) NOT NULL,
 LName VARCHAR(32) NOT NULL,
 Phone VARCHAR(16) NOT NULL,
 EmailAddress VARCHAR(64) NOT NULL,
 StreetAddress VARCHAR(64) NOT NULL,
 City VARCHAR(32) NOT NULL,
 PostCode DECIMAL(4) NOT NULL,
 DateOfBirth DATE NOT NULL
);

CREATE TABLE DeviceModel (
 ModelNumber VARCHAR(32) PRIMARY KEY,
 Brand VARCHAR(16) NOT NULL
);

CREATE TABLE PartType (
 TypeName VARCHAR(32) PRIMARY KEY
);

CREATE TABLE Staff (
 LoginName VARCHAR(32) PRIMARY KEY,
 HourlySalary DECIMAL NOT NULL,
 EmploymentDate DATE NOT NULL,
 FOREIGN KEY (LoginName) REFERENCES UserAccount(LoginName)
);

CREATE TABLE Customer (
 LoginName VARCHAR(32) PRIMARY KEY,
 JoinDate DATE NOT NULL,
 FOREIGN KEY (LoginName) REFERENCES UserAccount(LoginName)
);

CREATE TABLE RepairJob (
 RepairID DECIMAL PRIMARY KEY,
 RepairDate DATE,
 CustomerLogin VARCHAR(32) NOT NULL,
 StaffLogin VARCHAR(32) NOT NULL,
 ModelNumber VARCHAR(32) NOT NULL,
 FOREIGN KEY (CustomerLogin) REFERENCES UserAccount(LoginName),
 FOREIGN KEY (StaffLogin) REFERENCES UserAccount(LoginName),
 FOREIGN KEY (ModelNumber) REFERENCES DeviceModel(ModelNumber)
);

CREATE TABLE RepairTask (
 TaskID DECIMAL NOT NULL,
 RepairID DECIMAL NOT NULL,
 Content VARCHAR(512) NOT NULL,
 constraint PK_RT primary key (TaskID, RepairID),
 FOREIGN KEY (RepairID) REFERENCES RepairJob(RepairID)
);

CREATE TABLE Part (
 SerialNumber VARCHAR(32) PRIMARY KEY,
 PartNumber VARCHAR(32) NOT NULL,
 TaskID DECIMAL,
 RepairID DECIMAL,
 TypeName VARCHAR(32) NOT NULL,
 FOREIGN KEY (TaskID, RepairID) REFERENCES RepairTask(TaskID, RepairID),
 FOREIGN KEY (TypeName) REFERENCES PartType(TypeName)
);

CREATE TABLE RepairMessage (
 MeassageID VARCHAR(32) NOT NULL,
 RepairID DECIMAL NOT NULL,
 MContent VARCHAR(512) NOT NULL,
 MessageDate DATE NOT NULL,
 SenderLogin VARCHAR(32) NOT NULL,
 constraint PK_RM primary key (MeassageID, RepairID),
 FOREIGN KEY (RepairID) REFERENCES RepairJob(RepairID),
 FOREIGN KEY (SenderLogin) REFERENCES UserAccount(LoginName)
);


CREATE TABLE CompatibleWith (
 SerialNumber VARCHAR(32) NOT NULL,
 ModelNumber VARCHAR(32) NOT NULL,
 constraint PK_CW primary key (SerialNumber, ModelNumber),
 FOREIGN KEY (SerialNumber) REFERENCES Part(SerialNumber),
 FOREIGN KEY (ModelNumber) REFERENCES DeviceModel(ModelNumber)
);

INSERT INTO UserAccount VALUES ('BlueMustangBLL0', 'QFH73513SG1', 'Chi', 'Sherman', '(99)5525403', 'BlueMustangBLL0@slingshot.co.nz', '67 Vicarage Gardens', 'Cincinnati', 0687, to_date('1967/7/27', 'yyyy/mm/dd'));
INSERT INTO UserAccount VALUES ('BlueMustangBLL1', 'QFH73513GR2', 'Jeanelle', 'Melendez', '(31)2466940', 'BlueMustangBLL1@yahoo.com', '110 School Street', 'Jersey City', 5487, to_date('1959/5/7', 'yyyy/mm/dd'));
INSERT INTO UserAccount VALUES ('BlueMustangBLL2', 'QFH73513GD3', 'Maida', 'Larson', '(01)2464205', 'BlueMustangBLL2@hotmail.com', '23 Ferry Lane', 'Scottsdale', 3412, to_date('1959/8/4', 'yyyy/mm/dd'));
INSERT INTO UserAccount VALUES ('BlueMustangBLL3', 'QFH735139FH', 'Deann', 'Salazar', '(06)5386957', 'BlueMustangBLL3@slingshot.co.nz', '65 Heron Close', 'Huntington', 1456, to_date('1990/10/26', 'yyyy/mm/dd'));
INSERT INTO UserAccount VALUES ('BlueMustangBLL4', 'QFH7351FK8D', 'Verda', 'Barker', '(48)1944643', 'BlueMustangBLL4@gmail.com', '74 Heather Close', 'Fresno', 2347, to_date('1994/12/29', 'yyyy/mm/dd'));
INSERT INTO UserAccount VALUES ('BlueMustangBLL5', 'QFH73513IQS', 'Glory', 'Wilcox', '(47)7164223', 'BlueMustangBLL5@yahoo.com', '56 Jackson Street', 'Cincinnati', 0687, to_date('1965/9/11', 'yyyy/mm/dd'));
INSERT INTO UserAccount VALUES ('BlueMustangBLL6', 'QFH735134HV', 'Rosaria', 'Green', '(24)7426905', 'BlueMustangBLL6@gmail.com', '104 Tudor Road', 'Omaha', 3584, to_date('1966/4/18', 'yyyy/mm/dd'));
INSERT INTO UserAccount VALUES ('BlueMustangBLL7', 'QFH7351EG5J', 'Carina', 'Mcdaniel', '(06)5424203', 'BlueMustangBLL7@slingshot.co.nz', '34 Lyndhurst Road', 'Memphis', 4583, to_date('1978/8/21', 'yyyy/mm/dd'));
INSERT INTO UserAccount VALUES ('BlueMustangBLL8', 'QFH73512CSS', 'Willena', 'Houston', '(53)8324246', 'BlueMustangBLL8@slingshot.co.nz', '45 Byron Street', 'Indianapolis', 6574, to_date('1988/7/2', 'yyyy/mm/dd'));
INSERT INTO UserAccount VALUES ('BlueMustangBLL9', 'QFH73512DSQ', 'Beula', 'Owens', '(48)0639482', 'BlueMustangBLL9@icloud.com', '101 Jackson Street', 'Fresno', 2347, to_date('1978/9/29', 'yyyy/mm/dd'));
INSERT INTO UserAccount VALUES ('BlueMustangBLL10', 'QFH73512ASW', 'Jude', 'Barajas', '(01)2699438', 'BlueMustangBLL10@icloud.com', '6 Railway Terrace', 'Indianapolis', 6574, to_date('1998/4/1', 'yyyy/mm/dd'));
INSERT INTO UserAccount VALUES ('BlueMustangBLL11', 'QFH7351EDFE', 'Piedad', 'Rasmussen', '(03)7429443', 'BlueMustangBLL11@hotmail.com', '111 Railway Terrace', 'Fresno', 2347, to_date('1956/6/28', 'yyyy/mm/dd'));
INSERT INTO UserAccount VALUES ('BlueMustangBLL12', 'QFH7351SDFF', 'Mac', 'Herrera', '(03)2463843', 'BlueMustangBLL12@slingshot.co.nz', '115 Queensway', 'Scottsdale', 3412, to_date('1973/7/8', 'yyyy/mm/dd'));
INSERT INTO UserAccount VALUES ('BlueMustangBLL13', 'QFH7351F4FF', 'Bernardina', 'Larson', '(24)1941653', 'BlueMustangBLL13@gmail.com', '74 Ferry Lane', 'Indianapolis', 6574, to_date('1994/6/2', 'yyyy/mm/dd'));
INSERT INTO UserAccount VALUES ('BlueMustangBLL14', 'QFH73514D5E', 'Willena', 'Morrison', '(53)7425423', 'BlueMustangBLL14@hotmail.com', '105 Rosemary Lane', 'Columbus', 3486, to_date('1986/5/4', 'yyyy/mm/dd'));
INSERT INTO UserAccount VALUES ('BlueMustangBLL15', 'QFH73514R9V', 'Jeanelle', 'Mcdowell', '(73)7166386', 'BlueMustangBLL15@hotmail.com', '109 Park Place', 'Henderson', 1237, to_date('1958/12/22', 'yyyy/mm/dd'));
INSERT INTO UserAccount VALUES ('BlueMustangBLL16', 'QFH7351FGHC', 'Leida', 'Sherman', '(53)0636943', 'BlueMustangBLL16@slingshot.co.nz', '92 Arthur Street', 'Laredo', 9492, to_date('1987/9/26', 'yyyy/mm/dd'));
INSERT INTO UserAccount VALUES ('BlueMustangBLL17', 'QFH73514RDD', 'Rosaria', 'Franco', '(31)7423840', 'BlueMustangBLL17@hotmail.com', '72 Pear Tree Close', 'Milwaukee', 0693, to_date('1980/12/1', 'yyyy/mm/dd'));
INSERT INTO UserAccount VALUES ('BlueMustangBLL18', 'QFH735148WS', 'Hildred', 'Larson', '(31)2464603', 'BlueMustangBLL18@hotmail.com', '6 Cavendish Road', 'Greensboro', 9034, to_date('1998/9/28', 'yyyy/mm/dd'));
INSERT INTO UserAccount VALUES ('BlueMustangBLL19', 'QFH73514QGF', 'Moriah', 'Mcdowell', '(99)6536346', 'BlueMustangBLL19@gmail.com', '95 Cavendish Road', 'Milwaukee', 0693, to_date('1951/1/1', 'yyyy/mm/dd'));
INSERT INTO Staff VALUES ('BlueMustangBLL0', '29', to_date('1998/2/15', 'yyyy/mm/dd'));
INSERT INTO Staff VALUES ('BlueMustangBLL10', '26', to_date('2000/7/7', 'yyyy/mm/dd'));
INSERT INTO Customer VALUES ('BlueMustangBLL1', to_date('2016/1/10', 'yyyy/mm/dd'));
INSERT INTO Customer VALUES ('BlueMustangBLL2', to_date('2015/4/15', 'yyyy/mm/dd'));
INSERT INTO Customer VALUES ('BlueMustangBLL3', to_date('2017/8/22', 'yyyy/mm/dd'));
INSERT INTO Customer VALUES ('BlueMustangBLL4', to_date('2016/11/29', 'yyyy/mm/dd'));
INSERT INTO Customer VALUES ('BlueMustangBLL5', to_date('2016/7/29', 'yyyy/mm/dd'));
INSERT INTO Customer VALUES ('BlueMustangBLL6', to_date('2014/6/19', 'yyyy/mm/dd'));
INSERT INTO Customer VALUES ('BlueMustangBLL7', to_date('2017/7/9', 'yyyy/mm/dd'));
INSERT INTO Customer VALUES ('BlueMustangBLL8', to_date('2016/3/22', 'yyyy/mm/dd'));
INSERT INTO Customer VALUES ('BlueMustangBLL9', to_date('2015/1/28', 'yyyy/mm/dd'));
INSERT INTO Customer VALUES ('BlueMustangBLL11', to_date('2017/4/29', 'yyyy/mm/dd'));
INSERT INTO Customer VALUES ('BlueMustangBLL12', to_date('2016/12/29', 'yyyy/mm/dd'));
INSERT INTO Customer VALUES ('BlueMustangBLL13', to_date('2016/3/10', 'yyyy/mm/dd'));
INSERT INTO Customer VALUES ('BlueMustangBLL14', to_date('2015/11/28', 'yyyy/mm/dd'));
INSERT INTO Customer VALUES ('BlueMustangBLL15', to_date('2015/11/3', 'yyyy/mm/dd'));
INSERT INTO Customer VALUES ('BlueMustangBLL16', to_date('2015/6/23', 'yyyy/mm/dd'));
INSERT INTO Customer VALUES ('BlueMustangBLL17', to_date('2014/3/17', 'yyyy/mm/dd'));
INSERT INTO Customer VALUES ('BlueMustangBLL18', to_date('2017/7/20', 'yyyy/mm/dd'));
INSERT INTO Customer VALUES ('BlueMustangBLL19', to_date('2016/12/20', 'yyyy/mm/dd'));
INSERT INTO DeviceModel VALUES ('Q-GX17AF', 'SAMSUNG');
INSERT INTO DeviceModel VALUES ('Q-GX17AX', 'APPLE');
INSERT INTO DeviceModel VALUES ('Q-GX17AG', 'APPLE');
INSERT INTO DeviceModel VALUES ('Q-GX17AT', 'MSI');
INSERT INTO DeviceModel VALUES ('Q-GX17AN', 'APPLE');
INSERT INTO DeviceModel VALUES ('Q-GX17AQ', 'APPLE');
INSERT INTO DeviceModel VALUES ('Q-GX17AD', 'ASUS');
INSERT INTO DeviceModel VALUES ('Q-GX17BF', 'RAZOR');
INSERT INTO DeviceModel VALUES ('Q-GX17BX', 'ACER');
INSERT INTO DeviceModel VALUES ('Q-GX17BG', 'MSI');
INSERT INTO DeviceModel VALUES ('Q-GX17BT', 'APPLE');
INSERT INTO DeviceModel VALUES ('Q-GX17BN', 'ASUS');
INSERT INTO DeviceModel VALUES ('Q-GX17BQ', 'MSI');
INSERT INTO DeviceModel VALUES ('Q-GX17BD', 'MSI');
INSERT INTO DeviceModel VALUES ('Q-GX17CF', 'SAMSUNG');
INSERT INTO DeviceModel VALUES ('Q-GX17CX', 'RAZOR');
INSERT INTO DeviceModel VALUES ('Q-GX17CG', 'SAMSUNG');
INSERT INTO DeviceModel VALUES ('Q-GX17CT', 'APPLE');
INSERT INTO DeviceModel VALUES ('Q-GX17CN', 'APPLE');
INSERT INTO DeviceModel VALUES ('Q-GX17CQ', 'SAMSUNG');
INSERT INTO RepairJob VALUES (Repair_seq.NEXTVAL, to_date('2016/1/10', 'yyyy/mm/dd'), 'BlueMustangBLL16', 'BlueMustangBLL0', 'Q-GX17AF');
INSERT INTO RepairJob VALUES (Repair_seq.NEXTVAL, to_date('2015/4/15', 'yyyy/mm/dd'), 'BlueMustangBLL12', 'BlueMustangBLL0', 'Q-GX17AX');
INSERT INTO RepairJob VALUES (Repair_seq.NEXTVAL, to_date('2017/8/22', 'yyyy/mm/dd'), 'BlueMustangBLL15', 'BlueMustangBLL0', 'Q-GX17AG');
INSERT INTO RepairJob VALUES (Repair_seq.NEXTVAL, to_date('2016/11/29', 'yyyy/mm/dd'), 'BlueMustangBLL17', 'BlueMustangBLL10', 'Q-GX17AT');
INSERT INTO RepairJob VALUES (Repair_seq.NEXTVAL, to_date('2016/7/29', 'yyyy/mm/dd'), 'BlueMustangBLL15', 'BlueMustangBLL0', 'Q-GX17AN');
INSERT INTO RepairJob VALUES (Repair_seq.NEXTVAL, to_date('2014/6/19', 'yyyy/mm/dd'), 'BlueMustangBLL12', 'BlueMustangBLL0', 'Q-GX17AQ');
INSERT INTO RepairJob VALUES (Repair_seq.NEXTVAL, to_date('2017/7/9', 'yyyy/mm/dd'), 'BlueMustangBLL1', 'BlueMustangBLL0', 'Q-GX17AD');
INSERT INTO RepairJob VALUES (Repair_seq.NEXTVAL, to_date('2016/3/22', 'yyyy/mm/dd'), 'BlueMustangBLL6', 'BlueMustangBLL10', 'Q-GX17BF');
INSERT INTO RepairJob VALUES (Repair_seq.NEXTVAL, to_date('2015/1/28', 'yyyy/mm/dd'), 'BlueMustangBLL8', 'BlueMustangBLL10', 'Q-GX17BX');
INSERT INTO RepairJob VALUES (Repair_seq.NEXTVAL, to_date('2017/4/29', 'yyyy/mm/dd'), 'BlueMustangBLL11', 'BlueMustangBLL0', 'Q-GX17BG');
INSERT INTO RepairJob VALUES (Repair_seq.NEXTVAL, to_date('2016/12/29', 'yyyy/mm/dd'), 'BlueMustangBLL6', 'BlueMustangBLL0', 'Q-GX17BT');
INSERT INTO RepairJob VALUES (Repair_seq.NEXTVAL, to_date('2016/3/10', 'yyyy/mm/dd'), 'BlueMustangBLL13', 'BlueMustangBLL10', 'Q-GX17BN');
INSERT INTO RepairJob VALUES (Repair_seq.NEXTVAL, to_date('2015/11/28', 'yyyy/mm/dd'), 'BlueMustangBLL17', 'BlueMustangBLL0', 'Q-GX17BQ');
INSERT INTO RepairJob VALUES (Repair_seq.NEXTVAL, to_date('2015/11/3', 'yyyy/mm/dd'), 'BlueMustangBLL4', 'BlueMustangBLL10', 'Q-GX17BD');
INSERT INTO RepairJob VALUES (Repair_seq.NEXTVAL, to_date('2015/6/23', 'yyyy/mm/dd'), 'BlueMustangBLL17', 'BlueMustangBLL0', 'Q-GX17CF');
INSERT INTO RepairJob VALUES (Repair_seq.NEXTVAL, to_date('2014/3/17', 'yyyy/mm/dd'), 'BlueMustangBLL14', 'BlueMustangBLL10', 'Q-GX17CX');
INSERT INTO RepairJob VALUES (Repair_seq.NEXTVAL, to_date('2017/7/20', 'yyyy/mm/dd'), 'BlueMustangBLL13', 'BlueMustangBLL10', 'Q-GX17CG');
INSERT INTO RepairJob VALUES (Repair_seq.NEXTVAL, to_date('2016/12/20', 'yyyy/mm/dd'), 'BlueMustangBLL1', 'BlueMustangBLL0', 'Q-GX17CT');
INSERT INTO RepairJob VALUES (Repair_seq.NEXTVAL, to_date('2015/11/22', 'yyyy/mm/dd'), 'BlueMustangBLL9', 'BlueMustangBLL0', 'Q-GX17CN');
INSERT INTO RepairJob VALUES (Repair_seq.NEXTVAL, to_date('2017/3/22', 'yyyy/mm/dd'), 'BlueMustangBLL14', 'BlueMustangBLL0', 'Q-GX17CQ');

SELECT * FROM UserAccount;
SELECT * FROM DeviceModel;
SELECT * FROM PartType;
SELECT * FROM Staff;
SELECT * FROM Customer;
SELECT * FROM RepairJob;
SELECT * FROM Part;
SELECT * FROM RepairMessage;
SELECT * FROM RepairTask;
SELECT * FROM CompatibleWith;

commit;