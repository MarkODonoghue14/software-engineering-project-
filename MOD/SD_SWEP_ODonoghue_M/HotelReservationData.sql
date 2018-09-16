INSERT INTO ROOMRATE
VALUES('DBL','SUITABLE FOR TWO', 70);
INSERT INTO ROOMRATE
VALUES('SGL','SUITABLE FOR ONE', 55);
INSERT INTO ROOMRATE
VALUES('FML','SUITABLE FOR A FAMILY', 90);
INSERT INTO ROOMRATE
VALUES('DLX','TOP OF THE RANGE ROOM', 140);

INSERT INTO ROOMS
VALUES(101,'DBL','A');
INSERT INTO ROOMS
VALUES(102,'DBL','A');
INSERT INTO ROOMS
VALUES(103,'SGL','A');
INSERT INTO ROOMS
VALUES(104,'SGL','A');
INSERT INTO ROOMS
VALUES(105,'FML','A');
INSERT INTO ROOMS
VALUES(106,'FML','A');
INSERT INTO ROOMS
VALUES(107,'DLX','A');
INSERT INTO ROOMS
VALUES(108,'DLX','A');

INSERT INTO RESERVATIONS
VALUES(1,101,'MARK O DONOGHUE','mmmgmail.com',Date'2017-01-01',Date'2017-01-02',70,'C','C','P');
INSERT INTO RESERVATIONS
VALUES(2,103,'MARK O DONOGHUE','mmmgmail.com',Date'2017-01-01',Date'2017-01-03',110,'C','C','P');
INSERT INTO RESERVATIONS
VALUES(3,107,'MARK O DONOGHUE','mmmgmail.com',Date'2017-01-01',Date'2017-01-03',280,'C','C','P');
INSERT INTO RESERVATIONS
VALUES(4,101,'MARK O DONOGHUE','mmmgmail.com',Date'2017-02-01',Date'2017-02-02',70,'C','C','P');
INSERT INTO RESERVATIONS
VALUES(5,101,'MARK O DONOGHUE','mmmgmail.com',Date'2017-02-01',Date'2017-02-03',140,'C','C','P');
INSERT INTO RESERVATIONS
VALUES(6,105,'MARK O DONOGHUE','mmmgmail.com',Date'2017-02-01',Date'2017-02-03',180,'C','C','P');
INSERT INTO RESERVATIONS
VALUES(7,101,'MARK O DONOGHUE','mmmgmail.com',Date'2017-03-01',Date'2017-03-02',70,'C','C','P');
INSERT INTO RESERVATIONS
VALUES(8,101,'MARK O DONOGHUE','mmmgmail.com',Date'2017-03-01',Date'2017-03-02',70,'C','C','P');
INSERT INTO RESERVATIONS
VALUES(9,105,'MARK O DONOGHUE','mmmgmail.com',Date'2017-03-01',Date'2017-03-02',90,'C','C','P');
INSERT INTO RESERVATIONS
VALUES(10,101,'MARK O DONOGHUE','mmmgmail.com',Date'2017-04-01',Date'2017-04-02',70,'C','C','P');
INSERT INTO RESERVATIONS
VALUES(11,103,'MARK O DONOGHUE','mmmgmail.com',Date'2017-04-01',Date'2017-04-03',110,'C','C','P');
INSERT INTO RESERVATIONS
VALUES(12,102,'MARK O DONOGHUE','mmmgmail.com',Date'2017-04-01',Date'2017-04-02',70,'C','C','P');
INSERT INTO RESERVATIONS
VALUES(13,101,'MARK O DONOGHUE','mmmgmail.com',Date'2017-05-01',Date'2017-05-02',70,'C','C','P');
INSERT INTO RESERVATIONS
VALUES(14,103,'MARK O DONOGHUE','mmmgmail.com',Date'2017-05-01',Date'2017-05-04',165,'C','C','P');
INSERT INTO RESERVATIONS
VALUES(15,107,'MARK O DONOGHUE','mmmgmail.com',Date'2017-05-01',Date'2017-05-03',280,'C','C','P');
INSERT INTO RESERVATIONS
VALUES(16,101,'MARK O DONOGHUE','mmmgmail.com',Date'2017-06-01',Date'2017-06-03',140,'C','C','P');
INSERT INTO RESERVATIONS
VALUES(17,103,'MARK O DONOGHUE','mmmgmail.com',Date'2017-06-01',Date'2017-06-03',110,'C','C','P');
INSERT INTO RESERVATIONS
VALUES(18,107,'MARK O DONOGHUE','mmmgmail.com',Date'2017-06-01',Date'2017-06-04',420,'C','C','P');
INSERT INTO RESERVATIONS
VALUES(19,101,'MARK O DONOGHUE','mmmgmail.com',Date'2017-07-01',Date'2017-07-03',140,'C','C','P');
INSERT INTO RESERVATIONS
VALUES(20,102,'MARK O DONOGHUE','mmmgmail.com',Date'2017-07-01',Date'2017-07-02',70,'C','C','P');
INSERT INTO RESERVATIONS
VALUES(21,107,'MARK O DONOGHUE','mmmgmail.com',Date'2017-07-01',Date'2017-07-04',420,'C','C','P');
INSERT INTO RESERVATIONS
VALUES(22,101,'MARK O DONOGHUE','mmmgmail.com',Date'2017-08-01',Date'2017-08-02',70,'C','C','P');
INSERT INTO RESERVATIONS
VALUES(23,102,'MARK O DONOGHUE','mmmgmail.com',Date'2017-08-01',Date'2017-08-04',210,'C','C','P');
INSERT INTO RESERVATIONS
VALUES(24,107,'MARK O DONOGHUE','mmmgmail.com',Date'2017-08-01',Date'2017-08-04',420,'C','C','P');

COMMIT;