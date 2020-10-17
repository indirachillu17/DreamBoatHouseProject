CREATE TABLE [dbo].[BåtHusetBokningTransaction] (
    [BåtHusetBokningTransactionID] INT             IDENTITY (1, 1) NOT NULL,
    [UserId]                       INT             NOT NULL,
    [DiscoverBoatHouse]            INT             NOT NULL,
    [BoatTripPrice]                DECIMAL (18, 2) NOT NULL,
    [BoatTripDate]                 DATETIME2 (7)   NOT NULL,
    [BoatStartTime]                NVARCHAR (MAX)  NULL,
    [BoatEndTime]                  NVARCHAR (MAX)  NULL,
    [OtherActivities]              NVARCHAR (MAX)  NULL,
    [Restaurant]                   NVARCHAR (MAX)  NULL,
    [Beverages]                    NVARCHAR (MAX)  NULL,
    [NoOfPersons]                  INT             NOT NULL,
    [TotalPrice]                   DECIMAL (18, 2) NOT NULL,
    CONSTRAINT [PK_BåtHusetBokningTransaction] PRIMARY KEY CLUSTERED ([BåtHusetBokningTransactionID] ASC)
);

