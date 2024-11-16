CREATE DATABASE TourBookingDB;
USE TourBookingDB;

CREATE TABLE Users (
    UserID INT PRIMARY KEY IDENTITY(1,1),
    Username NVARCHAR(50) NOT NULL,
    Password NVARCHAR(100) NOT NULL,
    FullName NVARCHAR(100),
    Email NVARCHAR(100),
    Phone NVARCHAR(15),
    Avatar NVARCHAR(30),
    Role NVARCHAR(20)
);

CREATE TABLE Providers (
    ProviderID INT PRIMARY KEY IDENTITY(1,1),
    UserID INT NOT NULL,
    ProviderName NVARCHAR(100) NOT NULL,
    ProviderType NVARCHAR(20) NOT NULL,
    FOREIGN KEY (UserID) REFERENCES Users(UserID)
);

CREATE TABLE Hotels (
    HotelID INT PRIMARY KEY IDENTITY(1,1),
    HotelName NVARCHAR(100) NOT NULL,
    HotelImage NVARCHAR(255),
    Location NVARCHAR(255),
    Rating DECIMAL(2, 1),
);

CREATE TABLE Rooms (
    RoomID INT PRIMARY KEY IDENTITY(1,1),
    HotelID INT NOT NULL,
    RoomType NVARCHAR(50) NOT NULL,
    BedType NVARCHAR(50) NOT NULL, 
    Price DECIMAL(10, 2) NOT NULL,
    FOREIGN KEY (HotelID) REFERENCES Hotels(HotelID) ON DELETE CASCADE
);

CREATE TABLE HotelBookings (
    BookingID INT PRIMARY KEY IDENTITY(1,1),
    UserID INT NOT NULL,
    HotelID INT NOT NULL,
    RoomID INT NOT NULL,
    BookingDate DATETIME NOT NULL,
    CheckInDate DATE NOT NULL, 
    Status VARCHAR(20) DEFAULT 'Active',
    PaymentStatus VARCHAR(20) DEFAULT 'Pending',
    FOREIGN KEY (UserID) REFERENCES Users(UserID),
    FOREIGN KEY (HotelID) REFERENCES Hotels(HotelID),
    FOREIGN KEY (RoomID) REFERENCES Rooms(RoomID)
);
CREATE TABLE Airlines (
    AirlineID INT PRIMARY KEY IDENTITY(1,1),
    AirlineName NVARCHAR(100) NOT NULL,
    AirlineImage NVARCHAR(255),
);

CREATE TABLE Flights (
    FlightID INT PRIMARY KEY IDENTITY(1,1),
	AirlineID INT NOT NULL,
    Departure NVARCHAR(100) NOT NULL,
    Arrival NVARCHAR(100) NOT NULL,
    DepartureDate DATE NOT NULL,
    ArrivalDate DATE NOT NULL,
    TakeOffTime TIME NOT NULL,
    LandingTime TIME NOT NULL,
    Cost DECIMAL(10, 2) NOT NULL,
    FlightImage NVARCHAR(255),
	FOREIGN KEY (AirlineID) REFERENCES Airlines(AirlineID),
);


CREATE TABLE FlightBookings (
    FlightBookingID INT PRIMARY KEY IDENTITY(1,1),
    UserID INT NOT NULL,
    FlightID INT NOT NULL,
    BookingDate DATETIME NOT NULL,
    Status VARCHAR(20) DEFAULT 'Active',
    PaymentStatus VARCHAR(20) DEFAULT 'Pending',
    FOREIGN KEY (UserID) REFERENCES Users(UserID),
    FOREIGN KEY (FlightID) REFERENCES Flights(FlightID),
);

CREATE TABLE CompanyTours(
	CompanyID INT PRIMARY KEY IDENTITY(1,1),
	CompanyName NVARCHAR(100) NOT NULL,
	CompanyImage NVARCHAR(255),
);
CREATE TABLE Tours (
    TourID INT PRIMARY KEY IDENTITY(1,1),
	CompanyID INT NOT NULL,
    TourName NVARCHAR(100) NOT NULL,
    Starting NVARCHAR(100) NOT NULL,
    Destination NVARCHAR(100) NOT NULL,
    StartingDate DATE NOT NULL,
    ReturnDate DATE NOT NULL,
    Description NVARCHAR(MAX),
    Cost DECIMAL(10, 2) NOT NULL,
    TourImage NVARCHAR(255),
	FOREIGN KEY (CompanyID) REFERENCES CompanyTours(CompanyID)
);

