CREATE TABLE [dbo].[LocationUser]
(
	[LocationId]	BIGINT		NOT NULL,
	[UserId]		BIGINT		NOT NULL,
	[ts]			ROWVERSION	NOT NULL,
	PRIMARY KEY ([LocationId], [UserId]),
	FOREIGN KEY ([UserId]) REFERENCES [dbo].[User] ([UserId]),
	FOREIGN KEY ([LocationId]) REFERENCES [dbo].[Location] ([LocationId])
);