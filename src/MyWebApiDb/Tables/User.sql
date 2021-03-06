﻿CREATE TABLE [dbo].[User](
	[UserId] BIGINT IDENTITY (1, 1) NOT NULL,
	[FirstName] NVARCHAR (50) NOT NULL,
	[LastName] NVARCHAR (50) NOT NULL,
	[Username] NVARCHAR (50) NOT NULL,
	[Password] NVARCHAR (50) NOT NULL,
	[CreatedDate] DATETIME2  (7) NOT NULL,
	[ts] ROWVERSION NOT NULL,
	CONSTRAINT [PK_User] PRIMARY KEY ([UserId])
);