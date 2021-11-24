CREATE TABLE data_staff(
nik INT PRIMARY KEY,
nama VARCHAR(50) NULL,
alamat VARCHAR(200) NULL,
handphone VARCHAR(15) NULL
)

INSERT INTO data_staff (nik, nama, alamat, handphone) VALUES(001, 'Pohan', 'Surabaya', '14045');

SELECT * FROM data_staff;

INSERT INTO data_staff (nik, nama, alamat, handphone) VALUES(002, 'Tantra', 'Sidoarjo', '007009');
INSERT INTO data_staff (nik, nama, alamat, handphone) VALUES(003, 'Rahmanda', 'Malang', '150802');

ALTER TABLE data_staff ADD joindate DATE NULL;
INSERT INTO data_staff (nik, nama, alamat, handphone, joindate) VALUES(004, 'Junior', 'Bandung', '08785555', '2021-11-24');

SELECT TOP 2 * FROM data_staff;

SELECT TOP 3 * FROM data_staff;

CREATE TABLE staffoutsource(
nik INT PRIMARY KEY,
nama VARCHAR(50) NULL,
alamat VARCHAR(200) NULL,
handphone VARCHAR(15) NULL
)
ALTER TABLE staffoutsource ADD joindate DATE NULL;

INSERT INTO staffoutsource (nik, nama, alamat, handphone, joindate) VALUES(001, 'Namira', 'Bandung', '1232131', '2021-11-24');
INSERT INTO staffoutsource (nik, nama, alamat, handphone, joindate) VALUES(002, 'Cyndya', 'Surabaya', '234234234', '2021-11-22');
INSERT INTO staffoutsource (nik, nama, alamat, handphone, joindate) VALUES(003, 'Erica', 'Malang', '324234324', '2021-11-24');
INSERT INTO staffoutsource (nik, nama, alamat, handphone, joindate) VALUES(004, 'Jinjin', 'Batu', '34534534', '2021-11-20');
INSERT INTO staffoutsource (nik, nama, alamat, handphone) VALUES(005, 'Fariska', 'Jombang', '14565454');
INSERT INTO staffoutsource (nik, nama, alamat, handphone, joindate) VALUES(006, 'Anam', 'Pasuruan', '3242342', '2021-11-25');
INSERT INTO staffoutsource (nik, nama, alamat, handphone) VALUES(007, 'Oding', 'Surabaya', '1232445');
INSERT INTO staffoutsource (nik, nama, alamat, handphone, joindate) VALUES(008, 'Angga', 'Malang', '12454546', '2021-11-20');
INSERT INTO staffoutsource (nik, nama, alamat, handphone) VALUES(009, 'Triko', 'Nganjuk', '1234567777');
INSERT INTO staffoutsource (nik, nama, alamat, handphone, joindate) VALUES(010, 'Daus', 'Bandung', '1232445533', '2021-11-24');

SELECT * FROM staffoutsource;

SELECT dt.*, so.* FROM data_staff dt JOIN staffoutsource so ON dt.joindate = so.joindate;

SELECT * FROM data_staff dt  RIGHT JOIN staffoutsource so ON dt.joindate = so.joindate;

SELECT * FROM data_staff dt  LEFT JOIN staffoutsource so ON dt.joindate = so.joindate;

SELECT * FROM data_staff UNION SELECT * FROM staffoutsource;



