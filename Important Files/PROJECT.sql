CREATE DATABASE FinalProject

USE FinalProject


CREATE TABLE Consignors (
	consignor_id int PRIMARY KEY NOT NULL,
	name varchar(50) NOT NULL,
	address varchar(100) NOT NULL,
	phone_number char(11) NOT NULL,
	email_address varchar(50) NOT NULL
)

CREATE TABLE Customer (
	customer_id int PRIMARY KEY NOT NULL,
	name varchar(50) NOT NULL,
	address varchar(100) NOT NULL,
	phone_number char(11) NOT NULL,
	email_address varchar(50) NOT NULL
)

CREATE TABLE Item (
	item_id int PRIMARY KEY NOT NULL,
	consigner_id int FOREIGN KEY REFERENCES Consignors(consignor_id),
	item_name varchar(50) NOT NULL,
	item_size varchar(6) NOT NULL,
	item_price DECIMAL(10,2) NOT NULL,
	qty varchar(3) NOT NULL,
)

CREATE TABLE Position (
	position_id int PRIMARY KEY NOT NULL,
	position_title varchar(20) NOT NULL,
	salary DECIMAL(10,2) NOT NULL
)

CREATE TABLE Employee (
	employee_id int PRIMARY KEY NOT NULL,
	employee_name varchar(50) NOT NULL,
	employee_address varchar(100) NOT NULL,
	employee_phone_number char(11) NOT NULL,
	date_hired date NOT NULL,
	position_id int FOREIGN KEY REFERENCES Position (position_id)
)
	
CREATE TABLE PaymentMethod (
	payment_no int PRIMARY KEY NOT NULL,
	payment_type varchar(20) NOT NULL
)

CREATE TABLE Sales (
	sales_id int PRIMARY KEY NOT NULL,
	item_id int FOREIGN KEY REFERENCES Item (item_id),
	item_name varchar(50) NOT NULL,
	item_size varchar(6) NOT NULL,
	customer_id int FOREIGN KEY REFERENCES Customer (customer_id),
	employee_id int FOREIGN KEY REFERENCES Employee (employee_id),
	payment_no int FOREIGN KEY REFERENCES PaymentMethod (payment_no),
	sales_date date,
	total_amount int NOT NULL
)
