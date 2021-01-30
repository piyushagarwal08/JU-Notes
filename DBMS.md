# DBMS

* For long integer ```bigint```
* Primary Key can never be NULL but unique key can be
* To remove a column ```Alter table table-name drop column-name```
* To Update Values ```Update Table-name Column-name=value where condition```
* To Delete Values ```Delete from Table-name where condition```
* Query Optimization ~> The query optimizer attempts to determine the most efficient way to execute a given query by considering the possible query plans.

* Anomally
Anomalies are problems that can occur in poorly planned, un-normalised databases where all the data is stored in one table (a flat-file database).

Insertion Anomaly - The nature of a database may be such that it is not possible to add a required piece of data unless another piece of unavailable data is also added. E.g. A library database that cannot store the details of a new member until that member has taken out a book.

Deletion Anomaly - A record of data can legitimately be deleted from a database, and the deletion can result in the deletion of the only instance of other, required data, E.g. Deleting a book loan from a library member can remove all details of the particular book from the database such as the author, book title etc.

Modification Anomaly - Incorrect data may have to be changed, which could involve many records having to be changed, leading to the possibility of some changes being made incorrectly.

* Problems with File System:
    1. Data Redundancy: It is possible that the same information may be duplicated in different files. ...
    2. Data Inconsistency: ...
    3. Difficulty in Accessing Data: ...
    4. Limited Data Sharing: ...
    5. Integrity Problems: ...
    6. Atomicity Problems: ...
    7. Concurrent Access Anomalies: ...
    8. Security Problems:

## Keys
* it is used for identifying unique rows from table. It also establishes relationship among tables.
    1. Primary Key – A primary is a column or set of columns in a table that uniquely identifies tuples (rows) in that table and is not NULL.

    2. Super Key – A super key is a set of one of more columns (attributes) to uniquely identify rows in a table.

    3. Candidate Key – A super key with no redundant attribute is known as candidate key. There can be more then one candidate key.

    4. Alternate Key – Out of all candidate keys, only one gets selected as primary key, remaining keys are known as alternate or secondary keys.

    5. Composite Key – A key that consists of more than one attribute to uniquely identify rows (also known as records & tuples) in a table is called composite key.

    6. Foreign Key – Foreign keys are the columns of a table that points to the primary key of another table. They act as a cross-reference between tables.

* What is the Domain of an attribute
    It is the type of value that is present that is int,string,char etc.

* Normalisation
    1. Functional Dependency ~> Analyse on which dependency database is set, Relationship between two attributes
    2. Remove redundancy
    3. Minimise Insertion/Deletion/Update anomalies

* Types of languages in DBMS
    1. DDL  ~> Data Definition Language (Create/Alter/Drop/Truncate)
    2. DML ~> Data Manipulation Language (Select,Insert,Update)
    3. DCL ~> Data Control Language (Grant/Revoke)
    4. TCL ~> Trasaction Control Language (Commit/Roll back)
    5. VDL ~> View Definition Language

* Levels of abstraction in DBMS
    1. Physical ~> This is the lowest level of data abstraction. It describes how data is actually stored in database. You can get the complex data structure details at this level.
    2. Logical ~> It describes what data is stored in database
    3. View ~> This level describes the user interaction with database system.

* Aggregation
    1. Maintain relationship between 2 RDBMS
    2. Feature of Entity relation model which allow 1 relationship set to participate with another Relationship set
    3. How more then one record collectively represent a dataset

* Properties of Transaction are ACID properties
* Locking Scheme in Transaction:
    1. Shared Lock ~> Other transaction can only read and not write (paise nikalte samey)
    2. Exclusive Lock ~> Other transaction can neither read nor write (for other operations like pin change karna/check balance)

* UNIQUE Key can be NULL for once only
* Triggers
    * Set of commands executed when certain event occurrs
* Stored Procedure is basically a set of SQL queries that are executed all together in a pre-maded sequence

* the most commonly used normal forms:
    1. First normal form(1NF) ~> A relation is in first normal form if every attribute in that relation is singled valued attribute.
    2. Second normal form(2NF) ~> A relation must be in first normal form and relation must not contain any partial dependency.
    3. Third normal form(3NF) ~> Transitive dependencies are removed in this form
    4. Boyce & Codd normal form (BCNF)

