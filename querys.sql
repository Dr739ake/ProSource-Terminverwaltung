create table Kontakte (
    id primary key,
    anrede varchar(255),
    name varchar(255),
    vorname varchar(255),
    strasse varchar(255),
    ort varchar(255),
    plz varchar(255),
    tel varchar(255),
    mobil varchar(255),
    firma varchar(255),
    abteilung varchar(255),
    b2b boolean
);

+-----------+--------------+------+-----+---------+-------+
| Field     | Type         | Null | Key | Default | Extra |
+-----------+--------------+------+-----+---------+-------+
| id        | int(6)       | NO   | PRI | NULL    |       |
| anrede    | varchar(255) | YES  |     | NULL    |       |
| name      | varchar(255) | YES  |     | NULL    |       |
| vorname   | varchar(255) | YES  |     | NULL    |       |
| strasse   | varchar(255) | YES  |     | NULL    |       |
| ort       | varchar(255) | YES  |     | NULL    |       |
| plz       | varchar(255) | YES  |     | NULL    |       |
| tel       | varchar(255) | YES  |     | NULL    |       |
| mobil     | varchar(255) | YES  |     | NULL    |       |
| firma     | varchar(255) | YES  |     | NULL    |       |
| abteilung | varchar(255) | YES  |     | NULL    |       |
| b2b       | tinyint(1)   | YES  |     | NULL    |       |
+-----------+--------------+------+-----+---------+-------+