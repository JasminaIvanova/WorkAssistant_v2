CREATE DATABASE WorkAssistant;
USE WorkAssistant;

CREATE TABLE users
(
	id INT PRIMARY KEY AUTO_INCREMENT,
    first_name VARCHAR(30) NOT NULL, 
    last_name VARCHAR(30) NOT NULL, 
    username VARCHAR(30) NOT NULL UNIQUE,
    email VARCHAR(80) NOT NULL, 
    password VARCHAR(200) NOT NULL, 
    company_name VARCHAR(50) NOT NULL
);

SELECT * FROM users;
SELECT * FROM user_tasks;

CREATE TABLE user_tasks
(
	id INT PRIMARY KEY AUTO_INCREMENT,
    user_id INT NOT NULL,
    FOREIGN KEY (user_id)
    REFERENCES users(id),
    task_title VARCHAR(30) NOT NULL,
    task_description VARCHAR(256) NOT NULL,
    effort_time INT NOT NULL, 
    percentage INT NOT NULL
);

INSERT INTO user_tasks VALUES (1, 1, 'test task', 'try to add task', 0,0);