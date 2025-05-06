CREATE TABLE Jordfugtighed (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    JordfugtighedValue INT NOT NULL CHECK (JordfugtighedValue >= 0)
);

