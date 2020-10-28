CREATE TABLE [dbo].[FeedBack] (
    [FeedbackId]            INT            IDENTITY (1, 1) NOT NULL,
    [UserId]                INT            NOT NULL,
    [OverallExperience]     NVARCHAR (MAX) NULL,
    [BestExperience]        NVARCHAR (MAX) NULL,
    [AnyAdditionalComments] NVARCHAR (MAX) NULL,
    CONSTRAINT [PK_FeedBack] PRIMARY KEY CLUSTERED ([FeedbackId])
);

