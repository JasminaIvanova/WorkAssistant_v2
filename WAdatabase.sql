CREATE DATABASE WorkAssistant;
USE WorkAssistant;

CREATE TABLE company
(
	id INT PRIMARY KEY AUTO_INCREMENT,
    name_company VARCHAR(50) NOT NULL,
    date_created YEAR,
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
SELECT * FROM overtime;

DROP DATABASE WorkAssistant;
DROP TABLE users;
DROP TABLE user_tasks;
DROP TABLE company;



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
INSERT INTO company (name_company,date_created, adress_company,owner_company, CEO_company ) VALUES
    ('Fibank', '1993','Sofia, Bulgaria','Tseko Todorov Minev, Ivaylo Dimitrov Mutafchiev','Nedelcho Nedelchev'),
    ('DSK', '1951','Sofia, Bulgaria','OTP Bank','Violina Marinova'),
    ('PostBank', '1991 ','Sofia, Bulgaria','Eurobank Ergasias','Petya Dimitrova'),
	('A1', '1994','Sofia, Bulgaria','America Movil','Alexandar Dimitrov'),
    ('Telenor', '2001','Fornebu, Norge','Jason King','Sigve Brekke'), 
    ('Vivacom', '1992','Sofia, Bulgaria','United Group','Atanas Dobrev'),
    ('VMware', '1998','Palo Alto, California, USA','Dell Technologies','Zane C. Rowe'),
    ('SAP', '1972','Waldorf, Germany','Hasso Plattner','Kristen Klein'),
    ('TUES', '1988','Sofia, Bulgaria','Stela Stefanova','Stela Stefanova'),
    ('SoftUni', '2013','Sofia, Bulgaria','Svetlin Nakov, Hristo Tenchev','Magdalena Dimitrova');

