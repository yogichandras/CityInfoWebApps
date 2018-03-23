-- phpMyAdmin SQL Dump
-- version 4.5.4.1deb2ubuntu2
-- http://www.phpmyadmin.net
--
-- Host: localhost
-- Generation Time: 14 Mar 2018 pada 09.33
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
-- Struktur dari tabel `gallery`
--

CREATE TABLE `gallery` (
  `Id` int(11) NOT NULL,
  `CreateBy` int(90) DEFAULT NULL,
  `UpdateBy` int(20) DEFAULT NULL,
  `CreationTime` datetime NOT NULL,
  `MasterGalleryId` int(11) DEFAULT NULL,
  `id_kategori` int(11) NOT NULL,
  `id_tempat` int(11) NOT NULL,
  `image` longtext
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `gallery`
--

INSERT INTO `gallery` (`Id`, `CreateBy`, `UpdateBy`, `CreationTime`, `MasterGalleryId`, `id_kategori`, `id_tempat`, `image`) VALUES
(7, 2, NULL, '2018-03-05 11:15:56', NULL, 1, 1, 'love.PNG'),
(8, 2, NULL, '2018-03-05 11:29:38', NULL, 1, 1, '500.PNG'),
(9, 3, 3, '2018-03-05 12:46:17', NULL, 1, 1, 'ss2.PNG'),
(11, 3, 3, '2018-03-05 12:46:11', NULL, 1, 1, 'error.PNG'),
(12, 3, NULL, '2018-03-05 12:45:36', NULL, 1, 1, 'pertama.PNG');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `gallery`
--
ALTER TABLE `gallery`
  ADD PRIMARY KEY (`Id`),
  ADD KEY `IX_Gallery_MasterGalleryId` (`MasterGalleryId`),
  ADD KEY `IX_Gallery_id_kategori` (`id_kategori`),
  ADD KEY `IX_Gallery_id_tempat` (`id_tempat`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `gallery`
--
ALTER TABLE `gallery`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;
--
-- Ketidakleluasaan untuk tabel pelimpahan (Dumped Tables)
--

--
-- Ketidakleluasaan untuk tabel `gallery`
--
ALTER TABLE `gallery`
  ADD CONSTRAINT `FK_Gallery_Gallery_MasterGalleryId` FOREIGN KEY (`MasterGalleryId`) REFERENCES `gallery` (`Id`) ON DELETE NO ACTION,
  ADD CONSTRAINT `FK_Gallery_Kategori_id_kategori` FOREIGN KEY (`id_kategori`) REFERENCES `kategori` (`Id`) ON DELETE CASCADE,
  ADD CONSTRAINT `FK_Gallery_Tempat_id_tempat` FOREIGN KEY (`id_tempat`) REFERENCES `tempat` (`Id`) ON DELETE CASCADE;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