CREATE TABLE TourBookings (
    TourBookingID INT PRIMARY KEY IDENTITY(1,1),
    TourID INT NOT NULL,
    UserID INT NOT NULL,
    BookingDate DATETIME NOT NULL,
    Status VARCHAR(20) DEFAULT 'Active',
    PaymentStatus VARCHAR(20) DEFAULT 'Pending',
    FOREIGN KEY (TourID) REFERENCES Tours(TourID),
    FOREIGN KEY (UserID) REFERENCES Users(UserID)
);

CREATE TABLE Payments (
    PaymentID INT PRIMARY KEY IDENTITY(1,1),
    UserID INT NOT NULL,
    PaymentDate DATETIME NOT NULL DEFAULT GETDATE(),
    Amount DECIMAL(10, 2) NOT NULL,
    PaymentMethod NVARCHAR(50) NOT NULL,
    BookingID INT NULL,
    BookingType NVARCHAR(20) NOT NULL,
    FOREIGN KEY (UserID) REFERENCES Users(UserID)
);

CREATE TABLE HotelEmployees (
    EmployeeID INT PRIMARY KEY IDENTITY(1,1),
    UserID INT NOT NULL,
    HotelID INT NOT NULL,
    FOREIGN KEY (UserID) REFERENCES Users(UserID),
    FOREIGN KEY (HotelID) REFERENCES Hotels(HotelID)
);

CREATE TABLE AirlineEmployees (
    EmployeeID INT PRIMARY KEY IDENTITY(1,1),
    UserID INT NOT NULL,
    AirlineID INT NOT NULL,
    FOREIGN KEY (UserID) REFERENCES Users(UserID),
    FOREIGN KEY (AirlineID) REFERENCES Airlines(AirlineID)
);

CREATE TABLE CompanyTourEmployees (
    EmployeeID INT PRIMARY KEY IDENTITY(1,1),
    UserID INT NOT NULL,
    CompanyID INT NOT NULL,
    FOREIGN KEY (UserID) REFERENCES Users(UserID),
    FOREIGN KEY (CompanyID) REFERENCES CompanyTours(CompanyID)
);


INSERT INTO Users (Username, Password, FullName, Email, Phone, Avatar, Role)
VALUES 
('alice123', 'alicepass', 'Alice Johnson', 'alice.johnson@example.com', '1234567890', 'alice_avatar.jpg', 'Customer'),
('bob456', 'bobpass', 'Bob Smith', 'bob.smith@example.com', '2345678901', 'bob_avatar.jpg', 'Customer'),
('charlie789', 'charliepass', 'Charlie Davis', 'charlie.davis@example.com', '3456789012', 'charlie_avatar.jpg', 'Customer'),
('diana999', 'dianapass', 'Diana Moore', 'diana.moore@example.com', '4567890123', 'diana_avatar.jpg', 'HotelProvider'),
('edward007', 'edwardpass', 'Edward Barnes', 'edward.barnes@example.com', '5678901234', 'edward_avatar.jpg', 'AirlineProvider'),
('frank999', 'frankpass', 'Frank Thompson', 'frank.thompson@example.com', '6789012345', 'frank_avatar.jpg', 'CompanyTourProvider'),
('jane_hotel', 'janepass', 'Jane Doe', 'jane.doe@example.com', '1231231234', 'jane_avatar.jpg', 'HotelProvider'),
('mike_hotel', 'mikepass', 'Mike Johnson', 'mike.johnson@example.com', '3213214321', 'mike_avatar.jpg', 'HotelProvider'),
('susan_flight', 'susanpass', 'Susan Lee', 'susan.lee@example.com', '5551234567', 'susan_avatar.jpg', 'AirlineProvider'),
('tom_tour', 'tompass', 'Tom Brown', 'tom.brown@example.com', '5557654321', 'tom_avatar.jpg', 'CompanyTourProvider'),
('michael_flight', 'michaelpass', 'Michael Green', 'michael.green@example.com', '5552223333', 'michael_avatar.jpg', 'AirlineProvider'),
('linda_tour', 'lindapass', 'Linda Black', 'linda.black@example.com', '5553334444', 'linda_avatar.jpg', 'CompanyTourProvider'),
('admin', 'admin', 'Admin', 'admin@example.com', '1234567890', 'Admin.jpg', 'Admin');

