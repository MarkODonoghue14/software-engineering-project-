
Drop Table Reservations;
DROP TABLE Rooms;
DROP TABLE Roomrate;

CREATE TABLE RoomRate(
Room_Type char(3) NOT NULL,
Description varchar2(30) NOT NULL,
Rate Decimal (5,2) NOT NULL,
CONSTRAINT pk_Room_Rate PRIMARY KEY (Room_Type));


CREATE TABLE Rooms(
Room_No Numeric(3) NOT NULL,
Room_Type char(3) NOT NULL,
Status char(1) NOT NULL,
CONSTRAINT pk_Room_No PRIMARY KEY (Room_No),
CONSTRAINT fk_Room_Type FOREIGN KEY(Room_type) REFERENCES RoomRate);

CREATE TABLE Reservations(
Res_ID NUMERIC(6) NOT NULL,
Room_No NUMERIC(3) NOT NULL,
Cust_Name CHAR(30) NOT NULL,
E_Mail VARCHAR(30) NOT NULL,
Date_Arrive DATE NOT NULL,
Date_Depart DATE NOT NULL,
Total_Cost DECIMAL (7,2) NOT NULL,
Check_In CHAR(1),
Check_Out CHAR(1),
Res_Status CHAR(1) NOT NULL,
CONSTRAINT pk_Res_ID PRIMARY KEY (Res_ID),
CONSTRAINT fk_Room_No FOREIGN KEY (Room_No) REFERENCES Rooms);





