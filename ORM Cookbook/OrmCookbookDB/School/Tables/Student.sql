﻿CREATE TABLE School.Student
(
    StudentId INT NOT NULL IDENTITY(1000, 1)
        CONSTRAINT PK_Student PRIMARY KEY,
    Name NVARCHAR(50) NOT NULL,
    Subject NVARCHAR(50) NOT NULL,
    SchoolId INT NOT NULL
);
