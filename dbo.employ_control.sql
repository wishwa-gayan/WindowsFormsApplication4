CREATE TABLE [dbo].[employ_control] (
    [emp_numbe]    VARCHAR (50)  NOT NULL,
    [initial]      VARCHAR (50)  NOT NULL,
    [emp_name]     VARCHAR (150) NOT NULL,
    [sex]          VARCHAR (50)  NOT NULL,
    [D_C_B]        NCHAR (10)    NOT NULL,
    [date_of_join] DATE          NOT NULL,
    [nic]          VARCHAR (10)  NOT NULL,
    [div_licen]    VARCHAR (50)  NOT NULL,
    [designation]  VARCHAR (50)  NOT NULL,
    [bankacc]      VARCHAR (50)  NOT NULL,
    [bankname]     VARCHAR (50)  NOT NULL,
    [branch]       VARCHAR (100) NOT NULL,
    [telphone]     VARCHAR (50)  NOT NULL,
    [mobilnumber]  VARCHAR (50)  NOT NULL,
    [email]        VARCHAR (100) NOT NULL,
    [active]       VARCHAR (50)  NOT NULL,
    PRIMARY KEY CLUSTERED ([emp_numbe] ASC)
);

