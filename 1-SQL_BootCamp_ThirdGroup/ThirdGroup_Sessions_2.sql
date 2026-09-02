/*
----------SQl------------
1- DQl 
2- DDl 
3- DMl

						Introduction to Data Definition Language (DDL) in SQL Server
Main Commands : 
					Create                       Alter                     Drop 
1- Create Table 
	Syntax:
    CREATE TABLE table_name (
        column_name datatype [CONSTRAINT constraint_name constraint_type],
        ...,
        [CONSTRAINT constraint_name constraint_type]
    );

Naming Rules:
    - Maximum 128 characters.
    - Can include A-Z, a-z, 0-9, _
    - Must begin with a letter.
    - Must not be a reserved keyword.

	Common Datatypes in SQL Server:
    - Numeric: INT, BIGINT, SMALLINT, DECIMAL(p,s), FLOAT
    - Text: CHAR(n), VARCHAR(n), TEXT
    - Date/Time: DATE, DATETIME, SMALLDATETIME, TIME
    - Other: BIT, MONEY, UNIQUEIDENTIFIER, VARBINARY(MAX)

	Constraint Types:
    - PRIMARY KEY
    - UNIQUE
    - NOT NULL
    - CHECK (condition)					
    - FOREIGN KEY REFERENCES other_table(column)

2. ALTER TABLE: add  alter  drop 
---------------
Syntax Overview:
    ALTER TABLE table_name
	   -- Add a new column
ex:ALTER TABLE table_name ADD column_name datatype ; 
       -- Modify column datatype or nullability
ex:ALTER TABLE table_name alter Column column_name datatype  ; 
		-- Drop a column
ex:ALTER TABLE table_name DROP COLUMN column_name;
     
	    -- Add a constraint
ex:ALTER TABLE table_name ADD CONSTRAINT constraint_name c
        -- Drop a constraint
ex:ALTER TABLE table_name DROP CONSTRAINT constraint_name;

3. DROP TABLE:
--------------
Syntax:
    DROP TABLE table_name;
ex: Drop Table table_name ;
*/


--create table emp2(
--emp_id   int , 
--emp_name varchar(50)
--);
create table emp3(
emp_id   int         primary key , 
emp_name varchar(50) not null    ,
phone    varchar(16) unique 
);

create table emp4(
emp_id   int         constraint emp4_emp_id_pk    primary key  , 
emp_name varchar(50) constraint emp4_emp_name_nk  not null     ,
phone    varchar(16) constraint emp4_emp_Phone_uk unique 
--manager int  FOREIGN KEY REFERENCES emp3(emp_id)
);
create table emp5(
emp_id   int                      , 
emp_name varchar(50) not null     ,
phone    varchar(16)              ,
--manager int 
constraint emp5_emp_id_pk    primary key(emp_id)   ,
constraint emp5_emp_Phone_uk unique(phone) 
--constraint emp5_emp_fk  FOREIGN KEY(manager) REFERENCES emp3(emp_id)
);


alter table emp5 add email       varchar(100) ; 
alter table emp5 add emp_address varchar(150) not null  ; 
-----
alter table emp5 alter column emp_address nvarchar(250) null ; 
-----
alter table emp5 drop column emp_address ;
alter table emp5 drop column phone ;
-----------

alter table emp5 add constraint emp_5_uk unique(email)  ; 
---------
alter table emp5 drop constraint emp_5_uk ;

--------------------------------
Drop table emp2
Drop table emp3
Drop table emp4
Drop table emp5

--create table travelSchud
--(trvelnumber int , 
--travel_date date , 
--plane_number int not null , 
--planecat varchar(50), 
--constraint ts_pk primary key(travel_date,trvelnumber), 
--); 

--create table customer (
--cust_id   int primary key        ,
--custname  varchar(100) not null ,
--trvelnum  int , 
--travedate date , 
--constraint cust_fk  FOREIGN KEY(travedate,trvelnum) REFERENCES travelSchud(travel_date,trvelnumber) )

--tavel
--		travel number -- 
--		travel date   --

--travel date -  travel number

--Testing 
--insert into emp2 values (1, 'ahmad') ; 
--insert into emp2 values (1, 'ahmad') ; 
--insert into emp2 values (1, 'ahmad') ; 
--insert into emp2 values (1, 'ahmad') ; 
--insert into emp2 values (1, 'ahmad') ; 
------------------------------------------------------------
--insert into emp3 values (1, 'ahmad','00000') ; 
--insert into emp3 values (1, 'ahmad','00001') ; --pk
--insert into emp3 values (2,   null ,'00002') ; --nk 
--insert into emp3 values (3, 'ahmad','00000') ; --uk
--insert into emp3 values (4, 'ahmad','00004') ; 
---------------------------------------------------------------
--insert into emp4 values (1, 'ahmad','00000') ; 
--insert into emp4 values (1, 'ahmad','00001') ; --pk
--insert into emp4 values (2,   null ,'00002') ; --nk 
--insert into emp4 values (3, 'ahmad','00000') ; --uk


--Q1 : Create Table MyDepts As Following : 
   --	Dept_ID   int          --> primary Key
	--	Dept_name varchar(100) --> not Null 

create table MyDepts2(
Dept_ID   int primary Key , 
Dept_name varchar(100) not Null 
);

--Q2 : Create Table MyEmps As Following : 
	    --	Emp_ID    int           --> primary Key
		--Emp_name  varchar(150)    --> not Null 
		--Salary    Deciml(8,2)     --> Check(salary>3000)
		--hire_date Date 
		--Dept_ID   int             --> Foreign key

create table MyEmps2(
Emp_ID    int		   constraint my_emp_Emp_id_pk   primary Key        ,
Emp_name  varchar(150) constraint my_emp_Emp_name_nk not null           , 
Salary    Decimal(8,2) constraint my_emp_Salary_Ck   check(salary>3000) , --999999.99
hire_date date        ,-- constraint my_emp_H_date_Dk   default getDate()  ,
Dept_ID   int          constraint my_emp_Dept_Id_Fk  foreign key references MyDepts2(Dept_ID)  
)
------------------------------------------------------------------------------------------
------------------------------------------------------------------------------------------
------------------------------------------------------------------------------------------
-------------------- Questions ------------------------
--* create courses table as follow:
--  cours_id => pk
--  course_title => not null
--  price => between 800 and 3000
--  start_date => default value the date after 7 days
--  duration => btw 12 and 120

create table courses(
cours_id     int          primary key                        ,
course_title varchar(200) not null                           , 
price        decimal(6,2) check(price between 800 and 3000)  , 
start_date   Date         default dateadd(day ,7,getDate())  ,
duration     int          check (duration between 12 and 120)
);

--* create a projects table 
--  project_id => pk
--  project_name => not null
--  client_name => 
--  hour_rate => positive greater than 1

create table projects(
project_id   int          primary key , 
project_name varchar(200) not null    , 
client_name  varchar(200) not null    ,
hour_rate    decimal(6,2) check (hour_rate> 1 ) 
);

--* create a tasks table
--  task_id => pk
--  description => max char 255
--  start_date => date
--  end_date => greater than start_date
--  project_id => foreign key

create table tasks(
task_id       int         primary key                         ,  
T_description varchar(255)                                    ,
[start_date]  date                                            , 
end_date      date                                            ,   
project_id    int  foreign key references projects(project_id),
constraint tasks_end_date_ck check (  end_date >  [start_date])
);
