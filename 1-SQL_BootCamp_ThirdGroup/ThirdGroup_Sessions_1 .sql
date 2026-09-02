-- DQL (Data Query Language) is used to fetch data from database objects such as tables and views.
-- The main DQL command is:     SELECT


-- 🔹 SQL SELECT SYNTAX:

-- SELECT  column1, column2 | * | exp  ...
-- FROM table_name
-- [WHERE condition]
-- [GROUP BY column1, column2, ...]
-- [HAVING group_condition]
-- [ORDER BY column1, column2, ... [ASC|DESC]]


-- 🔹 Operators:
--   ➕ Arithmetic: +, -, *, /
--   🔁 Comparison: =, !=, <>, <, <=, >, >=
--   🧠 Logical: AND, OR, NOT
--   🧮 Range: BETWEEN ... AND ...
--   📋 List: IN (...)
--   🔍 Pattern: LIKE 'pattern' _ % 
--   🚫 NULL Check: IS NULL, IS NOT NULL

-- 🔹 Functions:
-- single row Function  : 
	--   🔤 Text: UPPER(), LOWER(), LEN(), LEFT(), RIGHT()
	--   🔢 Numbers: ROUND(), CEILING(), FLOOR()
	--   📅 Dates: GETDATE(), DATEADD(), DATEDIFF(), YEAR(), MONTH(), DAY()
	--   🔄 Conversion: CAST(), CONVERT()
	--   ⚙️ Conditional: CASE, IIF()

-- Group Function : 
		-- Count() ,Max() ,Min() ,Sum() ,AVG()

--note : تستخدم في شروط ال Having


select * 
from employees 

select last_name , salary 
from employees

select last_name , salary * 12 as AnnaualSalary
from employees

select last_name , salary * 12 as AnnaualSalary
from employees
where department_id=90
 

select last_name ,salary,  salary * 12 as AnnaualSalary
from employees
where salary >= 5000


select last_name ,salary,  salary * 12 as AnnaualSalary
from employees
where salary >= 5000 and salary <=15000

select last_name ,salary,  salary * 12 as AnnaualSalary
from employees
where salary between 5000 and 15000

select last_name ,salary,  salary * 12 as AnnaualSalary
from employees
where hire_date between '1996-06-01' and '1996-06-30'

select last_name ,salary,  salary * 12 as AnnaualSalary , department_id
from employees
where department_id = 90 or department_id =60 or department_id = 30 

select last_name ,salary,  salary * 12 as AnnaualSalary , department_id
from employees
where department_id in(30,60,90)

select last_name ,salary,  salary * 12 as AnnaualSalary , department_id
from employees
where not(department_id = 90)

select * 
from locations
where city ='roma'

select * 
from employees

select * 
from employees 
where last_name like 'k%'

select * 
from employees 
where job_id like '%man'
 
select * 
from employees 
where department_id is null

select * 
from employees 
where department_id is not null

select distinct department_id
from employees

select last_name , upper(last_name) as capital_case , lower(last_name)  as small_case , len(last_name)as CountOfChar
from employees
where lower(job_id)= 'it_prog'
order by CountOfChar
 
select round (15.678,2) as Rounder_Number  ,ceiling(15.1) as Celing_Number  , FLOOR(15.9) as FloorNumber 

select last_name  , hire_date , GETDATE() as today 
from employees 


select last_name  ,year( hire_date) as Hire_Year ,
				   year( GETDATE()) as CuurentYear,
				   DateDiff(year, hire_date , getDate()) as Worked_year
from employees 
order by Worked_year

select last_name , cast(salary as varchar) +' $'  as Salary  , CONVERT(varchar(10), hire_date , 104)
from employees 
/*
 2100 -  5999  low salary 
 6000 -  9999  normal salary 
10000 -  14999 high   salary 
15000 -  24000 very high salary 
*/

 select last_name , department_id , job_id ,case
												when salary between 2100  and 5999 then  'Low Salary '
												when salary between 6000  and 9999 then  'normal salary '
												when salary between 10000 and 14999 then 'high   salary  '
												else ' very high salary  '
											end as Salary_level
 from employees 
 order by salary

  select last_name , department_id , job_id , iif(salary>=10000 , 'High SAlary ' , 'Normal Salary ')as Salary_level
 from employees 
 where salary >=10000
 order by salary

 select count (department_id)as countOfEmployee
 from employees 

  select count (*)as countOfEmployee   , sum(salary)as Total_SAlary , 
	     max(salary ) as TheMax_SAlary , Min(salary ) as theMinSAlary, 
		 ( sum(salary)/ count (*))as AvgSalary ,
		  AVG(salary ) as Avg_salary 
 from employees 

  select department_id,count (*)  as countOfEmployee
					 , sum(salary)as Total_SAlary , 
					   max(salary ) as TheMax_SAlary ,
					   Min(salary ) as theMinSAlary, 
					   AVG(salary ) as Avg_salary 
 from employees
 group by department_id

  --add condition to select groups which have less than 10 employee 
   select department_id,count (*)  as countOfEmployee
					 , sum(salary)as Total_SAlary , 
					   max(salary ) as TheMax_SAlary ,
					   Min(salary ) as theMinSAlary, 
					   AVG(salary ) as Avg_salary 
 from employees
 group by department_id
 having count(*)<10
 order by countOfEmployee

   select department_id,count (*)  as countOfEmployee
					  ,sum(salary)as Total_SAlary , 
					   max(salary ) as TheMax_SAlary ,
					   Min(salary ) as theMinSAlary, 
					   AVG(salary ) as Avg_salary 
 from employees
 group by department_id
 --having count(*)<10
 order by countOfEmployee


 select department_id ,count (*)  as countOfEmployee
					  ,sum(salary)as Total_SAlary , 
					   max(salary ) as TheMax_SAlary ,
					   Min(salary ) as theMinSAlary, 
					   AVG(salary ) as Avg_salary 
 from   employees 
 where  salary >=8000
 group by department_id
 having count(*) < 10
 order by countOfEmployee

