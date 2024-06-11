-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jun 11, 2024 at 11:24 PM
-- Server version: 10.4.27-MariaDB
-- PHP Version: 8.1.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `trader_beta`
--

-- --------------------------------------------------------

--
-- Table structure for table `portfolios`
--

CREATE TABLE `portfolios` (
  `order_num` varchar(36) NOT NULL,
  `StockName` varchar(255) DEFAULT NULL,
  `StockOwner` varchar(255) DEFAULT NULL,
  `Investment` double(40,2) DEFAULT NULL,
  `Units` double(40,2) DEFAULT NULL,
  `Profit` double(40,2) DEFAULT NULL,
  `Price` double(40,2) DEFAULT NULL,
  `BuyPrice` double(40,2) DEFAULT NULL,
  `Type` varchar(255) DEFAULT NULL,
  `owner_Id` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `portfolios`
--

INSERT INTO `portfolios` (`order_num`, `StockName`, `StockOwner`, `Investment`, `Units`, `Profit`, `Price`, `BuyPrice`, `Type`, `owner_Id`) VALUES
('70d40981-e499-4575-b78b-93f8e4ddb3cc', 'SOL', 'Solana', 200.00, 1.36, -0.18, 146.87, 147.00, 'Crypto', 1),
('cc41af61-90b7-4ad1-a39b-c334edd69fc1', 'OIL', 'Oil (Non Expiry)', 200.00, 2.60, -0.16, 76.94, 77.00, 'Commodity', 1);

-- --------------------------------------------------------

--
-- Table structure for table `stocks`
--

CREATE TABLE `stocks` (
  `stock_Id` int(11) NOT NULL,
  `StockName` varchar(255) DEFAULT NULL,
  `StockOwner` varchar(255) DEFAULT NULL,
  `Investment` double(40,2) DEFAULT NULL,
  `Profit` double(40,2) DEFAULT NULL,
  `Units` double(40,2) DEFAULT NULL,
  `Price` double(40,2) DEFAULT NULL,
  `Type` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `stocks`
--

INSERT INTO `stocks` (`stock_Id`, `StockName`, `StockOwner`, `Investment`, `Profit`, `Units`, `Price`, `Type`) VALUES
(1, 'TSLA', 'Tesla Corporation, Inc.', NULL, NULL, NULL, 516.68, 'Stock'),
(2, 'BTC', 'Bitcoin', NULL, NULL, NULL, 36267.42, 'Crypto'),
(3, 'AAPL', 'Apple', NULL, NULL, NULL, 263.06, 'Stock'),
(4, 'MSFT', 'Microsoft', NULL, NULL, NULL, 348.91, 'Stock'),
(5, 'SPX', 'S&P 500', NULL, NULL, NULL, 4405.29, 'Index'),
(12, 'IXIC', 'NASDAQ Composite', NULL, NULL, NULL, 13632.73, 'Index'),
(14, 'GOLD', 'Gold (Non Expiry)', NULL, NULL, NULL, 2312.92, 'Commodity'),
(15, 'SILVER', 'Silver (Non Expiry)', NULL, NULL, NULL, 28.97, 'Commodity'),
(16, 'NATGAS', 'Natural Gas (Non Expiry)', NULL, NULL, NULL, 3188.13, 'Commodity'),
(17, 'GOOGL', 'Alphabet, Inc.', NULL, NULL, NULL, 175.85, 'Stock'),
(18, 'DOGE', 'Dogecoin', NULL, NULL, NULL, 0.13, 'Crypto'),
(19, 'ETH', 'Etherium', NULL, NULL, NULL, 3456.89, 'Crypto'),
(20, 'SOL', 'Solana', NULL, NULL, NULL, 146.87, 'Crypto'),
(21, 'OIL', 'Oil (Non Expiry)', NULL, NULL, NULL, 76.94, 'Commodity'),
(22, 'NVDA', 'Nvidia Corporation', NULL, NULL, NULL, 119.89, 'Stock');

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE `users` (
  `ID` int(11) NOT NULL,
  `name` varchar(255) DEFAULT NULL,
  `family` varchar(255) DEFAULT NULL,
  `username` varchar(255) DEFAULT NULL,
  `password` varchar(255) DEFAULT NULL,
  `balance` double(40,2) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`ID`, `name`, `family`, `username`, `password`, `balance`) VALUES
(1, 'Shener', 'Serhan', 'Serhanow', 'popstar123', 100402.01),
(2, 'William', 'Dafoe', 'will_dafoe', 'greengoblin123', 100000.00),
(3, 'Martin', 'Katev', 'mKatev', 'asianchicks', 100000.00);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `portfolios`
--
ALTER TABLE `portfolios`
  ADD PRIMARY KEY (`order_num`);

--
-- Indexes for table `stocks`
--
ALTER TABLE `stocks`
  ADD PRIMARY KEY (`stock_Id`);

--
-- Indexes for table `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`ID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `stocks`
--
ALTER TABLE `stocks`
  MODIFY `stock_Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=23;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