* Weak Entity Set
    A weak entity set is an entity set that does not contain sufficient attributes to uniquely identify its entities
* Multivalue Attrivute
    An attribute that can hold multiple values is known as multivalued attribute. It is represented with double ovals in an ER Diagram.
* Strong Entity Set
    A strong entity set is an entity set that contains sufficient attributes to uniquely identify all its entities.

* Functional Dependency
    1. It is of 2 types:
        * Trival
        * Non-Trival
* Inference Rule

* Partial Dependency
    Partial Dependency occurs when a nonprime attribute is functionally dependent on part of a candidate key.
* Fully-functionally Dependency
    An attribute is fully functional dependent on another attribute, if it is Functionally Dependent on that attribute and not on any of its proper subset.

* Concurrency Control ~> Concurrency control is the procedure in DBMS for managing simultaneous operations without conflicting with each another. It helps you to make sure that database transactions are performed concurrently without violating the data integrity of respective databases.

# Data Model
<a href="https://afteracademy.com/blog/what-is-data-model-in-dbms-and-what-are-its-types">Learn More</a>

* Data Model gives us an idea that how the final system will look like after its complete implementation.
* Some of them are:
1. Hierarchical Model ~> Hierarchical Model was the first DBMS model. This model organises the data in the hierarchical tree structure. The hierarchy starts from the root which has root data and then it expands in the form of a tree adding child node to the parent node.

2. Network Model ~> a record can have more than one parent.

3. Entity-Relationship Model ~> the real-world problem in the pictorial form to make it easy for the stakeholders to understand. 

4. Relational Model ~> In this model, the data is maintained in the form of a two-dimensional table. All the information is stored in the form of row and columns. The basic structure of a relational model is tables. So, the tables are also called relations in the relational model.

5. Object-Oriented Data Model ~> both the data and relationship are present in a single structure known as an object. 

6. Object-Relational Data Model ~> This model was built to fill the gap between object-oriented model and the relational model. We can have many advanced features like we can make complex data types according to our requirements using the existing data types.

7. Flat Data Model ~> It is a simple model in which the database is represented as a table consisting of rows and columns. To access any data, the computer has to read the entire table. This makes the modes slow and inefficient.

8. Semi-Structured Data Model
Associative Data Model
Context Data Model



# Basics
* To connect to database ```\connect root@localhost:3306```
* To disconnect from database ```\quit```
* To change language from ```JS``` to ```SQL``` use ```\sql```
* To Create a database ```create database db-name```
* To clear shell screen, use ```Ctrl + L```
* To Create a table 
```sql
create table tb-name(
    col1-name data-type,
    col2-name data-type
);
```
* To check the schema of table ```describe tb-name```
* To insert row ```insert into tb-name(col1-name,col2-name) values("piyush",12);``` or ```insert into tb-name values("piyush",12);```

* To delete rows ```delete from tb-name where condition```
* To update rows ```update tb-name set col-name=new-value where condition```
* To LIMIT the no of rows, ```LIMIT count``` is used
* To get rows with unique values ```DISTINCT``` is used as ```SELECT DISTINCT column-name FROM tb-name```
* To Count no of rows in table ```SELECT COUNT(*) FROM tb-name```
* For logical operations ```AND```, ```OR``` are used
* To Apply Condition for range, use ```BETWEEN``` keyword as ```SELECT * FROM tb-name WHERE field1 BETWEEN range-1 AND range-2```
* ```BETWEEN``` is inclusive in nature
* To check condition from a iterative object, use ```IN``` as ```SELECT * FROM tb-name WHERE age IN (2,4,6,8,10)``` , this will result in list of tuples with age equal to 2,4,6,8 or 10.
* Missing or Unknown Values are represented by ```NULL``` in SQL and they can be checked by using ```IS NULL``` or ```IS NOT NULL``` expression
* IN SQL, ```LIKE``` operator is used with ```WHERE``` clause to search for a ```pattern``` in a column. It uses 2 types of wildcards:
    1. ```%``` ~> represents zero, one or more charcater
    2. ```_``` ~> represents a single character
