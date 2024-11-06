-- Create Database
DROP DATABASE TourBookingDB;
USE TourBookingDB;

-- Create Users table with Role field
CREATE TABLE Users (
    UserID INT PRIMARY KEY IDENTITY(1,1),
    Username NVARCHAR(50) NOT NULL,
    Password NVARCHAR(100) NOT NULL,
    FullName NVARCHAR(100),
    Email NVARCHAR(100),
    Phone NVARCHAR(15),
    Avatar NVARCHAR(30),
    Role NVARCHAR(20) -- New Role field
);

CREATE TABLE Hotels (
    HotelID INT PRIMARY KEY IDENTITY(1,1),
    HotelName NVARCHAR(100) NOT NULL,
    HotelImage NVARCHAR(255),
    Location NVARCHAR(255),
    Rating DECIMAL(2, 1),
    ProviderID INT,
    FOREIGN KEY (ProviderID) REFERENCES Providers(ProviderID)
);
 

CREATE TABLE Rooms (
    RoomID INT PRIMARY KEY IDENTITY(1,1),
    HotelID INT NOT NULL,
    RoomType NVARCHAR(50) NOT NULL,
    BedType NVARCHAR(50) NOT NULL, 
    Price DECIMAL(10, 2) NOT NULL,
    FOREIGN KEY (HotelID) REFERENCES Hotels(HotelID) ON DELETE CASCADE
);

-- Create HotelBookings table
CREATE TABLE HotelBookings (
    BookingID INT PRIMARY KEY IDENTITY(1,1),
    UserID INT NOT NULL,
    HotelID INT NOT NULL,
    RoomID INT NOT NULL,
    BookingDate DATETIME NOT NULL,
    CheckInDate DATE NOT NULL, 
    Status VARCHAR(20) DEFAULT 'Active', -- Booking Status
    PaymentStatus VARCHAR(20) DEFAULT 'Pending', -- Payment Status
    FOREIGN KEY (UserID) REFERENCES Users(UserID),
    FOREIGN KEY (HotelID) REFERENCES Hotels(HotelID),
    FOREIGN KEY (RoomID) REFERENCES Rooms(RoomID)
);

-- Create Flights table
CREATE TABLE Flights (
    FlightID INT PRIMARY KEY IDENTITY(1,1),
    Airline NVARCHAR(100) NOT NULL, 
    Departure NVARCHAR(100) NOT NULL,
    Arrival NVARCHAR(100) NOT NULL,
    DepartureDate DATE NOT NULL,
    ArrivalDate DATE NOT NULL,
    TakeOffTime TIME NOT NULL,
    LandingTime TIME NOT NULL,
    Cost DECIMAL(10, 2) NOT NULL,
    AirlineImage NVARCHAR(255),
    ProviderID INT, -- Added ProviderID
    FOREIGN KEY (ProviderID) REFERENCES Providers(ProviderID), -- Provider foreign key
    CONSTRAINT chk_airline CHECK (Airline IN ('Vietnam Airlines', 'VietJet Air', 'Bamboo Airways'))
);

-- Create FlightBookings table
CREATE TABLE FlightBookings (
    FlightBookingID INT PRIMARY KEY IDENTITY(1,1),
    UserID INT NOT NULL,
    FlightID INT NOT NULL,
    BookingDate DATETIME NOT NULL,
    Status VARCHAR(20) DEFAULT 'Active', -- Booking Status
    PaymentStatus VARCHAR(20) DEFAULT 'Pending', -- Payment Status
    FOREIGN KEY (UserID) REFERENCES Users(UserID),
    FOREIGN KEY (FlightID) REFERENCES Flights(FlightID)
);

