CREATE TABLE Branch (
branchNo TEXT PRIMARY KEY NOT NULL,
street TEXT,
city TEXT,
postcode TEXT
);

INSERT INTO Branch (branchNo, street, city, postcode) VALUES
('B005', '22 Deer Rd', 'London', 'SW1 4EH'),
('B007', '16 Argyle St', 'Aberdeen', 'AB2 35U'),
('B003', '163 Main St', 'Glasgow', 'G11 9QQ'),
('B004', '32 Manse Rd', 'Bristol', 'BS99 1NZ'),
('B002', '56 Clover Dr', 'London', 'NW10 6EU');

SELECT * FROM Branch;
DROP TABLE Branch;

CREATE TABLE Staff (
staffNo TEXT PRIMARY KEY NOT NULL,
fName TEXT,
lName TEXT,
position TEXT,
sex TEXT,
DOB TEXT,
salary INTEGER,
branchNo TEXT,
FOREIGN KEY (branchNo) REFERENCES Branch(branchNo)
);

INSERT INTO Staff (staffNo, fName, lName, position, sex, DOB, salary, branchNo) VALUES
('SL21', 'John', 'White', 'Manager', 'M', '1-Oct-45', 30000, 'B005'),
('SG37', 'Ann', 'Beech', 'Assistant', 'F', '24-Mar-58', 12000, 'B003'),
('SG14', 'David', 'Ford', 'Supervisor', 'M', '24-Mar-58', 18000, 'B007'),
('SA9', 'Mary', 'Howe', 'Assistant', 'F', '19-Feb-70', 9000, 'B007'),
('SG5', 'Susan', 'Brand', 'Manager', 'F', '3-Jun-40', 24000, 'B003'),
('SL41', 'Julie', 'Lee', 'Assistant', 'F', '13-Jun-65', 9000, 'B005');

SELECT * FROM Staff;
DROP TABLE Staff;


CREATE TABLE PropertyForRent (
propertyNo TEXT PRIMARY KEY NOT NULL,
street TEXT,
city TEXT,
postcode TEXT,
type TEXT,
rooms INTEGER,
rent INTEGER,
ownerNo TEXT,
staffNo TEXT,
branchNo TEXT,
FOREIGN KEY (ownerNo) REFERENCES PrivateOwner(ownerNo),
FOREIGN KEY (staffNo) REFERENCES Staff(staffNo),
FOREIGN KEY (branchNo) REFERENCES Branch(branchNo)
);

INSERT INTO PropertyForRent (propertyNo, street, city, postcode, type, rooms, rent, ownerNo, staffNo, branchNo) VALUES
('PA14', '16 Holhead', 'Aberdeen', 'AB7 55U', 'House', 6, 650, 'CO46', 'SA9', 'B007'),
('PL94', '6 Argyle St', 'London', 'NW2', 'Flat', 4, 400, 'CO87', 'SL41', 'B005'),
('PG4', '6 Lawrence St', 'Glasgow', 'G11 9QQ', 'Flat', 3, 350, 'CO40', 'SG14', 'B003'),
('PG36', '2 Manor Rd', 'Glasgow', 'G32 4QX', 'Flat', 3, 375, 'CO93', 'SG37', 'B003'),
('PG21', '18 Dale Rd', 'Glasgow', 'G12', 'House', 5, 600, 'CO87', 'SG37', 'B003'),
('PG16', '5 Novar Dr', 'Glasgow', 'G12 9AX', 'Flat', 4, 450, 'CO93', 'SG14', 'B003');

SELECT * FROM PropertyForRent;
DROP TABLE PropertyForRent;

CREATE TABLE Client (
clientNo TEXT PRIMARY KEY NOT NULL,
fName TEXT,
lName TEXT,
telNo TEXT,
prefType TEXT,
maxRent INTEGER
);

INSERT INTO Client (clientNo, fName, lName, telNo, prefType, maxRent) VALUES
('CR76', 'John', 'Kay', '0207-774-5632', 'Flat', 425),
('CR56', 'Aline', 'Stewart', '0141-848-1825', 'Flat', 350),
('CR74', 'Mike', 'Ritchie', '01475-392178', 'House', 750),
('CR62', 'Mary', 'Tregear', '01224-196720', 'Flat', 600);

SELECT * FROM Client;
DROP TABLE Client;

CREATE TABLE PrivateOwner (
ownerNo TEXT PRIMARY KEY NOT NULL,
fName TEXT,
lName TEXT,
address TEXT,
telNo TEXT
);

INSERT INTO PrivateOwner (ownerNo, fName, lName, address, telNo) VALUES
('CO46', 'Joe', 'Keogh', '2 Fergus Dr, Aberdeen AB2 75X', '01224-861212'),
('CO87', 'Carol', 'Farrel', '6 Achray St, Glasgow G32 9DX', '0141-357-7419'),
('CO40', 'Tina', 'Murphy', '63 Well St, Glasgow G42', '0141-943-1728'),
('CO93', 'Tony', 'Shaw', '12 Park Pl, Glasgow G4 0QR', '0141-225-7025');

SELECT * FROM PrivateOwner;
DROP TABLE PrivateOwner;

CREATE TABLE Viewing (
clientNo TEXT,
propertyNo TEXT,
viewDate TEXT,
comment TEXT,
FOREIGN KEY (clientNo) REFERENCES Client(clientNo),
FOREIGN KEY (propertyNo) REFERENCES PropertyForRent(propertyNo)
);

INSERT INTO Viewing (clientNo, propertyNo, viewDate, comment) VALUES
('CR56', 'PA14', '24-May-04', 'too small'),
('CR76', 'PG4', '20-Apr-04', 'too remote'),
('CR56', 'PG4', '26-May-04', 'no dining room'),
('CR62', 'PA14', '14-May-04', 'too noisy'),
('CR56', 'PG36', '28-Apr-04', 'good location');

SELECT * FROM Viewing;
DROP TABLE Viewing;

CREATE TABLE Registration (
clientNo TEXT,
branchNo TEXT,
staffNo TEXT,
dateJoined TEXT,
FOREIGN KEY (clientNo) REFERENCES Client(clientNo),
FOREIGN KEY (branchNo) REFERENCES Branch(branchNo),
FOREIGN KEY (staffNo) REFERENCES Staff(staffNo)
);

INSERT INTO Registration (clientNo, branchNo, staffNo, dateJoined) VALUES
('CR76', 'B005', 'SL41', '2-Jan-04'),
('CR56', 'B003', 'SG37', '11-Apr-03'),
('CR74', 'B003', 'SG37', '16-Nov-02'),
('CR62', 'B007', 'SA9', '7-Mar-03');

SELECT * FROM Registration;
DROP TABLE Registration;
