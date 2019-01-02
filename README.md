
## Introduction

- Features
> This simple POS system by now includes the following features: 
> + Add new products
> + View products and transactions records
> + Ordering meals
> + Payment register

- Platform
> + OS: Windows 10 Professional 64-bit
> + IDE: Visual Studio Ultimate 2013
> + .NET Edition: 4.7
> + Client side: Windows forms
> + Database: Service-based database(database model: Entity Data Model)

## Tables
> The database consists of 4 tables:
> + TblProduct: The products that available to be ordered
> + TblProType: All the types of products
> + TblTransaction: Info of each transaction
> + TblTransItem: All the ordered items of each transaction

## Service-based database
+ How to build 
	- Create an empty windows forms application project
	- Add Service-based database: Solution Explorer -> Select the project title, right click -> Add -> New Item -> Service-based database -> assign the file name -> click 'Add'
	
+ Create tables
	- View -> Server Explorer
	- Expand the .mdf file -> Select 'Tables' and right click -> Add New Table
	- Both 'Design Mode' and 'T-SQL Mode' are avaliable for editing new table

+ Add Database Model
	- Add Database Model: Add New Item as above -> select 'ADot.Net Entity Data Model'
	- Choose **Database Contents**: select 'Generate from database'
	- Choose **Data Connection**: After naming the connection string as you like, click 'Next'
	- Choose **Database Objects**: toggole 'Tables', click 'Finish'

+ Update Database Model
	> Updating entity data model to match the current database which is likely to be modified.
	
	+ Refreshing .edmx file
		+ In Solution Explorer, click .edmx file to enter the diagram interface
		+ Right click on a blank spot, choose 'Update Model from Database'
	+ Refreshing .tt file
		+ Build the project after refreshing the .edmx file, the .tt file will be updated once the project been built seccessfully

+ Read from DB
	> Create 'ObjectQuery' instance using specific **Entity SQL command** and **DbContext** for **QUERYING**. For example: 

    ``` c#
    var filteredProducts = new ObjectQuery<TblProduct>
    (
	    "SELECT VALUE product FROM TblProduct AS product WHERE product.ProductType = " + tabPageKey, ((IObjectContextAdapter)cse).ObjectContext
    ); 
    ```
    
    > The main purpose of the above code is to query the products of the specific type from table 'TblProduct'.
    
    > NOTE: the **'cse'** above is an instance of the class 'CoffeshopEntities'(name of the **connection string**, the setting is on the step of **Choose Data Connection**), which deveried from DbContext, and this class is generated automatically by Entity Data Model.
    
+ Write to DB
	- [SqlConnection](https://docs.microsoft.com/en-us/dotnet/api/system.data.sqlclient.sqlconnection?view=netframework-4.7.2)
		- 2 ways of getting the connection string:
			- In 'App.config' -> [tag] 'connectionStrings' -> [property] 'connectionString' -> copy the value of that property
			- In Server Explorer, right click the .mdf file, choose 'Properties', then see the 'Connection String' value
        - Before the sql command is excuted, the sql connection must be opened, and once the command is finished, the connection should be closed immediately.
        - Example:
``` c#
using (SqlConnection connection = new SqlConnection(connectionString)) {
    using(var cmd = new SqlCommand(query, cn)) {
        //	parametrized queries
        ...

        cn.Open();
        cmd.ExecuteNonQuery(); 
        cn.Close();
        ...
    }
}  
```
	- SqlCommand
		- Always use [parameterized queries](https://blog.codinghorror.com/give-me-parameterized-sql-or-give-me-death/), the strings concatenation opens your app to SQL injection attacks
		- Example:
``` c#
using (var cmd = new SqlCommand("", connection)) {
        if (connection.State != System.Data.ConnectionState.Open)
            return;
        cmd.CommandText = "INSERT INTO TblTransaction(TransID, TransDate) VALUES (@TID, @date)";
        cmd.Parameters.AddWithValue("@TID", transID);
        cmd.Parameters.AddWithValue("@date", transDate);

        cmd.ExecuteNonQuery();
```
+ [Difference with local database](https://www.codeproject.com/Questions/312261/Confused-in-Local-Database-and-Service-Based-Datab)