-- Create Tours table
CREATE TABLE Tours (
    TourID INT PRIMARY KEY IDENTITY(1,1),
    TourName NVARCHAR(100) NOT NULL,
    Starting NVARCHAR(100) NOT NULL,
    Destination NVARCHAR(100) NOT NULL,
    StartingDate DATE NOT NULL,
    ReturnDate DATE NOT NULL,
    Description NVARCHAR(MAX),
    Cost DECIMAL(10, 2) NOT NULL,
    TourImage NVARCHAR(255),
    ProviderID INT, -- Added ProviderID
    FOREIGN KEY (ProviderID) REFERENCES Providers(ProviderID) -- Provider foreign key
);

-- Create TourBookings table
CREATE TABLE TourBookings (
    TourBookingID INT PRIMARY KEY IDENTITY(1,1),
    TourID INT NOT NULL,
    UserID INT NOT NULL,
    BookingDate DATETIME NOT NULL,
    Status VARCHAR(20) DEFAULT 'Active', -- Booking Status
    PaymentStatus VARCHAR(20) DEFAULT 'Pending', -- Payment Status
    FOREIGN KEY (TourID) REFERENCES Tours(TourID),
    FOREIGN KEY (UserID) REFERENCES Users(UserID)
);

-- Create Payments table
CREATE TABLE Payments (
    PaymentID INT PRIMARY KEY IDENTITY(1,1),
    UserID INT NOT NULL,
    PaymentDate DATETIME NOT NULL DEFAULT GETDATE(),
    Amount DECIMAL(10, 2) NOT NULL,
    PaymentMethod NVARCHAR(50) NOT NULL,
    BookingID INT NULL,
    BookingType NVARCHAR(20) NOT NULL, -- 'Hotel', 'Flight', 'Tour'
    FOREIGN KEY (UserID) REFERENCES Users(UserID)
);

-- Create Providers table
CREATE TABLE Providers (
    ProviderID INT PRIMARY KEY IDENTITY(1,1),
    UserID INT NOT NULL,
    ProviderName NVARCHAR(100) NOT NULL,
    ProviderType NVARCHAR(20) NOT NULL, -- 'FlightProvider', 'HotelProvider', 'TourProvider'
    FOREIGN KEY (UserID) REFERENCES Users(UserID)
);

select * from users

-- Insert more Users
INSERT INTO Users (Username, Password, FullName, Email, Phone, Avatar, Role)
VALUES 
('alice123', 'alicepass', 'Alice Johnson', 'alice.johnson@example.com', '1234567890', 'alice_avatar.jpg', 'Customer'),
('bob456', 'bobpass', 'Bob Smith', 'bob.smith@example.com', '2345678901', 'bob_avatar.jpg', 'Customer'),
('charlie789', 'charliepass', 'Charlie Davis', 'charlie.davis@example.com', '3456789012', 'charlie_avatar.jpg', 'Customer'),
('diana999', 'dianapass', 'Diana Moore', 'diana.moore@example.com', '4567890123', 'diana_avatar.jpg', 'HotelProvider'),
('edward007', 'edwardpass', 'Edward Barnes', 'edward.barnes@example.com', '5678901234', 'edward_avatar.jpg', 'FlightProvider'),
('frank999', 'frankpass', 'Frank Thompson', 'frank.thompson@example.com', '6789012345', 'frank_avatar.jpg', 'TourProvider'),
('george888', 'georgepass', 'George Wilson', 'george.wilson@example.com', '7890123456', 'george_avatar.jpg', 'Admin');

-- Insert Hotels
INSERT INTO Hotels (HotelName, HotelImage, Location, Rating)
VALUES 
('Grand Hotel', 'grand_hotel.jpg', 'New York, USA', 4.5),
('Ocean View Resort', 'ocean_view_resort.jpg', 'Malibu, USA', 4.7),
('Mountain Retreat', 'mountain_retreat.jpg', 'Aspen, USA', 4.2);

