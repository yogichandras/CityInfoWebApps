-- phpMyAdmin SQL Dump
-- version 4.5.4.1deb2ubuntu2
-- http://www.phpmyadmin.net
--
-- Host: localhost
-- Generation Time: 14 Mar 2018 pada 09.35
-- Versi Server: 5.7.21-0ubuntu0.16.04.1
-- PHP Version: 7.0.25-0ubuntu0.16.04.1

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `cityinfodb`
--

-- --------------------------------------------------------

--
-- Struktur dari tabel `tempat`
--

CREATE TABLE `tempat` (
  `Id` int(11) NOT NULL,
  `CreateBy` int(90) DEFAULT NULL,
  `UpdateBy` int(90) DEFAULT NULL,
  `Createdate` varchar(400) DEFAULT NULL,
  `IdKategori` int(11) NOT NULL,
  `MasterTempatId` int(11) DEFAULT NULL,
  `Picture` varchar(400) DEFAULT NULL,
  `Title` varchar(400) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `tempat`
--

INSERT INTO `tempat` (`Id`, `CreateBy`, `UpdateBy`, `Createdate`, `IdKategori`, `MasterTempatId`, `Picture`, `Title`) VALUES
(1, 0, 0, '2018-03-02', 1, NULL, 'stack.PNG', 'Maribaya'),
(2, 0, 3, '2018-03-02', 2, NULL, 'ss.PNG', 'Two Cents');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tempat`
--
ALTER TABLE `tempat`
  ADD PRIMARY KEY (`Id`),
  ADD KEY `IX_Tempat_MasterTempatId` (`MasterTempatId`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `tempat`
--
ALTER TABLE `tempat`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
--
-- Ketidakleluasaan untuk tabel pelimpahan (Dumped Tables)
--

--
-- Ketidakleluasaan untuk tabel `tempat`
--
ALTER TABLE `tempat`
  ADD CONSTRAINT `FK_Tempat_Tempat_MasterTempatId` FOREIGN KEY (`MasterTempatId`) REFERENCES `tempat` (`Id`) ON DELETE NO ACTION;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
