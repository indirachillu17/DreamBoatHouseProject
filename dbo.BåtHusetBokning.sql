CREATE TABLE [dbo].[BåtHusetBokning] (
    [BåtHusetBokningID] INT            IDENTITY (1, 1) NOT NULL,
    [DiscoverBoatHouse] INT            NOT NULL,
    [BoatStart]         DATETIME2 (7)  NOT NULL,
    [BoatEnd]           DATETIME2 (7)  NOT NULL,
    [OtherActivities]   NVARCHAR (MAX) NULL,
    [Restaurant]        NVARCHAR (MAX) NULL,
    [PriceOfTicket]     DECIMAL (18)   NULL,
    [BoatTripPrice]     DECIMAL (18)   NULL,
    CONSTRAINT [PK_BåtHusetBokning] PRIMARY KEY CLUSTERED ([BåtHusetBokningID] ASC)
);

