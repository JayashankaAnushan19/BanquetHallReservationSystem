-- phpMyAdmin SQL Dump
-- version 4.8.0.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Apr 10, 2019 at 05:55 PM
-- Server version: 10.1.32-MariaDB
-- PHP Version: 7.2.5

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `db_banquethallsreservationsystem`
--

-- --------------------------------------------------------

--
-- Table structure for table `customer`
--

CREATE TABLE `customer` (
  `customer_id` varchar(15) NOT NULL,
  `customer_name` varchar(45) DEFAULT NULL,
  `customer_tel` varchar(11) DEFAULT NULL,
  `customer_email` varchar(60) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `customer`
--

INSERT INTO `customer` (`customer_id`, `customer_name`, `customer_tel`, `customer_email`) VALUES
('1', 'Jayashanka Anushan', '0774561343', 'jmaxut@gmail.com'),
('123', 'Jak', '000000', 'index@gmail.com'),
('2', 'Unbelievable man', '0000000', 'jmaxut@gmail.com'),
('982232929V', 'Jayashanka Anushan', '0774561343', 'Jmaxut@gmail.com'),
('CusID', 'CusName', '0000', 'CusMail');

-- --------------------------------------------------------

--
-- Table structure for table `hall`
--

CREATE TABLE `hall` (
  `hall_id` int(10) NOT NULL,
  `hall_name` varchar(25) COLLATE utf8_general_mysql500_ci NOT NULL,
  `hall_location` varchar(25) COLLATE utf8_general_mysql500_ci NOT NULL,
  `hall_numberofguest` int(10) NOT NULL,
  `hall_status` varchar(10) COLLATE utf8_general_mysql500_ci NOT NULL,
  `hotel_name` varchar(50) COLLATE utf8_general_mysql500_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_mysql500_ci;

--
-- Dumping data for table `hall`
--

INSERT INTO `hall` (`hall_id`, `hall_name`, `hall_location`, `hall_numberofguest`, `hall_status`, `hotel_name`) VALUES
(6, 'Name1', 'Location1', 101, 'Pending', 'BallPass'),
(9, 'HallName', 'HallLocation', 10, 'Pending', 'HotelName');

-- --------------------------------------------------------

--
-- Table structure for table `hotel`
--

CREATE TABLE `hotel` (
  `hotel_id` int(11) NOT NULL,
  `hotel_name` varchar(25) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `hotel`
--

INSERT INTO `hotel` (`hotel_id`, `hotel_name`) VALUES
(14, 'BallPass'),
(15, 'NoneHotel'),
(16, 'GoatPass'),
(17, 'NoneAC'),
(18, 'JoakBan'),
(19, 'HotelName'),
(20, 'JS Hotel Pvt Ltd');

-- --------------------------------------------------------

--
-- Table structure for table `login`
--

CREATE TABLE `login` (
  `login_id` int(11) NOT NULL,
  `login_username` varchar(45) NOT NULL,
  `login_password` varchar(45) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `login`
--

INSERT INTO `login` (`login_id`, `login_username`, `login_password`) VALUES
(1, 'Admin', 'Admin');

-- --------------------------------------------------------

--
-- Table structure for table `reservation`
--

CREATE TABLE `reservation` (
  `reservation_id` int(10) NOT NULL,
  `reservation_location` varchar(25) COLLATE utf8_general_mysql500_ci NOT NULL,
  `reservation_status` varchar(10) COLLATE utf8_general_mysql500_ci NOT NULL,
  `reservation_numberofguest` int(10) NOT NULL,
  `reservation_date` varchar(10) COLLATE utf8_general_mysql500_ci NOT NULL,
  `hotel_id` varchar(15) COLLATE utf8_general_mysql500_ci NOT NULL,
  `customer_id` varchar(15) COLLATE utf8_general_mysql500_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_mysql500_ci;

--
-- Dumping data for table `reservation`
--

INSERT INTO `reservation` (`reservation_id`, `reservation_location`, `reservation_status`, `reservation_numberofguest`, `reservation_date`, `hotel_id`, `customer_id`) VALUES
(35, 'HallLocation', 'Checked', 10, '2019-04-01', '', '2'),
(37, 'HallLocation', 'Pending', 111, '2019-04-04', '', '1'),
(38, 'HallLocation', 'Pending', 144, '2019-04-04', '', '1'),
(39, 'Location1', 'Pending', 100, '2019-04-04', '', '1');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `customer`
--
ALTER TABLE `customer`
  ADD PRIMARY KEY (`customer_id`);

--
-- Indexes for table `hall`
--
ALTER TABLE `hall`
  ADD PRIMARY KEY (`hall_id`);

--
-- Indexes for table `hotel`
--
ALTER TABLE `hotel`
  ADD PRIMARY KEY (`hotel_id`),
  ADD KEY `hotel_id` (`hotel_id`) USING BTREE;

--
-- Indexes for table `login`
--
ALTER TABLE `login`
  ADD PRIMARY KEY (`login_id`);

--
-- Indexes for table `reservation`
--
ALTER TABLE `reservation`
  ADD PRIMARY KEY (`reservation_id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `hall`
--
ALTER TABLE `hall`
  MODIFY `hall_id` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- AUTO_INCREMENT for table `hotel`
--
ALTER TABLE `hotel`
  MODIFY `hotel_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=21;

--
-- AUTO_INCREMENT for table `login`
--
ALTER TABLE `login`
  MODIFY `login_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT for table `reservation`
--
ALTER TABLE `reservation`
  MODIFY `reservation_id` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=40;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
