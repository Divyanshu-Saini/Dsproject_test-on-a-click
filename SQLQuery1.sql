CREATE DATABASE DSProject;

Use DSProject

--User details table 
CREATE TABLE Users_Details_tbl (
  user_id int IDENTITY(1,1) NOT NULL Primary key ,
  user_name varchar(50) NOT NULL,
  password varchar(max) NOT NULL,
  admin bit 
);

Alter table Users_Details_tbl
add college_name varchar(100) NULL

Alter table Users_Details_tbl
add constraint def_val
default 'NOt Applicable' for college_name

--Question set table
CREATE TABLE Question_tbl (
  question_id int IDENTITY(1,1) NOT NULL  Primary key ,
  question_name varchar(max) NOT NULL,
  difficulty varchar(50) NOT NULL,
);

--Answer set table
CREATE  TABLE  Answer_tbl (
  question_id int NOT NULL,
  option1 varchar(max),
  option2 varchar(max),
  option3 varchar(max),
  option4 varchar(max),
  CONSTRAINT fk_Qans FOREIGN KEY (question_id) REFERENCES Question_tbl(question_id) ON DELETE CASCADE ON UPDATE CASCADE
) ;


--result set table
CREATE TABLE Result_tbl (
  question_id int NOT NULL Primary key,
  correct_ans varchar(max) NOT NULL
);

ALTER TABLE Result_tbl
ADD CONSTRAINT fk_QRes
FOREIGN KEY (question_id)
REFERENCES Question_tbl(question_id) ON DELETE CASCADE ON UPDATE CASCADE


--user test score table
CREATE TABLE Test_Result_tbl (
  test_id int NOT NULL Primary key,
  user_id int NOT Null,
  score int NOT NULL,
  CONSTRAINT fk_User_test FOREIGN KEY (user_id) REFERENCES Users_details_tbl(user_id)  ON DELETE CASCADE ON UPDATE CASCADE
);


