CREATE TABLE [dbo].[customer_control] (
    [number]        VARCHAR (50)  NOT NULL,
    [customer_name] VARCHAR (100) NOT NULL,
    [address]       VARCHAR (250) NOT NULL,
    [tel]           VARCHAR (50)  NOT NULL,
    [mobil]         VARCHAR (50)  NOT NULL,
    [fax]           VARCHAR (100) NOT NULL,
    [email]         VARCHAR (100) NOT NULL,
    PRIMARY KEY CLUSTERED ([number] ASC)
);

