# Dapper with ASP.NET Core Web API
The following project is an ASP.NET Core Web API that talks to a SQL Server database using the micro ORM Dapper.

![C#](https://img.shields.io/badge/c%23-%23239120.svg?style=for-the-badge&logo=c-sharp&logoColor=white)
![.Net](https://img.shields.io/badge/.NET-5C2D91?style=for-the-badge&logo=.net&logoColor=white)

# Description
The API manages a book library, it exposes endpoints for CRUD operations over a Book table.

#Setup
1. Create the Book table in the database
```sql
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Books](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Title] [text] NULL,
	[Author] [text] NULL,
	[Description] [text] NULL,
 CONSTRAINT [PK_Books] PRIMARY KEY NONCLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
```
2.Clone the repo


3. Update connection string in appsettings.json
```javascript
 "ConnectionStrings": {
    "Default": "Your Connection string"
  }
```
4. Press F5

# Built With
 ASP.NET Core 5.0
 C#

#Author
Patrick Tshibanda
