/*
Dml     : Data Manipulation Language

insert  : Used to add new records to a table.
			Syntax:
				INSERT INTO table_name (column1, column2, ...)
								VALUES (value1 , value2 , ...);

update  : Used to modify existing records.
Syntax:
    UPDATE table_name
    SET column1 = value1, column2 = value2, ...
	WHERE condition;

delete  : Used to remove one or more records.

Syntax:
    DELETE FROM table_name
    WHERE condition;

*/
insert into MyDept( Dept_name , dept_id)
	    	values ( 'Back End '     ,4 ),
				   ( 'Back End '     ,5 ),
				   ( 'Back End '     ,6 ) 

update MyDept
 set   dept_name = 'Back-End'
 where dept_id in (2,3,4,5)

 delete from MyDept 
 where  dept_id in (2,3,4,5)

 



















 create table MyDept2(
Dept_ID int            Primary Key , 
Dept_name varchar(150) not null )

select * from MyDept