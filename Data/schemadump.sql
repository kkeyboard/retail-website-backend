/*
SQL Server
*/
CREATE DATABASE DatabaseFirstDB;
USE DatabaseFirstDB;
CREATE TABLE Customer2(
    CustomerId INT PRIMARY KEY IDENTITY(1,1).
    CustomerName VARCHAR NOT NULL,
    CustomerAmount FLOAT
);
ALTER TABLE Customer
ADD City VARCHAR(50);

ALTER TABLE Customer
ALTER COLUMN CustomerName VARCHAR(50);

/*
Postgresql
*/
CREATE DATABASE customerdb2;
\c customerdb2;
CREATE TABLE Customer2(
    CustomerId INT PRIMARY KEY GENERATED ALWAYS AS IDENTITY,
    CustomerName VARCHAR(255) NOT NULL,
    CustomerAmount FLOAT
)

ALTER TABLE Customer2
ADD City VARCHAR(50);

ALTER TABLE Customer2
ALTER COLUMN CustomerName TYPE VARCHAR(50);