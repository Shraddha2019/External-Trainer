CREATE TABLE [dbo].[customers] (
    [customerID]       INT           NOT NULL,
    [company]          VARCHAR (MAX) NULL,
    [firstName]        VARCHAR (50)  NULL,
    [lastName]         VARCHAR (50)  NULL,
    [email]            VARCHAR (MAX) NULL,
    [registrationDate] VARCHAR (50)  NULL,
    [fax]              VARCHAR (50)  NULL,
    [state]            VARCHAR (50)  NULL,
    [zip]              INT           NULL,
    [officeCity]       VARCHAR (50)  NULL,
    PRIMARY KEY CLUSTERED ([customerID] ASC)
);



CREATE TABLE [dbo].[employees] (
    [Id]     INT          NOT NULL,
    [Name]   VARCHAR (50) NULL,
    [Gender] VARCHAR (50) NULL,
    [City]   VARCHAR (50) NULL,
    [Email]  VARCHAR (50) NULL,
    [Age]    INT          NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);


CREATE TABLE [dbo].[flowers] (
    [productID]   INT           NOT NULL,
    [title]       VARCHAR (50)  NULL,
    [picture]     VARCHAR (MAX) NULL,
    [category]    VARCHAR (50)  NULL,
    [description] VARCHAR (MAX) NULL,
    [price]       INT           NULL,
    [quantity]    INT           NULL,
    [paymentTerm] VARCHAR (MAX) NULL,
    [delivery]    VARCHAR (MAX) NULL,
    PRIMARY KEY CLUSTERED ([productID] ASC)
);

CREATE TABLE [dbo].[OrderDetails] (
    [Id]        INT   IDENTITY (1, 1) NOT NULL,
    [OrderId]   INT   NULL,
    [ProductId] INT   NULL,
    [Qty]       INT   NULL,
    [UnitPrice] MONEY NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

CREATE TABLE [dbo].[orders] (
    [OrderId]    INT      NOT NULL,
    [OrderDate]  DATETIME NULL,
    [CustomerId] INT      NULL,
    [Amount]     MONEY    NULL,
    PRIMARY KEY CLUSTERED ([OrderId] ASC)
);


CREATE TABLE [dbo].[payments] (
    [PaymentId]   INT          IDENTITY (1, 1) NOT NULL,
    [OrderId]     INT          NULL,
    [PaymentDate] DATETIME     NULL,
    [PaymentMode] VARCHAR (15) NULL,
    [Amount]      MONEY        NULL,
    PRIMARY KEY CLUSTERED ([PaymentId] ASC),
    CONSTRAINT [UK_Payments_OrderId] UNIQUE NONCLUSTERED ([OrderId] ASC)
);


