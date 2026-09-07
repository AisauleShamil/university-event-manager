CREATE TABLE Room (
    RoomId INT IDENTITY(1,1) PRIMARY KEY,
    Name NVARCHAR(100) NOT NULL,
    Capacity INT NOT NULL,
    Building NVARCHAR(100) NOT NULL
);

CREATE TABLE Department (
    DepartmentId INT IDENTITY(1,1) PRIMARY KEY,
    Name NVARCHAR(100) NOT NULL
);

CREATE TABLE Event (
    EventId INT IDENTITY(1,1) PRIMARY KEY,
    Title NVARCHAR(150) NOT NULL,
    Description NVARCHAR(500) NOT NULL,
    EventDate DATETIME NOT NULL,
    RoomId INT NOT NULL,
    DepartmentId INT NOT NULL,
    CONSTRAINT FK_Event_Room FOREIGN KEY (RoomId) REFERENCES Room(RoomId),
    CONSTRAINT FK_Event_Department FOREIGN KEY (DepartmentId) REFERENCES Department(DepartmentId)
);

CREATE TABLE Speaker (
    SpeakerId INT IDENTITY(1,1) PRIMARY KEY,
    FullName NVARCHAR(100) NOT NULL,
    Email NVARCHAR(100) NOT NULL,
    Expertise NVARCHAR(100) NOT NULL
);

CREATE TABLE EventSpeaker (
    EventId INT NOT NULL,
    SpeakerId INT NOT NULL,
    Role NVARCHAR(100) NOT NULL,
    CONSTRAINT PK_EventSpeaker PRIMARY KEY (EventId, SpeakerId),
    CONSTRAINT FK_EventSpeaker_Event FOREIGN KEY (EventId) REFERENCES Event(EventId),
    CONSTRAINT FK_EventSpeaker_Speaker FOREIGN KEY (SpeakerId) REFERENCES Speaker(SpeakerId)
);

CREATE TABLE Participant (
    ParticipantId INT IDENTITY(1,1) PRIMARY KEY,
    FullName NVARCHAR(100) NOT NULL,
    Email NVARCHAR(100) NOT NULL,
    StudentCode NVARCHAR(20) NOT NULL
);

CREATE TABLE Registration (
    RegistrationId INT IDENTITY(1,1) PRIMARY KEY,
    EventId INT NOT NULL,
    ParticipantId INT NOT NULL,
    RegistrationDate DATETIME NOT NULL,
    CONSTRAINT FK_Registration_Event FOREIGN KEY (EventId) REFERENCES Event(EventId),
    CONSTRAINT FK_Registration_Participant FOREIGN KEY (ParticipantId) REFERENCES Participant(ParticipantId)
);

INSERT INTO Room (Name, Capacity, Building) VALUES
('C.510', 40, 'Main Building'),
('E.300', 80, 'East Building'),
('Auditorium A', 150, 'Main Building'),
('Library Room 2', 25, 'Library');

INSERT INTO Department (Name) VALUES
('Communications'),
('Marketing'),
('International Relations'),
('Student Services');

INSERT INTO Speaker (FullName, Email, Expertise) VALUES
('Dr Anna Kovacs', 'anna.kovacs@example.com', 'Marketing'),
('Peter Nagy', 'peter.nagy@example.com', 'Public Relations'),
('Julia Toth', 'julia.toth@example.com', 'Student Recruitment'),
('Mark Szabo', 'mark.szabo@example.com', 'International Communication'),
('Eszter Varga', 'eszter.varga@example.com', 'Event Planning'),
('Daniel Kiss', 'daniel.kiss@example.com', 'Digital Media');

INSERT INTO Participant (FullName, Email, StudentCode) VALUES
('Laura Farkas', 'laura.farkas@example.com', 'ABC123'),
('Mate Horvath', 'mate.horvath@example.com', 'DEF456'),
('Sara Balogh', 'sara.balogh@example.com', 'GHI789'),
('Bence Molnar', 'bence.molnar@example.com', 'JKL012'),
('Emma Lakatos', 'emma.lakatos@example.com', 'MNO345');

INSERT INTO Event (Title, Description, EventDate, RoomId, DepartmentId) VALUES
('Open Day Presentation', 'Introduction for prospective students.', '2026-05-20 10:00', 1, 1),
('Marketing Workshop', 'Practical workshop about university marketing.', '2026-05-21 14:00', 2, 2),
('International Students Meetup', 'Networking event for international students.', '2026-05-22 16:00', 3, 3),
('Career Communication Talk', 'Talk about communication in career planning.', '2026-05-23 11:00', 4, 1),
('Student Services Info Session', 'Information session about student services.', '2026-05-24 09:00', 1, 4);

INSERT INTO EventSpeaker (EventId, SpeakerId, Role) VALUES
(1, 1, 'Keynote speaker'),
(1, 3, 'Presenter'),
(2, 1, 'Workshop leader'),
(2, 6, 'Guest speaker'),
(3, 4, 'Moderator'),
(4, 2, 'Speaker'),
(5, 5, 'Coordinator');

INSERT INTO Registration (EventId, ParticipantId, RegistrationDate) VALUES
(1, 1, '2026-05-01'),
(1, 2, '2026-05-02'),
(2, 3, '2026-05-03'),
(3, 4, '2026-05-04'),
(4, 5, '2026-05-05'),
(5, 1, '2026-05-06');