CREATE TABLE [dbo].[BåtHusetBokning] (
    [BåtHusetBokningID] INT             IDENTITY (1, 1) NOT NULL,
    [DiscoverBoatHouse] INT             NOT NULL,
    [BoatTripPrice]     DECIMAL (18, 2) NOT NULL,
    [BoatTripDate]      DATETIME2 (7)   NOT NULL,
    [BoatStartTime]     NVARCHAR (MAX)  NULL,
    [BoatEndTime]       NVARCHAR (MAX)  NULL,
    [OtherActivities]   NVARCHAR (MAX)  NULL,
    [ActivitiesTiming]  NVARCHAR (MAX)  NULL,
    [Restaurant]        NVARCHAR (MAX)  NULL,
    [PriceOfTicket]     DECIMAL (18, 2) NOT NULL,
    [Beverages]         NVARCHAR (MAX)  NULL,
    CONSTRAINT [PK_BåtHusetBokning] PRIMARY KEY CLUSTERED ([BåtHusetBokningID] ASC)
);

