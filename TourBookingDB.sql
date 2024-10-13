-- Create Database
CREATE DATABASE TourBookingDB;
USE TourBookingDB;


CREATE TABLE Users (
    UserID INT PRIMARY KEY IDENTITY(1,1),
    Username NVARCHAR(50) NOT NULL,
    Password NVARCHAR(100) NOT NULL,
    FullName NVARCHAR(100),
    Email NVARCHAR(100),
    Phone NVARCHAR(15),
    Avatar NVARCHAR(30)
);


CREATE TABLE Hotels (
    HotelID INT PRIMARY KEY IDENTITY(1,1),
    HotelName NVARCHAR(100) NOT NULL,
    HotelImage NVARCHAR(255),
    Location NVARCHAR(255),
    Rating DECIMAL(2, 1)
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
    CONSTRAINT chk_airline CHECK (Airline IN ('Vietnam Airlines', 'VietJet Air', 'Bamboo Airways'))
);


CREATE TABLE FlightBookings (
    FlightBookingID INT PRIMARY KEY IDENTITY(1,1),
    UserID INT NOT NULL,
    FlightID INT NOT NULL,
    BookingDate DATETIME NOT NULL,
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
    TourImage NVARCHAR(255) 
);


CREATE TABLE TourBookings (
    TourBookingID INT PRIMARY KEY IDENTITY(1,1),
    TourID INT NOT NULL,
    UserID INT NOT NULL,
    BookingDate DATETIME NOT NULL,
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

INSERT INTO Users (Username, Password, FullName, Email, Phone, Avatar)
VALUES 
('John Doe', '123', 'John Doe', 'john@example.com', '123456789', 'customer Details.png'),
('Jane Doe', '456', 'Jane Doe', 'jane@example.com', '987654321', 'customer Details.png');


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


INSERT INTO Flights (Airline, Departure, Arrival, DepartureDate, ArrivalDate, TakeOffTime, LandingTime, Cost, AirlineImage)
VALUES 
('Vietnam Airlines', 'Hanoi', 'Ho Chi Minh City', '2025-1-1', '2025-1-5', '09:00', '11:00', 350.00, 'vietnam_airlines.jpg'),
('Vietnam Airlines', 'Hanoi', 'Ho Chi Minh City', '2025-1-3', '2025-1-8', '11:00', '13:00', 700.00, 'vietnam_airlines.jpg'),
('VietJet Air', 'Danang', 'Hanoi', '2025-1-12', '2025-1-15', '14:00', '16:00', 800.00, 'vietjet_air.jpg'),
('Bamboo Airways', 'Ho Chi Minh City', 'Phu Quoc', '2025-1-15', '2025-1-20', '07:30', '09:00', 1000.00, 'bamboo_airways.jpg');


INSERT INTO Tours (TourName, Starting, Destination, StartingDate, ReturnDate, Description, Cost, TourImage)
VALUES 
('Beach Getaway', 'Hanoi', 'Phu Quoc', '2025-05-10', '2025-05-15', 'A relaxing getaway to the sunny beaches of Phu Quoc', 500.00, 'phu_quoc_beach.jpg'),
('Mountain Adventure', 'Hanoi', 'Sapa', '2025-06-01', '2025-06-05', 'An adventurous trek through the mountains of Sapa', 400.00, 'sapa_mountains.jpg'),
('Cultural Tour', 'Hanoi', 'Hue', '2025-07-15', '2025-07-20', 'A cultural exploration of the historical city of Hue', 300.00, 'hue_culture.jpg');

select * from Tours
select * from TourBookings
select * from HotelBookings
select * from FlightBookings
select * from Users


ALTER TABLE HotelBookings ADD Status VARCHAR(20) DEFAULT 'Active';


ALTER TABLE FlightBookings ADD Status VARCHAR(20) DEFAULT 'Active';


ALTER TABLE TourBookings ADD Status VARCHAR(20) DEFAULT 'Active';

ALTER TABLE HotelBookings ADD PaymentStatus VARCHAR(20) DEFAULT 'Pending'; 
ALTER TABLE FlightBookings ADD PaymentStatus VARCHAR(20) DEFAULT 'Pending';
ALTER TABLE TourBookings ADD PaymentStatus VARCHAR(20) DEFAULT 'Pending';

Select * from Payments;

Select * from HotelBookings;