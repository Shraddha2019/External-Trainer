
CREATE TABLE [dbo].[users] (
    [UserId]     INT          NOT NULL,
    [UserName]   VARCHAR (50) NULL,
    [Password] VARCHAR (50) NULL,
   
    PRIMARY KEY CLUSTERED ([UserId] ASC)
);