INSERT INTO Providers (UserID, ProviderName, ProviderType)
VALUES 
(4, 'Diana Moore', 'HotelProvider'),  
(5, 'Edward Barnes', 'AirlineProvider'),  
(6, 'Frank Thompson', 'CompanyTourProvider'),
(7, 'Jane Doe', 'HotelProvider'), 
(8, 'Mike Johnson', 'HotelProvider'),
(9, 'Susan Lee', 'AirlineProvider'),
(10, 'Tom Brown', 'CompanyTourProvider'),
(11, 'Michael Green', 'AirlineProvider'),
(12, 'Linda Black', 'CompanyTourProvider');

INSERT INTO Hotels (HotelName, HotelImage, Location, Rating)
VALUES 
('Grand Hotel', 'grand_hotel.jpg', 'New York, USA', 4.5),
('Ocean View Resort', 'ocean_view_resort.jpg', 'Malibu, USA', 4.7),
('Mountain Retreat', 'mountain_retreat.jpg', 'Aspen, USA', 4.2);

INSERT INTO Rooms (HotelID, RoomType, BedType, Price)
VALUES
(1, 'Single', 'King', 150.00),
(1, 'Double', 'Queen', 200.00),
(2, 'Suite', 'King', 350.00),
(2, 'Single', 'Twin', 120.00),
(3, 'Double', 'Queen', 180.00),
(3, 'Suite', 'King', 400.00);

INSERT INTO Airlines (AirlineName, AirlineImage)
VALUES 
('Vietnam Airlines', 'vietnam_airlines.jpg'),
('VietJet Air', 'vietjet_air.jpg'),
('Bamboo Airways', 'bamboo_airways.jpg');

INSERT INTO Flights (AirlineID, Departure, Arrival, DepartureDate, ArrivalDate, TakeOffTime, LandingTime, Cost, FlightImage)
VALUES 
(1, 'Hanoi', 'Ho Chi Minh City', '2025-1-1', '2025-1-5', '09:00', '11:00', 350.00, 'vietnam_airlines.jpg'),
(1, 'Hanoi', 'Ho Chi Minh City', '2025-1-3', '2025-1-8', '11:00', '13:00', 700.00, 'vietnam_airlines.jpg'),
(2, 'Danang', 'Hanoi', '2025-1-12', '2025-1-15', '14:00', '16:00', 800.00, 'vietjet_air.jpg'),
(3, 'Ho Chi Minh City', 'Phu Quoc', '2025-1-15', '2025-1-20', '07:30', '09:00', 1000.00, 'bamboo_airways.jpg'),
(1, 'Hanoi', 'Ho Chi Minh City', '2024-11-01', '2024-11-01', '08:00', '10:00', 1500.00, 'vietnam_airlines.jpg'),
(1, 'Ho Chi Minh City', 'Hanoi', '2024-11-05', '2024-11-05', '09:00', '11:00', 1500.00, 'vietnam_airlines.jpg'),
(1, 'Hanoi', 'Danang', '2024-11-03', '2024-11-03', '13:00', '14:30', 1000.00, 'vietnam_airlines.jpg'),
(1, 'Danang', 'Ho Chi Minh City', '2024-11-04', '2024-11-04', '15:00', '17:00', 1300.00, 'vietnam_airlines.jpg'),
(2, 'Hanoi', 'Phu Quoc', '2024-11-02', '2024-11-02', '06:30', '09:00', 1200.00, 'vietjet_air.jpg'),
(2, 'Phu Quoc', 'Hanoi', '2024-11-06', '2024-11-06', '10:00', '12:30', 1200.00, 'vietjet_air.jpg'),
(3, 'Hanoi', 'Ho Chi Minh City', '2024-11-13', '2024-11-13', '19:00', '21:00', 1600.00, 'bamboo_airways.jpg'),
(3, 'Danang', 'Phu Quoc', '2024-11-14', '2024-11-14', '17:00', '19:30', 1400.00, 'bamboo_airways.jpg');


INSERT INTO CompanyTours (CompanyName, CompanyImage)
VALUES 
('Sunny Travel', 'sunny_travel.jpg'),
('Adventure World', 'adventure_world.jpg'),
('Cityscape Tours', 'cityscape_tours.jpg');

