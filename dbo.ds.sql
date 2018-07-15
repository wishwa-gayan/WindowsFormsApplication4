CREATE TABLE [dbo].[ds] (
    [Emp_Number]         VARCHAR (50)  NOT NULL,
    [Emp_Name]           VARCHAR (100) NOT NULL,
    [Food]               FLOAT  NOT NULL,
    [Wages]              FLOAT  NOT NULL,
    [Target]             FLOAT  NOT NULL,
    [Total]              FLOAT  NOT NULL,
    [Advance_Pay]        FLOAT  NOT NULL,
    [Day_balnce]         FLOAT  NOT NULL,
    [Comulative_balance] FLOAT  NOT NULL,
    PRIMARY KEY CLUSTERED ([Emp_Number] ASC)
);

