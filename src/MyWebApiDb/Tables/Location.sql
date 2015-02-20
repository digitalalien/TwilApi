CREATE TABLE [dbo].[Location]
(
	[LocationId]	BIGINT IDENTITY	(1, 1)	NOT NULL,
	[LocationName]	NVARCHAR		(50)	NOT NULL,
	[Address1]		NVARCHAR		(50)	NULL,
	[Address2]		NVARCHAR		(50)	NULL,
	[City]			NVARCHAR		(50)	NULL,
	[State]			NVARCHAR		(50)	NULL,
	[Zip]			INT						NULL,
	[CreatedUserId]	BIGINT					NOT NULL,
	[ts]			ROWVERSION				NOT NULL,
	PRIMARY KEY CLUSTERED ([LocationId] ASC),
	FOREIGN KEY ([CreatedUserId]) REFERENCES [dbo].[User] ([UserId])
	 
);