CREATE TABLE [dbo].[Andraaktiviteter] (
    [AndraaktiviteterID] INT             IDENTITY (1, 1) NOT NULL,
    [ActivityName]       NVARCHAR (MAX)  NULL,
    [ActivityTime]       NVARCHAR (MAX)  NULL,
    [Price]              DECIMAL (18, 2) NOT NULL,
    CONSTRAINT [PK_Andraaktiviteter] PRIMARY KEY CLUSTERED ([AndraaktiviteterID] ASC)
);

