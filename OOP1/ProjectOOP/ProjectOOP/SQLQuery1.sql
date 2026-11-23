
-- =============================================
-- PROJECTOOP BARANGAY ELECTION SIMULATION
-- SQL SERVER LOCALDB
-- =============================================

-- CREATE DATABASE
IF DB_ID('BarangayElectionDB') IS NULL
BEGIN
    CREATE DATABASE BarangayElectionDB;
END;
GO

USE BarangayElectionDB;
GO

-- =============================================
-- TABLE 1: CANDIDATES
-- =============================================

IF OBJECT_ID('dbo.Candidates', 'U') IS NULL
BEGIN
    CREATE TABLE dbo.Candidates
    (
        CandidateID INT IDENTITY(1,1) PRIMARY KEY,
        CandidateName NVARCHAR(100) NOT NULL,
        Position NVARCHAR(100) NOT NULL,
        Platform NVARCHAR(500) NULL
    );
END;
GO

-- Add Platform column if using an older table
IF COL_LENGTH('dbo.Candidates', 'Platform') IS NULL
BEGIN
    ALTER TABLE dbo.Candidates
    ADD Platform NVARCHAR(500) NULL;
END;
GO

-- =============================================
-- TABLE 2: VOTERS
-- =============================================

IF OBJECT_ID('dbo.Voters', 'U') IS NULL
BEGIN
    CREATE TABLE dbo.Voters
    (
        VoterID INT IDENTITY(1,1) PRIMARY KEY,
        VoterName NVARCHAR(100) NOT NULL,
        HasVoted BIT NOT NULL DEFAULT 0
    );
END;
GO

-- =============================================
-- TABLE 3: VOTES
-- =============================================

IF OBJECT_ID('dbo.Votes', 'U') IS NULL
BEGIN
    CREATE TABLE dbo.Votes
    (
        VoteID INT IDENTITY(1,1) PRIMARY KEY,
        VoterID INT NOT NULL UNIQUE,
        CandidateID INT NOT NULL,
        DateVoted DATETIME2 NOT NULL
            DEFAULT SYSDATETIME(),

        CONSTRAINT FK_Votes_Voters
            FOREIGN KEY (VoterID)
            REFERENCES dbo.Voters(VoterID),

        CONSTRAINT FK_Votes_Candidates
            FOREIGN KEY (CandidateID)
            REFERENCES dbo.Candidates(CandidateID)
    );
END;
GO

PRINT 'Database and tables created successfully!';
GO

USE BarangayElectionDB;
GO

DECLARE @Voters TABLE
(
    VoterID INT PRIMARY KEY,
    VoterName NVARCHAR(100)
);

INSERT INTO @Voters VALUES
(1, 'Maria Santos'),
(2, 'Jose Reyes'),
(3, 'Ana Cruz'),
(4, 'Luis Garcia'),
(5, 'Carla Mendoza'),
(6, 'Paolo Ramos'),
(7, 'Liza Aquino'),
(8, 'Miguel Torres'),
(9, 'Rosa Bautista'),
(10, 'Daniel Navarro');

-- Update existing sample records
UPDATE v
SET v.VoterName = s.VoterName
FROM dbo.Voters v
INNER JOIN @Voters s
    ON v.VoterID = s.VoterID;

-- Insert missing records with their intended IDs
IF EXISTS (
    SELECT 1 FROM @Voters s
    WHERE NOT EXISTS (
        SELECT 1 FROM dbo.Voters v
        WHERE v.VoterID = s.VoterID
    )
)
BEGIN
    SET IDENTITY_INSERT dbo.Voters ON;

    INSERT INTO dbo.Voters (VoterID, VoterName)
    SELECT s.VoterID, s.VoterName
    FROM @Voters s
    WHERE NOT EXISTS (
        SELECT 1 FROM dbo.Voters v
        WHERE v.VoterID = s.VoterID
    );

    SET IDENTITY_INSERT dbo.Voters OFF;
END;

-- Verify voters
SELECT
    VoterID,
    'V-' + RIGHT('000' +
        CAST(VoterID AS VARCHAR(10)), 3)
        AS VoterCode,
    VoterName,
    CASE
        WHEN HasVoted = 1 THEN 'Voted'
        ELSE 'Not Voted'
    END AS VotingStatus
FROM dbo.Voters
ORDER BY VoterID;
GO