-- Insert Rooms
INSERT INTO Rooms (HotelID, RoomType, BedType, Price)
VALUES
(1, 'Single', 'King', 150.00),
(1, 'Double', 'Queen', 200.00),
(2, 'Suite', 'King', 350.00),
(2, 'Single', 'Twin', 120.00),
(3, 'Double', 'Queen', 180.00),
(3, 'Suite', 'King', 400.00);

-- Insert Flights
INSERT INTO Flights (Airline, Departure, Arrival, DepartureDate, ArrivalDate, TakeOffTime, LandingTime, Cost, AirlineImage)
VALUES 
('Vietnam Airlines', 'Hanoi', 'Ho Chi Minh City', '2025-01-01', '2025-01-05', '09:00', '11:00', 350.00, 'vietnam_airlines.jpg'),
('Vietnam Airlines', 'Hanoi', 'Ho Chi Minh City', '2025-01-03', '2025-01-08', '11:00', '13:00', 700.00, 'vietnam_airlines.jpg'),
('VietJet Air', 'Danang', 'Hanoi', '2025-01-12', '2025-01-15', '14:00', '16:00', 800.00, 'vietjet_air.jpg'),
('Bamboo Airways', 'Ho Chi Minh City', 'Phu Quoc', '2025-01-15', '2025-01-20', '07:30', '09:00', 1000.00, 'bamboo_airways.jpg');

-- Insert Tours
INSERT INTO Tours (TourName, Starting, Destination, StartingDate, ReturnDate, Description, Cost, TourImage)
VALUES 
('Beach Getaway', 'Hanoi', 'Phu Quoc', '2025-05-10', '2025-05-15', 'A relaxing getaway to the sunny beaches of Phu Quoc', 500.00, 'phu_quoc_beach.jpg'),
('Mountain Adventure', 'Hanoi', 'Sapa', '2025-06-01', '2025-06-05', 'An adventurous trek through the mountains of Sapa', 400.00, 'sapa_mountains.jpg'),
('Cultural Tour', 'Hanoi', 'Hue', '2025-07-15', '2025-07-20', 'A cultural exploration of the historical city of Hue', 300.00, 'hue_culture.jpg');

-- Insert Providers who are linked to users from the Users table
INSERT INTO Providers (UserID, ProviderName, ProviderType)
VALUES 
(4, 'Diana Moore', 'HotelProvider'),  -- Diana Moore from Users table is a HotelProvider
(5, 'Edward Barnes', 'FlightProvider'),  -- Edward Barnes is a FlightProvider
(6, 'Frank Thompson', 'TourProvider');   -- Frank Thompson is a TourProvider



-- Check which providers own which hotels
SELECT h.HotelName, p.ProviderName, p.ProviderType
FROM Hotels h
JOIN Providers p ON h.ProviderID = p.ProviderID;

select * from Users
select * from Providers
select * from Hotels
select * from Rooms
select * from Flights
select * from Tours

SELECT h.HotelName, u.FullName AS ProviderName, u.Role
FROM Hotels h
JOIN Providers p ON h.ProviderID = p.ProviderID
JOIN Users u ON p.UserID = u.UserID
WHERE u.Role = 'HotelProvider';


-- Insert new users who will act as hotel providers
INSERT INTO Users (Username, Password, FullName, Email, Phone, Avatar, Role)
VALUES 
('jane_hotel', 'janepass', 'Jane Doe', 'jane.doe@example.com', '1231231234', 'jane_avatar.jpg', 'HotelProvider'),
('mike_hotel', 'mikepass', 'Mike Johnson', 'mike.johnson@example.com', '3213214321', 'mike_avatar.jpg', 'HotelProvider');

-- Insert new providers linked to these users
INSERT INTO Providers (UserID, ProviderName, ProviderType)
VALUES 
((SELECT UserID FROM Users WHERE Username = 'jane_hotel'), 'Jane Doe', 'HotelProvider'), 
((SELECT UserID FROM Users WHERE Username = 'mike_hotel'), 'Mike Johnson', 'HotelProvider');