* Similar to ```LIKE```, we can use ```NOT LIKE``` operator for values not matching certain ```pattern```
* To Perform arithematic operations , queries like ```SELECT (a+b)``` or ```SELECT (a-b)``` or ```SELECT (a/b)``` can be used
* Arithematic operations are similar to C programming as Int/Int is INT
* Aliasing ~> Assigning a temporary name to something, it is done in SQL using ```AS``` keyword
* To Comment something in SQL use ```--``` or ```/* */``` for multiline comment
* To Sort results ```ORDER BY``` keyword is used, by default its in ```Ascending``` order and for ```Descending``` order we use ```DESC``` as ```SELECT * FROM tb-name ORDER BY field1 DESC```
* ```ORDER BY``` can be used to sort table data based on multiple columns as ```SELECT * FROM tb-name ORDER BY col1,col2```
* To Count the Value of cells based on Groups, or basically to divide the data into multiple groups, ```GROUP BY``` is used
* ```ORDER BY``` is always used after the ```GROUP BY```
* ```HAVING``` clause is used to use ```AGGREGATE``` functions after ```WHERE``` clause

## JOIN in DBMS
* To do ```INNER JOIN```, query is ```SELECT * FROM l-table INNER JOIN r-table ON l-table.id=r-table.id;```
* When joining tables with a common field name, we can use ```USING``` as a shortcut as ```SELECT * FROM tb-name1 INNER JOIN tb-name2 USING(common-field-name)```
* To use if else conditions in SQL, we use ```CASE```,```WHEN``` and ```THEN```
```sql
SELECT country_code, size,
  CASE WHEN size > 50000000
            THEN 'large'
       WHEN size > 1000000
            THEN 'medium'
       ELSE 'small' END
       AS popsize_group
INTO pop_plus       
FROM populations
WHERE year = 2015;
```
* To do ```LEFT JOIN```, query is ```SELECT * FROM l-table LEFT JOIN r-table ON l-table.id = r-table.id;```
* To do ```RIGHT JOIN```, query is ```SELECT * FROM r-table RIGHT JOIN l-table ON l-table.id = r-table.id;```
* TO do ```FULL JOIN```,query is ```SELECT * FROM l-table FULL JOIN r-table USING(field)```

* <u>SET THEORY</u>
* ```UNION``` and ```UNION ALL``` are used to group or merge the output of two or more queries.
* ```UNION``` refers to summing up of only UNIQUE records where as ```UNION ALL``` refers to summing up of all the records
* QUERY is as ```SELECT * FROM tb1 WHERE condition UNION SELECT * FROM tb2 WHERE condition2```, the only thing to make sure is that domain of each field from output of both sub-query should be same
* ```INTERSECT``` is used to extract records that are unique in both the sub queries
* ```SELECT * FROM tb1 INTERSECT SELECT * FROM tb2```
* ```EXCEPT``` is used to find the ```A-B``` of two sub-queries in table, ```SELECT * FROM tb1 EXCEPT SELECT * FROM tb2```
* ```SEMI JOIN```, is query where contents in tb1 match to contents in tb2, ```SELECT * FROM tb1 WHERE field IN (SELECT * FROM tb2);```
* ```ANTI JOIN```, is query where contents in tb1 not match to contents in tb2, ```SELECT * FROM tb1 WHERE field NOT IN (SELECT * FROM tb2);```
* Sample of Subquery inside query
```sql
-- Select fields
SELECT *
  -- From populations
  FROM populations
-- Where life_expectancy is greater than
WHERE life_expectancy > 1.15 * 
  -- 1.15 * subquery
  (
    SELECT AVG(life_expectancy)
      FROM populations
      WHERE year = 2015
  ) AND year = 2015;
```
* Subqueries are most frequently used in ```WHERE``` clause
* Cross JOIN is used as ```SELECT * FROM tb1 CROSS JOIN tb2```
* To get the Round-of value, we can use ```ROUND(value,decimal-pomit)``` to get the required output as ```ROUND(0.3434,2)``` to get ```0.34```

## Correlated Subqueries
* Simple Subquery Vs Correlated Subqueries
<table>
<tr>
    <th>Simple Subquery</th>
    <th>Correlated Subquery</th>
</tr>
<tr>
    <td>Can be run independently from the main query </td>
    <td>Dependent on the main query to eecute </td>
</tr>
<tr>
    <td>Evaluated once in the whole query</td>
    <td> Evaluated in loops -> Significantly slows down query runtime</td>
</tr>
</table>

* To get Month from ```Date```, we can use ```EXTRACT(MONTH FROM DATE)```
* Correlated Nested Subqueries can be correlated or uncorrelated
    1. They can be a combination of two
    2. Can reference information from the outer subquery or main query

