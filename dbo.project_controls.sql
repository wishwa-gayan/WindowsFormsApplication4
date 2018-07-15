CREATE TABLE [dbo].[project_controls] (
    [number]       VARCHAR (50)  NOT NULL,
    [project_code] VARCHAR (50)  NOT NULL,
    [project_date] DATE          NOT NULL,
    [project_name] VARCHAR (100) NOT NULL,
    [cust]         VARCHAR (50)  NOT NULL,
    PRIMARY KEY CLUSTERED ([number] ASC)
);

