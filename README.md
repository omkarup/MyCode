# My Contacts App
The Application created is a MVC Web Api application using entity framework and Ajax jquery
User can perform folowing functionalities:
Add contact
Delete Contact
List contact
Update contact

Not Implemented:
Data Validation, this can be done using javascript of data annotations on the model.

Database created in SQL Server, following is the script:
CREATE TABLE [dbo].[Contacts](
	[ContactId] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [varchar](100) NOT NULL,
	[LastName] [varchar](100) NOT NULL,
	
 CONSTRAINT [PK_Contacts] PRIMARY KEY CLUSTERED 
(
	[ContactId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]


There is one more appraoch this can be done:
Create seperate MVC project with UI and seperate Web Api project
Use HttpClient to consume the web api, host the web api on a server and use the url in base address on Http client.
We can again use get, put, delete and post methods to communicate with data.