select job_id , count(*)
from  employees
where department_id in (90 , 60 , 30)
group by job_id
having count(*)>2


 ------------------------------------------------------------
-- 🟡 INTERMEDIATE LEVEL TASKS
------------------------------------------------------------
-- Task 10: Use variables in a query
declare @limit int = 5000
select * 
from Employees 
where salary>=5000
order by salary

-- Task 11: Use BETWEEN with variables
declare @StartDate date = '1998-01-01'
declare @EndDate date = '1998-12-31'
select * 
from Employees 
where hire_date between @StartDate and @EndDate


-- Task 12: Use string functions
select last_name , upper(last_name ) as Capital_case , Lower (Last_Name )AS small_Case , len(Last_name )as countOfChar
from employees 


-- Task 13: Use GROUP BY
select department_id
from Employees 
group by department_id

-- Task 14: Use HAVING to filter groups
select department_id , count(*)as 'عدد موظفي القسم '      ,
			           sum(salary )as'مجموع رواتب القسم ' ,
					   avg(salary) as 'متوسط الرواتب '
from Employees 
group by department_id
having avg(salary) >=5000


-- Task 15: Use CASE to categorize results
select Last_name , salary , department_id , case 
												when salary between 2000 and 4999 then 'low salary'
												when salary between 5000 and 8000 then 'normal salary'  
												when salary between 8001 and 23000 then 'high Salary'
												else 'There is a Problem '
											end as SalaryLevel 
from employees

-- Task 16: Use date functions
select year(getdate()) as CurrentDate , last_name , year(Hire_Date) as Hire_year ,
      DateDiff(year, hire_date,getDate())as worked_Year ,
	  year(getdate()) - year(Hire_Date) as YearNumberDiffrence
from employees 


-- Task 17: Use CAST and CONVERT
select Last_name , cast (salary as varchar) + ' $' as salary_text , convert (varchar (10), hire_date , 105) as hireDate
from employees 

-- Task 18: Use IIF for conditional output
select Last_name , iIf (salary >=4000 ,'Low Salary', 'high Salary ')
from employees

-- Task 18.1: Apply IIF on commission_pct
select Last_name , iIf (commission_pct is not null   ,'has Commission', 'no Commission')
from employees

------------------------------------------------------------
-- 🔴 ADVANCED LEVEL TASKS (JOINS & MULTI-TABLE)
------------------------------------------------------------
select * 
from employees

select * 
from departments

select * 
from locations

select last_name , Department_name 
from   employees , departments
where employees.department_id = departments. department_id

select Last_name , department_name
from employees join departments on employees .department_id = departments.department_id


select last_name , Department_name , city
from   employees e, departments  d, locations l
where  e.department_id = d. department_id 
  and  d.location_id = l.location_id
 

select Last_name , department_name , city
from employees e 
				join departments d on e .department_id = d.department_id
		  inner join locations l   on d.location_id    = l.location_id 

select Last_name , department_name
from employees join departments on employees .department_id = departments.department_id

select Last_name , department_name
from employees left join departments on employees .department_id = departments.department_id

select Last_name , department_name
from employees right join departments on employees .department_id = departments.department_id

select Last_name , department_name
from employees e full outer join departments d on e .department_id = d.department_id

select Last_name , department_name
from employees e cross join departments d 
  


select d.Department_id , Department_name , First_name , Last_name 
from departments d join employees e on d.manager_id = e.employee_id

