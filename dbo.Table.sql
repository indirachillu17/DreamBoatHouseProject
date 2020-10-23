CREATE TABLE [dbo].[FeedBack]
(
    [FeedbackId] INT NOT NULL , 
	[UserId] INT NOT NULL , 
    [OverallExperience] NCHAR(10) NULL, 
    [BestExperience] NCHAR(10) NULL, 
    [AnyAdditionalComments] NCHAR(10) NULL, 
    CONSTRAINT [PK_FeedBack] PRIMARY KEY ([FeedbackId])

)
