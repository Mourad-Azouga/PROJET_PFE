# Preparation
This is a prepatation markdown file where informations about the technologies we'll be using will be written, and somewhat well documented.
This file was created by AZOUGA Mourad on 14/03/2024

## ENTITY FRAMEWORK
 ### ENTITY FRAMEWORK
	.Entity framework is (ORM) | Object RElational Mapping, like sqlalchemy, this turns the data from relation database to an object to be accessed from the programming language of choice as an OOP, this terminates the usage of SQL queries.
	.Before the ORM, ADO.NET was used and made the developper make the logic for the manipulation of data within the db.
	.ORM maps the relationships between tables into c# objects, it also provides methods to read create update and delete from the db right from c#, this allows us to manipulate data in an OOP manner.
	. Example:
		-DbContext context = new DbContext();
		context.Customer.Where(condition).OrderByDescending.list()
		This is called method chaining where every method in the sequence pefroms an action on the result of the previous method.
		When we call such code entity converts this code into an optimized sql queries.
 
 ### LINQ
	.LINQ - Language-Integrated Query (LINQ) is a powerful set of technologies based on the integration of query capabilities directly into the C# language. LINQ Queries are the first-class language construct in C# .NET, just like classes, methods, events. The LINQ provides a consistent query experience to query objects (LINQ to Objects), relational databases (LINQ to SQL), and XML (LINQ to XML).

## IDENTITY
## ASP.NET BLAZOR
## FLUENT UI 
## MUD BLAZOR
## BOOSTRAP
## SQL SERVER EXPRESS 
## SQL SERVER MANAGEMENT STUDIO