-- Update the remaining hotels with the correct ProviderID
-- Assume that 'Ocean View Resort' and 'Mountain Retreat' are associated with Jane and Mike respectively
UPDATE Hotels
SET ProviderID = (SELECT ProviderID FROM Providers WHERE ProviderName = 'Jane Doe')
WHERE HotelName = 'Ocean View Resort';

UPDATE Hotels
SET ProviderID = (SELECT ProviderID FROM Providers WHERE ProviderName = 'Mike Johnson')
WHERE HotelName = 'Mountain Retreat';


-- Insert new users who will act as flight and tour providers
INSERT INTO Users (Username, Password, FullName, Email, Phone, Avatar, Role)
VALUES 
('susan_flight', 'susanpass', 'Susan Lee', 'susan.lee@example.com', '5551234567', 'susan_avatar.jpg', 'FlightProvider'),
('tom_tour', 'tompass', 'Tom Brown', 'tom.brown@example.com', '5557654321', 'tom_avatar.jpg', 'TourProvider');


-- Insert new providers linked to these users
INSERT INTO Providers (UserID, ProviderName, ProviderType)
VALUES 
((SELECT UserID FROM Users WHERE Username = 'susan_flight'), 'Susan Lee', 'FlightProvider'), 
((SELECT UserID FROM Users WHERE Username = 'tom_tour'), 'Tom Brown', 'TourProvider');


-- Update flights with Susan Lee as the provider
UPDATE Flights
SET ProviderID = (SELECT ProviderID FROM Providers WHERE ProviderName = 'Susan Lee')
WHERE Airline = 'VietJet Air';  -- Assuming Susan Lee provides flights for VietJet Air

-- Update tours with Tom Brown as the provider
UPDATE Tours
SET ProviderID = (SELECT ProviderID FROM Providers WHERE ProviderName = 'Tom Brown')
WHERE TourName = 'Mountain Adventure';  -- Assuming Tom Brown provides this specific tour


-- Verify flights and their providers
SELECT f.Airline, p.ProviderName AS FlightProvider, u.FullName AS UserFullName
FROM Flights f
JOIN Providers p ON f.ProviderID = p.ProviderID
JOIN Users u ON p.UserID = u.UserID;

-- Verify tours and their providers
SELECT t.TourName, p.ProviderName AS TourProvider, u.FullName AS UserFullName
FROM Tours t
JOIN Providers p ON t.ProviderID = p.ProviderID
JOIN Users u ON p.UserID = u.UserID;


-- Insert new users who will act as another tour and flight provider
INSERT INTO Users (Username, Password, FullName, Email, Phone, Avatar, Role)
VALUES 
('michael_flight', 'michaelpass', 'Michael Green', 'michael.green@example.com', '5552223333', 'michael_avatar.jpg', 'FlightProvider'),
('linda_tour', 'lindapass', 'Linda Black', 'linda.black@example.com', '5553334444', 'linda_avatar.jpg', 'TourProvider');


-- Insert new providers linked to these users
INSERT INTO Providers (UserID, ProviderName, ProviderType)
VALUES 
((SELECT UserID FROM Users WHERE Username = 'michael_flight'), 'Michael Green', 'FlightProvider'), 
((SELECT UserID FROM Users WHERE Username = 'linda_tour'), 'Linda Black', 'TourProvider');


-- Update an additional flight with Michael Green as the provider
UPDATE Flights
SET ProviderID = (SELECT ProviderID FROM Providers WHERE ProviderName = 'Michael Green')
WHERE Airline = 'Bamboo Airways';  -- Assuming Michael Green provides flights for Bamboo Airways

-- Update an additional tour with Linda Black as the provider
UPDATE Tours
SET ProviderID = (SELECT ProviderID FROM Providers WHERE ProviderName = 'Linda Black')
WHERE TourName = 'Cultural Tour';  -- Assuming Linda Black provides this specific tour


