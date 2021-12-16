CREATE TABLE dbo.Movies
(
	Identifier INT IDENTITY NOT NULL PRIMARY KEY,
	Title NVARCHAR(250) NOT NULL,
	CreateDate datetimeoffset not null,
	EditDate datetimeoffset not null
);