/* make A report that Mention all Departments Date like :

1-Department_id AS Department Number and Department Name wnd Last_name For Manager of 
the Department AS Manager Name sort the date of Report By ManagerName 

2-Department_id AS Department Number and Department Name wnd Last_name For Manager of 
the Department AS Manager Name sort the date of Report By ManagerName and
retrive the Department which Haven't 
Manager 
 */
 select d.department_id as 'Department Number' ,
		d.department_name as ' Department Name', 
		e.last_Name as 'Manager Name' 
from departments d join employees e on d.manager_id=e.employee_id
order by e.last_Name

 select d.department_id as 'Department Number' ,
		d.department_name as ' Department Name', 
		e.last_Name as 'Manager Name' 
from departments d left join employees e on d.manager_id=e.employee_id
order by e.last_Name

-- Task 19: Use INNER JOIN to combine employees with departments
select *
from employees e inner join departments d on e.department_id = d.department_id 

-- Task 20: Use CROSS JOIN to show all employee-job combinations
select * from employees
select * from jobs

select *
from employees e CROSS JOIN jobs j 

-- Task 21: Use JOIN with three tables
select Last_name , department_name , city
from employees e 
				join departments d on e .department_id = d.department_id
		  inner join locations l   on d.location_id    = l.location_id 

-- Task 23: Use LEFT, RIGHT, FULL OUTER JOINs
select Last_name , department_name
from employees left join departments on employees .department_id = departments.department_id

select Last_name , department_name
from employees right join departments on employees .department_id = departments.department_id

select Last_name , department_name
from employees e full outer join departments d on e .department_id = d.department_id

-- Task 22: Use SELF JOIN to show employees with their managers

select e.last_name as Emp_Name ,m.first_name +' '+ m.Last_name as ManagerName
  from employees e join employees m on e.manager_id =m.employee_id

-- Task 24: Use WHERE with complex logic (AND/OR)
select  e.last_name as Emp_Name ,m.first_name + ' '+ m.Last_name as ManagerName
  from employees e join employees m on e.manager_id =m.employee_id
  where m.last_name='King' and e.commission_pct is not  null
--  where e.salary >= 8000 or e.job_id='ad_vp'
------------------------------------------------------------
-- 🧠 QUESTIONS & EXERCISES – BEGINNER LEVEL
------------------------------------------------------------
-- Q1: Show full name and salary of each employee
select e.first_name +' '+ e.Last_name as Full_Name ,e. salary
from employees e
-- Q2: Show job ID and salary > 5000 for IT_PROG
select job_id , salary 
from employees 
where salary > 5000  and  job_id='IT_PROG'
-- Q3: Show employees hired after 2007, sorted by hire date desc
------------------------------------------------------------
-- 🧠 QUESTIONS & EXERCISES – INTERMEDIATE LEVEL
-----------------------------------------------------------
-- Q4: Show department ID and avg salary for depts with avg > 6000
select  avg(salary)  
from employees 
-------------
select department_id 
from employees 

select department_id , avg(salary)  
from employees 
group by department_id
having  avg(salary) > 6000
-- Q5: Show job ID and count of employees per job
-- Q6: Categorize salary levels using CASE (High, Medium, Low)
------------------------------------------------------------
-- 🧠 QUESTIONS & EXERCISES – ADVANCED LEVEL (JOINS)
------------------------------------------------------------
-- Q1: Show employees with their department names
-- Q2: Show employees with their manager names
-- Q3: Show departments that have no employees
select d.department_name  
from departments  d left join employees  e on e.department_id =d.department_id
where e.last_name is null 
-- Q4: Show employees with department name and city
select e.last_name , d.department_name , l.city
from employees e join departments d on e.department_id = d.department_id
				 join locations   l on d.location_id = l.location_id
-- Q5: Use CROSS JOIN to show all employee-job combinations
-- Q6: Show employees working in city ‘Toronto’
select *  from employees 
select *  from departments
select *  from Locations 

select e.last_name , d.department_name , l.city
from employees e join departments d on e.department_id = d.department_id
				 join locations   l on d.location_id = l.location_id
where  l.city = 'Toronto'
-- Q7: Show employees with salary > 12000
-- Q8: Show employees with salary NOT BETWEEN 5000 AND 12000
select *
from employees 
where salary not BETWEEN 5000 AND 12000
-- Q9: Show employees in certain jobs, excluding some salaries
select * 
from employees 
where job_id in ( 'FI_ACCOUNT', 'ad_vp' , 'it_prog' )
  and salary not in (17000 , 9000 , 8200 )

-- Q10: Show last names starting with J, A, or M (uppercase + length)
select last_name ,UPPER(last_name) as uppercase , len(last_name) as length
from employees
where last_name like 'J%'
   or last_name like 'A%'
   or last_name like 'M%'
-- Q11: Show department address details using LOCATIONS
------------------------------------------------------------
-- ✅ END OF COURSE (WITHOUT SOLUTIONS)
------------------------------------------------------------
 

