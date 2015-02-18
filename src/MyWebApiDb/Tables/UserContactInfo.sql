CREATE TABLE [dbo].[UserContactInfo](
	[UserId] BIGINT NOT NULL,
	[Address1] NVARCHAR (50) NULL,
	[Address2] NVARCHAR (50) NULL,
	[City] NVARCHAR (50) NULL,
	[State] NVARCHAR (50) NULL,
	[Zip] NVARCHAR (50) NULL,
	[Phone] NVARCHAR (50) NULL,
	[ts] ROWVERSION NOT NULL,
	CONSTRAINT [PK_UserContactInfo] PRIMARY KEY ([UserId]),
	FOREIGN KEY ([UserId]) REFERENCES [dbo].[User] (UserId)
);