-- phpMyAdmin SQL Dump
-- version 4.9.0.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: May 18, 2020 at 01:36 PM
-- Server version: 10.4.6-MariaDB
-- PHP Version: 7.3.8

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `gudang`
--

-- --------------------------------------------------------

--
-- Table structure for table `barang_keluar`
--

CREATE TABLE `barang_keluar` (
  `id_bk` int(11) NOT NULL,
  `kode_barang` int(11) NOT NULL,
  `tanggal_keluar` date NOT NULL,
  `jumlah` int(11) NOT NULL,
  `no_antrian` int(11) NOT NULL,
  `nama_pemesan` varchar(50) NOT NULL,
  `tujuan` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `barang_keluar`
--

INSERT INTO `barang_keluar` (`id_bk`, `kode_barang`, `tanggal_keluar`, `jumlah`, `no_antrian`, `nama_pemesan`, `tujuan`) VALUES
(1, 1, '2020-05-06', 11, 1, 'IMAM', 'TEKNIK MESIN'),
(2, 5, '2020-05-18', 3, 1, 'IMAM', 'Teknik Mesin');

--
-- Triggers `barang_keluar`
--
DELIMITER $$
CREATE TRIGGER `kurang` AFTER INSERT ON `barang_keluar` FOR EACH ROW update stock_barang set jumlah = jumlah - new.jumlah
where kode_barang = new.kode_barang
$$
DELIMITER ;

-- --------------------------------------------------------

--
-- Table structure for table `barang_masuk`
--

CREATE TABLE `barang_masuk` (
  `id_bm` int(11) NOT NULL,
  `kode_barang` int(11) NOT NULL,
  `tanggal_in` date NOT NULL,
  `jumlah` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `barang_masuk`
--

INSERT INTO `barang_masuk` (`id_bm`, `kode_barang`, `tanggal_in`, `jumlah`) VALUES
(1, 2, '2020-05-04', 12),
(2, 1, '2020-05-05', 12),
(11, 6, '0000-00-00', 3),
(12, 7, '2020-05-17', 10),
(13, 6, '2020-05-17', 3),
(14, 3, '2020-05-17', 4),
(15, 2, '2020-05-17', 6);

--
-- Triggers `barang_masuk`
--
DELIMITER $$
CREATE TRIGGER `perbarui` AFTER INSERT ON `barang_masuk` FOR EACH ROW update stock_barang set jumlah = jumlah + new.jumlah
where kode_barang = new.kode_barang
$$
DELIMITER ;

-- --------------------------------------------------------

--
-- Table structure for table `req_barang`
--

CREATE TABLE `req_barang` (
  `kode_req` int(11) NOT NULL,
  `kode_barang` int(11) NOT NULL,
  `tanggal_req` date NOT NULL,
  `jumlah` int(11) NOT NULL,
  `pemesan` varchar(50) NOT NULL,
  `tujuan` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `req_barang`
--

INSERT INTO `req_barang` (`kode_req`, `kode_barang`, `tanggal_req`, `jumlah`, `pemesan`, `tujuan`) VALUES
(1, 5, '2020-05-07', 3, 'IMAM', 'TEKNIK MESIN'),
(2, 1, '2020-05-18', 6, 'IMAM TOHARI', 'Bengkel Mobil');

-- --------------------------------------------------------

--
-- Table structure for table `stock_barang`
--

CREATE TABLE `stock_barang` (
  `kode_barang` int(11) NOT NULL,
  `nama_barang` varchar(50) NOT NULL,
  `satuan` varchar(5) NOT NULL,
  `jumlah` int(5) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `stock_barang`
--

INSERT INTO `stock_barang` (`kode_barang`, `nama_barang`, `satuan`, `jumlah`) VALUES
(1, 'Ash SS 304 uk.1\"', 'pcs', 4),
(2, 'Baut SS 3/4x4\"', 'pcs', 181),
(3, 'Blind Flange SS 304 10k 6\"', 'pcs', 7),
(5, 'Box MCB Hager Tempel Isi 8', 'pcs', 0),
(6, 'Botol sample 250 ml + Tutup', 'pcs', 170),
(7, 'Cable Scun 16 - 8', 'pcs', 23);

-- --------------------------------------------------------

--
-- Table structure for table `verifikasi_barang`
--

CREATE TABLE `verifikasi_barang` (
  `id_ver` int(11) NOT NULL,
  `tgl_ver` date NOT NULL,
  `status` varchar(20) NOT NULL,
  `nama_kabag` varchar(50) NOT NULL,
  `kode_req` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `verifikasi_barang`
--

INSERT INTO `verifikasi_barang` (`id_ver`, `tgl_ver`, `status`, `nama_kabag`, `kode_req`) VALUES
(1, '2020-05-08', 'ACC', 'ENI', 1),
(2, '2020-05-18', 'ACC', 'ENI RAHMAWATI', 2);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `barang_keluar`
--
ALTER TABLE `barang_keluar`
  ADD PRIMARY KEY (`id_bk`),
  ADD KEY `fk_kode_barang` (`kode_barang`);

--
-- Indexes for table `barang_masuk`
--
ALTER TABLE `barang_masuk`
  ADD PRIMARY KEY (`id_bm`),
  ADD KEY `kode barang` (`kode_barang`);

--
-- Indexes for table `req_barang`
--
ALTER TABLE `req_barang`
  ADD PRIMARY KEY (`kode_req`),
  ADD KEY `fk2_kobar` (`kode_barang`);

--
-- Indexes for table `stock_barang`
--
ALTER TABLE `stock_barang`
  ADD PRIMARY KEY (`kode_barang`);

--
-- Indexes for table `verifikasi_barang`
--
ALTER TABLE `verifikasi_barang`
  ADD PRIMARY KEY (`id_ver`),
  ADD KEY `fk1_kobar` (`kode_req`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `barang_keluar`
--
ALTER TABLE `barang_keluar`
  MODIFY `id_bk` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `barang_masuk`
--
ALTER TABLE `barang_masuk`
  MODIFY `id_bm` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=16;

--
-- AUTO_INCREMENT for table `req_barang`
--
ALTER TABLE `req_barang`
  MODIFY `kode_req` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `stock_barang`
--
ALTER TABLE `stock_barang`
  MODIFY `kode_barang` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT for table `verifikasi_barang`
--
ALTER TABLE `verifikasi_barang`
  MODIFY `id_ver` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `barang_keluar`
--
ALTER TABLE `barang_keluar`
  ADD CONSTRAINT `barang_keluar_ibfk_1` FOREIGN KEY (`kode_barang`) REFERENCES `stock_barang` (`kode_barang`);

--
-- Constraints for table `barang_masuk`
--
ALTER TABLE `barang_masuk`
  ADD CONSTRAINT `barang_masuk_ibfk_1` FOREIGN KEY (`kode_barang`) REFERENCES `stock_barang` (`kode_barang`);

--
-- Constraints for table `req_barang`
--
ALTER TABLE `req_barang`
  ADD CONSTRAINT `req_barang_ibfk_1` FOREIGN KEY (`kode_barang`) REFERENCES `stock_barang` (`kode_barang`);

--
-- Constraints for table `verifikasi_barang`
--
ALTER TABLE `verifikasi_barang`
  ADD CONSTRAINT `verifikasi_barang_ibfk_1` FOREIGN KEY (`kode_req`) REFERENCES `req_barang` (`kode_req`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
