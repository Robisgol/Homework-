CREATE TABLE Subjects (
    SubjectID INT PRIMARY KEY,
    SubjectName VARCHAR(50)
);

CREATE TABLE Users (
    UserID INT PRIMARY KEY,
    UserName VARCHAR(50)
);

CREATE TABLE UserSubjects (
    UserID INT,
    SubjectID INT,
    PRIMARY KEY (UserID, SubjectID),
    FOREIGN KEY (UserID) REFERENCES Users(UserID),
    FOREIGN KEY (SubjectID) REFERENCES Subjects(SubjectID)
);
