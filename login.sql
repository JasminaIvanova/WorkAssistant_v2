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
    user_id INT,
    FOREIGN KEY (user_id)
    REFERENCES users(id),
    task_title VARCHAR(30) NOT NULL,
    task_description VARCHAR(256) NOT NULL,
    task_time TIME NOT NULL,
<<<<<<< HEAD
    #task_date DATE NOT NULL, 
    percentage INT NOT NULL
);

DROP TABLE user_tasks;

#INSERT INTO user_tasks VALUES (1, 1, 'test task', 'try to add task', '00:00:00', '2020-03-08' ,0);

DELETE FROM user_tasks WHERE id = 1;
=======
    task_date DATE NOT NULL, 
    percentage INT NOT NULL
);


INSERT INTO user_tasks VALUES (1, 1, 'test task', 'try to add task', 0,0);
>>>>>>> de050fbd73eecdd6c80caef72f53062876f158ce