## Common Table Expressions
* Table declared before main query
* Named and referenced later in ```FROM``` statement
```sql
WITH cte AS (
    SELECT col1, col2 
    FROM table)

SELECT 
    AVG(col1) AS avg_col
FROM cte;
```
* Executed only once
    1. CTE is stored in memory
    2. Improves query performance
* Improving organization of queries
* Referencing other CTEs
* Referencing itself (SELF JOIN)
* To declare multiple ```CTE``` just separate them with a ```comma(,)```
```sql
WITH home AS (
  SELECT m.id, m.date, 
  		 t.team_long_name AS hometeam, m.home_goal
  FROM match AS m
  LEFT JOIN team AS t 
  ON m.hometeam_id = t.team_api_id),
-- Declaring another CTE after ,
-- Declare and set up the away CTE
away AS (
  SELECT m.id, m.date, 
  		 t.team_long_name AS awayteam, m.away_goal
  FROM match AS m
  LEFT JOIN team AS t 
  ON m.awayteam_id = t.team_api_id)
-- Select date, home_goal, and away_goal
SELECT 
	home.date,
    home.hometeam,
    away.awayteam,
    home.home_goal,
    away.away_goal
-- Join away and home on the id column
FROM home
INNER JOIN away
ON home.id = away.id;
```

## Window Functions
* Functions that Perform calculations on an already generated result set (a window)
* Aggregate Calculations
    1. Similar to subqueries in ```SELECT```
    2. Running totals, rankings, moving averages
```sql
SELECT
    date,
    (home_goal + away_goal) AS goals,
    AVG(home_goal + away_goal) OVER() AS overall_avg
FROM match
WHERE season = '2011/2012';
```
```sql
-- RANK() function orders rank from smallest to largest value
SELECT 
    date,
    (home_goal + away_goal) AS goals,
    RANK() OVER(ORDER BY home_goal + away_goal) AS goals_rank
FROM match
WHERE season = '2011/2012';
```
* Processed after every part of query except ```ORDER BY```
    1. Uses information in result set rather than database
* Available in PostgreSQL, Oracle   , MySQL, SQL Server.. but not SQLite
```sql
-- PARTITION BY
/*
Calculates separate values for different categories
Calculates different calculations in the same column
*/
SELECT
    date,
    (home_goal + away_goal) AS goals,
    AVG(home_goal + away_goal) OVER(PARTITION BY season) AS overall_avg
FROM match
WHERE season = '2011/2012';
```

### Sliding Windows
* Performs calculations relative to the current row
* Can be used to calculate running totals, sums, averages, etc
* Can be partitioned by one or more columns
```sql
ROWS BETWEEN <start> AND <finish>
```
* Keywords that can be used in place of start and finish:
    1. PRECEDING
    2. FOLLOWING
    3. UNBOUNDED PRECEDING -> since the beginning
    4. UNBOUNDED FOLLOWING
    5. CURRENT ROW -> stop at current row
```sql
SELECT 
	date,
	home_goal,
	away_goal,
    -- Create a running total and running average of home goals
    SUM(home_goal) OVER(ORDER BY date 
         ROWS BETWEEN UNBOUNDED PRECEDING AND CURRENT ROW) AS running_total,
    AVG(home_goal) OVER(ORDER BY date 
         ROWS BETWEEN UNBOUNDED PRECEDING AND CURRENT ROW) AS running_avg
FROM match
WHERE 
	hometeam_id = 9908 
	AND season = '2011/2012';
```

* to add a ```DATE``` in sql, we use ```Date``` data-type and it is inserted as ```DATE 'yyyy/MM/dd'``` format
* to add a ```TIMESTAMP``` in sql, we use ```timestamp``` data-type and it is inserted as ```TIMESTAMP 'yyyy/MM/dd HH:MM:SS```
* Timestamp from ```1900``` onwards can only be inserted into SQL
* To insert characters like ```'(single quote)```, one need to use ```\(backslash)```
* to use column names with space in between like ```Column Number 1```, we need to represent it inside ```back-quotes``` like ``` `Column Number 1` ``` though it is preferable to always use ```underscore _``` instead of ```space```
* To change password use ```ALTER USER 'root'@'localhost' IDENTIFIED BY 'New-Password'```
