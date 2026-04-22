-- Create Database
IF NOT EXISTS (SELECT * FROM sys.databases WHERE name = 'NovelProjectDB')
BEGIN
    CREATE DATABASE NovelProjectDB;
END
GO

USE NovelProjectDB;
GO

-- Create Users Table
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Users')
BEGIN
    CREATE TABLE Users (
        UserId INT PRIMARY KEY IDENTITY(1,1),
        Username NVARCHAR(20) NOT NULL UNIQUE,
        EncryptedPassword NVARCHAR(MAX) NOT NULL,
        AccountCreatedDate DATETIME NOT NULL DEFAULT(SYSDATETIMEOFFSET())
    );
END
GO

-- Create Novels Table
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Novels')
BEGIN
    CREATE TABLE Novels (
        NovelId INT PRIMARY KEY IDENTITY(1,1),
        NovelName NVARCHAR(100) NOT NULL,
        AuthorName NVARCHAR(50) NOT NULL,
        Description NVARCHAR(1000) NOT NULL,
        DatePosted DATETIME NOT NULL DEFAULT(SYSDATETIMEOFFSET()),
        UploadedByUserId INT NOT NULL,
        FOREIGN KEY (UploadedByUserId) REFERENCES Users(UserId)
    );
END
GO

-- Create Chapters Table
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Chapters')
BEGIN
    CREATE TABLE Chapters (
        ChapterId INT PRIMARY KEY IDENTITY(1,1),
        NovelId INT NOT NULL,
        ChapterNumber INT NOT NULL,
        ChapterName NVARCHAR(200) NOT NULL,
        DateAdded DATETIME NOT NULL DEFAULT(SYSDATETIMEOFFSET()),
        FOREIGN KEY (NovelId) REFERENCES Novels(NovelId) ON DELETE CASCADE,
        CONSTRAINT UQ_Novel_Chapter UNIQUE (NovelId, ChapterNumber)
    );
END
GO

-- Create Reviews Table
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Reviews')
BEGIN
    CREATE TABLE Reviews (
        ReviewId INT PRIMARY KEY IDENTITY(1,1),
        UserId INT NOT NULL,
        NovelId INT NOT NULL,
        ReviewContent NVARCHAR(500) NOT NULL,
        Rating DECIMAL(4,2) NOT NULL,
        ReviewPostedDate DATETIME NOT NULL DEFAULT(SYSDATETIMEOFFSET()),
        FOREIGN KEY (UserId) REFERENCES Users(UserId),
        FOREIGN KEY (NovelId) REFERENCES Novels(NovelId) ON DELETE CASCADE,
        CONSTRAINT UQ_User_Novel_Review UNIQUE (UserId, NovelId)
    );
END
GO

-- Create Comments Table
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Comments')
BEGIN
    CREATE TABLE Comments (
        CommentId INT PRIMARY KEY IDENTITY(1,1),
        UserId INT NOT NULL,
        ChapterId INT NOT NULL,
        CommentString NVARCHAR(500) NOT NULL,
        CommentPostedDate DATETIME NOT NULL DEFAULT(SYSDATETIMEOFFSET()),
        FOREIGN KEY (UserId) REFERENCES Users(UserId),
        FOREIGN KEY (ChapterId) REFERENCES Chapters(ChapterId) ON DELETE CASCADE
    );
END
GO

-- Create Tags Table
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Tags')
BEGIN
    CREATE TABLE Tags (
        TagId INT PRIMARY KEY IDENTITY(1,1),
        TagName NVARCHAR(50) NOT NULL UNIQUE,
        TagDescription NVARCHAR(200) NOT NULL
    );
END
GO

-- Create ReadHistories Table
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'ReadHistories')
BEGIN
    CREATE TABLE ReadHistories (
        UserId INT NOT NULL,
        ChapterId INT NOT NULL,
        LastReadDate DATETIME NOT NULL DEFAULT(SYSDATETIMEOFFSET()),
        FOREIGN KEY (UserId) REFERENCES Users(UserId) ON DELETE CASCADE,
        FOREIGN KEY (ChapterId) REFERENCES Chapters(ChapterId) ON DELETE CASCADE
    );
END
GO

-- Create NovelTags Junction Table (Many-to-Many)
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'NovelTags')
BEGIN
    CREATE TABLE NovelTags (
        NovelId INT NOT NULL,
        TagId INT NOT NULL,
        PRIMARY KEY (NovelId, TagId),
        FOREIGN KEY (NovelId) REFERENCES Novels(NovelId) ON DELETE CASCADE,
        FOREIGN KEY (TagId) REFERENCES Tags(TagId) ON DELETE CASCADE
    );
END
GO