CREATE DATABASE WorkAssistant;
USE WorkAssistant;

CREATE TABLE company
(
	id INT PRIMARY KEY AUTO_INCREMENT,
    name_company VARCHAR(50) NOT NULL,
    date_created DATE,
    adress_company VARCHAR(100) NOT NULL,
    owner_company VARCHAR(50) NOT NULL,
    CEO_company VARCHAR(50) NOT NULL
    
);

CREATE TABLE overtime
(
	id INT PRIMARY KEY AUTO_INCREMENT,
    user_id INT,
    FOREIGN KEY (user_id)
    REFERENCES users(id),
    short_description VARCHAR(256) NOT NULL,
    start_time VARCHAR(5) NOT NULL,
    end_time VARCHAR(5) NOT NULL,
    overtime_date VARCHAR(10) NOT NULL
);

SELECT*FROM company;
SELECT * FROM users;
SELECT * FROM user_tasks;

DROP DATABASE WorkAssistant;
DROP TABLE users;
DROP TABLE user_tasks;



CREATE TABLE users
(
	id INT PRIMARY KEY AUTO_INCREMENT,
    first_name VARCHAR(30) NOT NULL, 
    last_name VARCHAR(30) NOT NULL, 
    username VARCHAR(30) NOT NULL UNIQUE,
    email VARCHAR(80) NOT NULL, 
    password VARCHAR(200) NOT NULL, 
    phone_number_contact VARCHAR(50) NOT NULL,
    company_name VARCHAR(50) NOT NULL
    
);

CREATE TABLE user_tasks
(
	id INT PRIMARY KEY AUTO_INCREMENT,
    user_id INT,
    FOREIGN KEY (user_id)
    REFERENCES users(id),
    task_title VARCHAR(30) NOT NULL,
    task_description VARCHAR(256) NOT NULL,
    task_time VARCHAR(5) NOT NULL,
    task_date VARCHAR(10) NOT NULL,
    percentage INT NOT NULL
);

CREATE TABLE company_users
(
	company_id INT,
    FOREIGN KEY (company_id)
    REFERENCES company(id),
    user_id INT,
    FOREIGN KEY (user_id)
    REFERENCES users(id)
    
);

DROP TABLE users;