INSERT INTO Tours (CompanyID, TourName, Starting, Destination, StartingDate, ReturnDate, Description, Cost, TourImage)
VALUES 
(1, 'Beach Getaway', 'Hanoi', 'Phu Quoc', '2025-05-10', '2025-05-15', 'A relaxing getaway to the sunny beaches of Phu Quoc', 500.00, 'phu_quoc_beach.jpg'),
(2, 'Mountain Adventure', 'Hanoi', 'Sapa', '2025-06-01', '2025-06-07', 'A thrilling adventure in the beautiful mountains of Sapa', 650.00, 'sapa_mountains.jpg'),
(3, 'City Explorer', 'Ho Chi Minh City', 'Da Nang', '2025-07-15', '2025-07-20', 'Discover the culture and sights of Da Nang', 400.00, 'danang_city.jpg');

INSERT INTO HotelEmployees (UserID, HotelID)
VALUES (
    (SELECT UserID FROM Users WHERE FullName = 'Diana Moore' AND Role = 'HotelProvider'), 
    1 
);

INSERT INTO HotelEmployees (UserID, HotelID)
VALUES (
    (SELECT UserID FROM Users WHERE FullName = 'Jane Doe' AND Role = 'HotelProvider'), 
    2
);

INSERT INTO HotelEmployees (UserID, HotelID)
VALUES (
    (SELECT UserID FROM Users WHERE FullName = 'Mike Johnson' AND Role = 'HotelProvider'), 
    3
);

INSERT INTO AirlineEmployees (UserID, AirlineID)
VALUES (
    (SELECT UserID FROM Users WHERE FullName = 'Edward Barnes' AND Role = 'AirlineProvider'), 
    1
);

INSERT INTO AirlineEmployees (UserID, AirlineID)
VALUES (
    (SELECT UserID FROM Users WHERE FullName = 'Susan Lee' AND Role = 'AirlineProvider'), 
    2
);

INSERT INTO AirlineEmployees (UserID, AirlineID)
VALUES (
    (SELECT UserID FROM Users WHERE FullName = 'Michael Green' AND Role = 'AirlineProvider'), 
    3
);


INSERT INTO CompanyTourEmployees (UserID, CompanyID)
VALUES (
    (SELECT UserID FROM Users WHERE FullName = 'Frank Thompson' AND Role = 'CompanyTourProvider'), 
    1
);

INSERT INTO CompanyTourEmployees (UserID, CompanyID)
VALUES (
    (SELECT UserID FROM Users WHERE FullName = 'Tom Brown' AND Role = 'CompanyTourProvider'), 
    2
);


INSERT INTO CompanyTourEmployees (UserID, CompanyID)
VALUES (
    (SELECT UserID FROM Users WHERE FullName = 'Linda Black' AND Role = 'CompanyTourProvider'), 
    3
);


SELECT u.FullName, h.HotelName 
FROM HotelEmployees he
JOIN Users u ON he.UserID = u.UserID
JOIN Hotels h ON he.HotelID = h.HotelID

SELECT u.FullName, a.AirlineName
FROM AirlineEmployees ae
JOIN Users u ON ae.UserID = u.UserID
JOIN Airlines a ON ae.AirlineID = a.AirlineID;

SELECT u.FullName, ct.CompanyName
FROM CompanyTourEmployees cte
JOIN Users u ON cte.UserID = u.UserID
JOIN CompanyTours ct ON cte.CompanyID = ct.CompanyID;


ALTER TABLE Rooms
ADD status BIT DEFAULT 1;

UPDATE Rooms
SET status = 1;

ALTER TABLE Flights
ADD status BIT DEFAULT 1;

Update Flights
Set status = 1;


ALTER TABLE Tours
ADD status BIT DEFAULT 1;

Update Tours
Set status = 1;
ALTER TABLE Users ADD IsLoggedIn BIT DEFAULT 0;
UPDATE Users SET IsLoggedIn = 0 WHERE UserID = 13
SELECT Username, Role FROM Users WHERE IsLoggedIn = 1
select * from Providers
select * from Users
select * from Rooms
select * from Hotels
select * from Tours
select * from Flights
select * from AirlineEmployees
select * from HotelEmployees
select * from CompanyTourEmployees
