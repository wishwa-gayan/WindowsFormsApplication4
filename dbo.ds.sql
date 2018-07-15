CREATE TABLE [dbo].[ds] (
    [Emp_Number]         VARCHAR (50)  NOT NULL,
    [Emp_Name]           VARCHAR (100) NOT NULL,
    [Food]               FLOAT (53)    NOT NULL,
    [Wages]              FLOAT (53)    NOT NULL,
    [Target]             FLOAT (53)    NOT NULL,
    [Total]              FLOAT (53)    NOT NULL,
    [Advance_Pay]        FLOAT (53)    NOT NULL,
    [Day_balnce]         FLOAT (53)    NOT NULL,
    [Comulative_balance] FLOAT (53)    NOT NULL,
    PRIMARY KEY CLUSTERED ([Emp_Number] ASC)
);

