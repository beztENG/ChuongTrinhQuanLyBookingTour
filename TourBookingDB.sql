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
    ProviderID INT,
    FOREIGN KEY (ProviderID) REFERENCES Providers(ProviderID)
);

CREATE TABLE Airlines (
    AirlineID INT PRIMARY KEY IDENTITY(1,1),
    AirlineName NVARCHAR(100) NOT NULL,
    AirlineImage NVARCHAR(255),
    ProviderID INT,
    FOREIGN KEY (ProviderID) REFERENCES Providers(ProviderID)
);


CREATE TABLE FlightBookings (
    FlightBookingID INT PRIMARY KEY IDENTITY(1,1),
    UserID INT NOT NULL,
    FlightID INT NOT NULL,
    BookingDate DATETIME NOT NULL,
    Status VARCHAR(20) DEFAULT 'Active',
    PaymentStatus VARCHAR(20) DEFAULT 'Pending',
    FOREIGN KEY (UserID) REFERENCES Users(UserID),
    FOREIGN KEY (FlightID) REFERENCES Flights(FlightID)
);

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
    ProviderID INT,
    FOREIGN KEY (ProviderID) REFERENCES Providers(ProviderID)
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

INSERT INTO Users (Username, Password, FullName, Email, Phone, Avatar, Role)
VALUES 
('alice123', 'alicepass', 'Alice Johnson', 'alice.johnson@example.com', '1234567890', 'alice_avatar.jpg', 'Customer'),
('bob456', 'bobpass', 'Bob Smith', 'bob.smith@example.com', '2345678901', 'bob_avatar.jpg', 'Customer'),
('charlie789', 'charliepass', 'Charlie Davis', 'charlie.davis@example.com', '3456789012', 'charlie_avatar.jpg', 'Customer'),
('diana999', 'dianapass', 'Diana Moore', 'diana.moore@example.com', '4567890123', 'diana_avatar.jpg', 'HotelProvider'),
('edward007', 'edwardpass', 'Edward Barnes', 'edward.barnes@example.com', '5678901234', 'edward_avatar.jpg', 'FlightProvider'),
('frank999', 'frankpass', 'Frank Thompson', 'frank.thompson@example.com', '6789012345', 'frank_avatar.jpg', 'TourProvider'),
('jane_hotel', 'janepass', 'Jane Doe', 'jane.doe@example.com', '1231231234', 'jane_avatar.jpg', 'HotelProvider'),
('mike_hotel', 'mikepass', 'Mike Johnson', 'mike.johnson@example.com', '3213214321', 'mike_avatar.jpg', 'HotelProvider'),
('susan_flight', 'susanpass', 'Susan Lee', 'susan.lee@example.com', '5551234567', 'susan_avatar.jpg', 'FlightProvider'),
('tom_tour', 'tompass', 'Tom Brown', 'tom.brown@example.com', '5557654321', 'tom_avatar.jpg', 'TourProvider'),
('michael_flight', 'michaelpass', 'Michael Green', 'michael.green@example.com', '5552223333', 'michael_avatar.jpg', 'FlightProvider'),
('linda_tour', 'lindapass', 'Linda Black', 'linda.black@example.com', '5553334444', 'linda_avatar.jpg', 'TourProvider');

INSERT INTO Providers (UserID, ProviderName, ProviderType)
VALUES 
(4, 'Diana Moore', 'HotelProvider'),  
(5, 'Edward Barnes', 'FlightProvider'),  
(6, 'Frank Thompson', 'TourProvider'),
(7, 'Jane Doe', 'HotelProvider'), 
(8, 'Mike Johnson', 'HotelProvider'),
(9, 'Susan Lee', 'FlightProvider'),
(10, 'Tom Brown', 'TourProvider'),
(11, 'Michael Green', 'FlightProvider'),
(12, 'Linda Black', 'TourProvider');

INSERT INTO Hotels (HotelName, HotelImage, Location, Rating, ProviderID)
VALUES 
('Grand Hotel', 'grand_hotel.jpg', 'New York, USA', 4.5, 1),
('Ocean View Resort', 'ocean_view_resort.jpg', 'Malibu, USA', 4.7, 4),
('Mountain Retreat', 'mountain_retreat.jpg', 'Aspen, USA', 4.2, 5);

INSERT INTO Rooms (HotelID, RoomType, BedType, Price)
VALUES
(1, 'Single', 'King', 150.00),
(1, 'Double', 'Queen', 200.00),
(2, 'Suite', 'King', 350.00),
(2, 'Single', 'Twin', 120.00),
(3, 'Double', 'Queen', 180.00),
(3, 'Suite', 'King', 400.00);

INSERT INTO Flights (Airline, Departure, Arrival, DepartureDate, ArrivalDate, TakeOffTime, LandingTime, Cost, AirlineImage, ProviderID)
VALUES 
('Vietnam Airlines', 'Hanoi', 'Ho Chi Minh City', '2025-01-01', '2025-01-05', '09:00', '11:00', 350.00, 'vietnam_airlines.jpg', 2),
('VietJet Air', 'Danang', 'Hanoi', '2025-01-12', '2025-01-15', '14:00', '16:00', 800.00, 'vietjet_air.jpg', 6),
('Bamboo Airways', 'Ho Chi Minh City', 'Phu Quoc', '2025-01-15', '2025-01-20', '07:30', '09:00', 1000.00, 'bamboo_airways.jpg', 8);

INSERT INTO Airlines (AirlineName, AirlineImage, ProviderID)
VALUES 
('Vietnam Airlines', 'vietnam_airlines.jpg', 2),
('VietJet Air', 'vietjet_air.jpg', 6),
('Bamboo Airways', 'bamboo_airways.jpg', 8);


INSERT INTO Tours (TourName, Starting, Destination, StartingDate, ReturnDate, Description, Cost, TourImage, ProviderID)
VALUES 
('Beach Getaway', 'Hanoi', 'Phu Quoc', '2025-05-10', '2025-05-15', 'A relaxing getaway to the sunny beaches of Phu Quoc', 500.00, 'phu_quoc_beach.jpg', 3),
('Mountain Adventure', 'Hanoi', 'Sapa', '2025-06-01', '2025-06-07', 'A thrilling adventure in the beautiful mountains of Sapa', 650.00, 'sapa_mountains.jpg', 7),
('City Explorer', 'Ho Chi Minh City', 'Da Nang', '2025-07-15', '2025-07-20', 'Discover the culture and sights of Da Nang', 400.00, 'danang_city.jpg', 9);


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

select * from Providers
select * from Users
select * from Tours
