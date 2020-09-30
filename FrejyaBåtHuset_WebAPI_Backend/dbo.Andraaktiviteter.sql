CREATE TABLE [dbo].[Andraaktiviteter] (
    [AndraaktiviteterID] INT             IDENTITY (1, 1) NOT NULL,
    [OtherActivities]    NVARCHAR (MAX)  NULL,
    [Price]              DECIMAL (18, 2) NOT NULL,
    [NumberOfPersons]    NVARCHAR (MAX)  NULL,
    CONSTRAINT [PK_Andraaktiviteter] PRIMARY KEY CLUSTERED ([AndraaktiviteterID] ASC)
);

