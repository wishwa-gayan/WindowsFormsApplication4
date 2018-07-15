CREATE TABLE [dbo].[site_controle] (
    [project_number] VARCHAR (50)  NOT NULL,
    [project_name]   VARCHAR (100) NOT NULL,
    [site_code]      VARCHAR (50)  NOT NULL,
    [site_name]      VARCHAR (100) NOT NULL,
    PRIMARY KEY CLUSTERED ([project_number] ASC)
);

