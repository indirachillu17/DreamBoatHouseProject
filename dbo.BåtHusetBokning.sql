CREATE TABLE [dbo].[BåtHusetBokning] (
    [BåtHusetBokningID] INT            IDENTITY (1, 1) NOT NULL,
    [DiscoverBoatHouse] INT            NOT NULL,
    [BoatStart]         DATETIME2 (7)  NOT NULL,
    [BoatEnd]           DATETIME2 (7)  NOT NULL,
    [
	]  NVARCHAR (MAX) NULL,
    [OtherActivities]   NVARCHAR (MAX) NULL,
    [Restaurant]        NVARCHAR (MAX) NULL,
    CONSTRAINT [PK_BåtHusetBokning] PRIMARY KEY CLUSTERED ([BåtHusetBokningID] ASC)
);

