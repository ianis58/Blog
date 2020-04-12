USE blog;

-- Create a new table called 'authors'
-- Drop the table if it already exists
IF OBJECT_ID('authors', 'U') IS NOT NULL
DROP TABLE authors
GO
-- Create the table in the specified schema
CREATE TABLE authors
(
    AuthorId INT NOT NULL PRIMARY KEY, -- primary key column
    FirstName [NVARCHAR](50) NOT NULL,
    LastName [NVARCHAR](50) NOT NULL,
    UserName [NVARCHAR](50) NOT NULL,
    Registered DATETIME NOT NULL
);
GO