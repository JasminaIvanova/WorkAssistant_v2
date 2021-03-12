CREATE DATABASE WorkAssistant;
USE WorkAssistant;

CREATE TABLE company
(
	id INT PRIMARY KEY AUTO_INCREMENT,
    name_company VARCHAR(50) NOT NULL
);

SELECT * FROM users;
SELECT * FROM user_tasks;

CREATE TABLE users
(
	id INT PRIMARY KEY AUTO_INCREMENT,
    first_name VARCHAR(30) NOT NULL, 
    last_name VARCHAR(30) NOT NULL, 
    username VARCHAR(30) NOT NULL UNIQUE,
    email VARCHAR(80) NOT NULL, 
    password VARCHAR(200) NOT NULL, 
    company_id INT,
    FOREIGN KEY (company_id)
    REFERENCES company(id),
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
DROP TABLE users;
DROP TABLE user_tasks;

CREATE TABLE company_users
(
	company_id INT,
    FOREIGN KEY (company_id)
    REFERENCES company(id),
    user_id INT,
    FOREIGN KEY (user_id)
    REFERENCES users(id),
    first_name_contact VARCHAR(50) NOT NULL,
    last_name_contact VARCHAR(50) NOT NULL,
    phone_number_contact VARCHAR(50) NOT NULL,
    e_mail_contact VARCHAR(50) NOT NULL
);

DROP TABLE users;
#INSERT INTO user_tasks VALUES (1, 1, 'test task', 'try to add task', '00:00:00', '2020-03-08' ,0);

DELETE FROM user_tasks WHERE id = 2;

