-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jul 19, 2024 at 12:06 PM
-- Server version: 10.4.32-MariaDB
-- PHP Version: 8.0.30

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `dentalservice`
--

-- --------------------------------------------------------

--
-- Table structure for table `bookinghistory`
--

CREATE TABLE `bookinghistory` (
  `BookingID` int(11) NOT NULL,
  `UserID` int(11) DEFAULT NULL,
  `BookingDate` date DEFAULT NULL,
  `BookingTime` time DEFAULT NULL,
  `ServiceName` varchar(255) DEFAULT NULL,
  `DoctorName` varchar(255) DEFAULT NULL,
  `QRCode` char(9) DEFAULT NULL,
  `Status` enum('Booked','Completed','Cancelled') DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `bookinghistory`
--

INSERT INTO `bookinghistory` (`BookingID`, `UserID`, `BookingDate`, `BookingTime`, `ServiceName`, `DoctorName`, `QRCode`, `Status`) VALUES
(1, 2, '2024-07-22', '14:30:00', 'Niềng răng mắc cài', 'Lê Thị Mai', 'gxe874YMZ', 'Booked'),
(2, 1, '2024-07-25', '13:00:00', 'Niềng răng Invisalign', 'Trần Minh Đức', 'ess069ZEN', 'Cancelled');

--
-- Triggers `bookinghistory`
--
DELIMITER $$
CREATE TRIGGER `BeforeInsertBookingHistory` BEFORE INSERT ON `bookinghistory` FOR EACH ROW BEGIN
    DECLARE current_datetime DATETIME;
    SET current_datetime = NOW();

    IF NEW.BookingDate < CURDATE() OR (NEW.BookingDate = CURDATE() AND NEW.BookingTime <= CURTIME()) THEN
        SIGNAL SQLSTATE '45000' SET MESSAGE_TEXT = 'Booking date and time must be in the future';
    END IF;
END
$$
DELIMITER ;

-- --------------------------------------------------------

--
-- Table structure for table `dentalclinic`
--

CREATE TABLE `dentalclinic` (
  `ClinicID` int(11) NOT NULL,
  `ClinicName` varchar(255) NOT NULL,
  `Description` text DEFAULT NULL,
  `Address` varchar(255) NOT NULL,
  `Phone` varchar(20) DEFAULT NULL,
  `Email` varchar(255) DEFAULT NULL,
  `Facebook` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `dentalclinic`
--

INSERT INTO `dentalclinic` (`ClinicID`, `ClinicName`, `Description`, `Address`, `Phone`, `Email`, `Facebook`) VALUES
(1, 'Lập Đức', 'Nha Khoa quy tụ hơn 200 bác sĩ dày dạn kinh nghiệm và tốt nghiệp từ các trường Răng Hàm Mặt hàng đầu quốc tế. Đội ngũ này liên tục cập nhật kiến thức và công nghệ mới, đảm bảo áp dụng các kỹ thuật tiên tiến nhất. Với sự chuyên môn vững vàng và quy trình chuẩn quốc tế, Nha Khoa Kim cam kết mang đến dịch vụ chăm sóc răng miệng chất lượng và tận tâm.', 'Đông Hòa, Dĩ An, Bình Dương', '0123456789', 'lapduc.dentry@gmail.com', 'fb.com/lapducdentry');

-- --------------------------------------------------------

--
-- Table structure for table `doctornurse`
--

CREATE TABLE `doctornurse` (
  `DoctorNurseID` int(11) NOT NULL,
  `ClinicID` int(11) DEFAULT NULL,
  `FullName` varchar(255) NOT NULL,
  `Avatar` text NOT NULL,
  `BirthDate` date DEFAULT NULL,
  `Email` varchar(255) DEFAULT NULL,
  `Phone` varchar(20) DEFAULT NULL,
  `Gender` enum('Male','Female','Other') DEFAULT NULL,
  `Education` varchar(255) DEFAULT NULL,
  `Position` varchar(255) DEFAULT NULL,
  `Salary` decimal(10,2) DEFAULT NULL,
  `Description` text DEFAULT NULL,
  `Hobby` text DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `doctornurse`
--

INSERT INTO `doctornurse` (`DoctorNurseID`, `ClinicID`, `FullName`, `Avatar`, `BirthDate`, `Email`, `Phone`, `Gender`, `Education`, `Position`, `Salary`, `Description`, `Hobby`) VALUES
(1, 1, 'Nguyễn Văn An', 'doctor_nurse/image1.jpg', '1980-03-15', 'an.nguyen@example.com', '0901234567', 'Male', 'Đại học Y Phạm Ngọc Thạch;Khoa Răng Hàm Mặt', 'Bác sĩ', 20000000.00, 'Bác sĩ có kinh nghiệm 20 năm trong ngành nha khoa.', 'Đọc sách; Câu cá; Du lịch'),
(2, 1, 'Lê Thị Mai', 'doctor_nurse/image2.jpg', '1985-12-01', 'mai.le@example.com', '0903456789', 'Female', 'Đại học Y Phạm Ngọc Thạch;Khoa Răng Hàm Mặt', 'Bác sĩ', 22000000.00, 'Bác sĩ chuyên về thẩm mỹ răng và chỉnh hình.', 'Đọc sách; Yoga; Chạy bộ'),
(3, 1, 'Trần Minh Đức', 'doctor_nurse/image3.jpg', '1975-08-22', 'duc.tran@example.com', '0902345678', 'Male', 'Đại học Y Phạm Ngọc Thạch;Khoa Răng Hàm Mặt', 'Bác sĩ', 25000000.00, 'Bác sĩ nổi tiếng với kỹ năng điều trị sâu răng và bệnh nướu.', 'Chơi thể thao; Xem phim; Nấu ăn'),
(4, 1, 'Nguyễn Thị Hoa', 'doctor_nurse/image4.jpg', '1990-05-10', 'hoa.nguyen@example.com', '0904567890', 'Female', 'Cao đẳng Y tế', 'Y tá', 12000000.00, 'Y tá chăm sóc bệnh nhân và hỗ trợ bác sĩ trong các thủ tục.', 'Xem phim; Chơi piano; Nấu ăn'),
(5, 1, 'Phạm Văn Bình', 'doctor_nurse/image5.jpg', '1992-09-12', 'binh.pham@example.com', '0905678901', 'Male', 'Cao đẳng Y tế', 'Y tá', 11000000.00, 'Y tá với kỹ năng chăm sóc chuyên sâu và thân thiện.', 'Đọc sách; Đạp xe; Xem thể thao'),
(6, 1, 'Đỗ Thị Lan', 'doctor_nurse/image6.jpg', '1991-11-20', 'lan.do@example.com', '0906789012', 'Female', 'Cao đẳng Y tế', 'Y tá', 11500000.00, 'Y tá chăm sóc tận tình và có kinh nghiệm trong xử lý các tình huống khẩn cấp.', 'Chạy bộ; Tham gia các hoạt động cộng đồng; Du lịch'),
(7, 1, 'Trần Thị Minh Trang', 'doctor_nurse/image7.jpg', '1988-06-25', 'tuan.vu@example.com', '0907890123', 'Female', 'Cao đẳng Y tế', 'Y tá', 12500000.00, 'Y tá có chuyên môn cao trong chăm sóc và điều trị bệnh nhân.', 'Chơi bóng đá; Xem phim hành động; Cắm trại'),
(8, 1, 'Bùi Thị Kim', 'doctor_nurse/image8.jpg', '1994-04-30', 'kim.bui@example.com', '0908901234', 'Female', 'Cao đẳng Y tế', 'Y tá', 10500000.00, 'Y tá tận tâm, hỗ trợ chăm sóc bệnh nhân và phối hợp với bác sĩ.', 'Sở thích nghệ thuật; Xem truyền hình; Nấu ăn');

-- --------------------------------------------------------

--
-- Table structure for table `service`
--

CREATE TABLE `service` (
  `ServiceID` int(11) NOT NULL,
  `ClinicID` int(11) DEFAULT NULL,
  `ServiceName` varchar(255) NOT NULL,
  `ServiceImage` varchar(255) DEFAULT NULL,
  `ServiceInfo` text DEFAULT NULL,
  `ServiceAdvantages` text DEFAULT NULL,
  `Doctors` text DEFAULT NULL,
  `Cost` decimal(10,0) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `service`
--

INSERT INTO `service` (`ServiceID`, `ClinicID`, `ServiceName`, `ServiceImage`, `ServiceInfo`, `ServiceAdvantages`, `Doctors`, `Cost`) VALUES
(1, 1, 'Niềng răng mắc cài', 'service/image1.jpg', 'Niềng răng mắc cài là kỹ thuật sử dụng mắc cài bằng sứ hay kim loại gắn lên bề mặt răng. Lực kéo được tạo ra bằng cách kết hợp dây cung và khí cụ chỉnh nha giúp răng di chuyển về đúng vị trí. Phương pháp này giúp khắc phục những khuyết điểm của răng như móm, hô, khấp khểnh hay sai lệch khớp cắn.', 'Cải Thiện Đều Đặn và Đúng Đắn Của Răng;Tăng Cường Sức Khỏe Răng Miệng;Chi Phí Tiết Kiêmk', 'Bác Sĩ 1;Bác Sĩ 2;Bác Sĩ 3', 33000000),
(2, 1, 'Niềng răng Invisalign', 'service/image2.jpg', 'Niềng răng không mắc cài Invisalign là loại hình điều trị chỉnh nha tiên tiến bậc theo công nghệ Mỹ, bằng cách sử dụng hàng loạt các khay niềng trong suốt để làm dịch chuyển răng đến vị trí mong muốn đem lại hiệu quả tối ưu về mặt thẩm mỹ lẫn chỉnh nha. Bạn chỉ việc đeo khay niềng liên tục 20 – 22h một ngày, thay khay định kỳ theo chỉ định của Bác sĩ và cảm nhận nụ cười đẹp lên từng ngày mà không ai biết bạn đang niềng răng.', 'Tính Thẩm Mỹ Cao;Thoải Mái và Dễ Dàng Hơn;Kết Quả Điều Trị Chính Xác và Dự Đoán', 'Bác Sĩ 1;Bác Sĩ 2;Bác Sĩ 3', 79000000);

-- --------------------------------------------------------

--
-- Table structure for table `userprofile`
--

CREATE TABLE `userprofile` (
  `UserID` int(11) NOT NULL,
  `ClinicID` int(11) DEFAULT NULL,
  `FullName` varchar(255) NOT NULL,
  `Gender` enum('Male','Female','Other') DEFAULT NULL,
  `BirthDate` date DEFAULT NULL,
  `Address` varchar(255) DEFAULT NULL,
  `Phone` varchar(20) DEFAULT NULL,
  `Email` varchar(255) DEFAULT NULL,
  `Pwd` varchar(255) DEFAULT NULL,
  `IsAdmin` tinyint(1) DEFAULT 0
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `userprofile`
--

INSERT INTO `userprofile` (`UserID`, `ClinicID`, `FullName`, `Gender`, `BirthDate`, `Address`, `Phone`, `Email`, `Pwd`, `IsAdmin`) VALUES
(1, 1, 'Lê Thị A', 'Female', '2000-07-29', 'Quận 7, HCM', '7979797979', 'lapkull@gmail.com', '123456', 0),
(2, 1, 'Nguyễn Đức Lập', 'Male', '2003-08-15', 'Thủ Đức, HCM', '0397440015', 'rumbonaruson@gmail.com', '123456', 1);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `bookinghistory`
--
ALTER TABLE `bookinghistory`
  ADD PRIMARY KEY (`BookingID`),
  ADD KEY `UserID` (`UserID`);

--
-- Indexes for table `dentalclinic`
--
ALTER TABLE `dentalclinic`
  ADD PRIMARY KEY (`ClinicID`);

--
-- Indexes for table `doctornurse`
--
ALTER TABLE `doctornurse`
  ADD PRIMARY KEY (`DoctorNurseID`),
  ADD KEY `ClinicID` (`ClinicID`);

--
-- Indexes for table `service`
--
ALTER TABLE `service`
  ADD PRIMARY KEY (`ServiceID`),
  ADD KEY `ClinicID` (`ClinicID`);

--
-- Indexes for table `userprofile`
--
ALTER TABLE `userprofile`
  ADD PRIMARY KEY (`UserID`),
  ADD KEY `ClinicID` (`ClinicID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `bookinghistory`
--
ALTER TABLE `bookinghistory`
  MODIFY `BookingID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `dentalclinic`
--
ALTER TABLE `dentalclinic`
  MODIFY `ClinicID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT for table `doctornurse`
--
ALTER TABLE `doctornurse`
  MODIFY `DoctorNurseID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT for table `service`
--
ALTER TABLE `service`
  MODIFY `ServiceID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `userprofile`
--
ALTER TABLE `userprofile`
  MODIFY `UserID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `bookinghistory`
--
ALTER TABLE `bookinghistory`
  ADD CONSTRAINT `bookinghistory_ibfk_1` FOREIGN KEY (`UserID`) REFERENCES `userprofile` (`UserID`);

--
-- Constraints for table `doctornurse`
--
ALTER TABLE `doctornurse`
  ADD CONSTRAINT `doctornurse_ibfk_1` FOREIGN KEY (`ClinicID`) REFERENCES `dentalclinic` (`ClinicID`);

--
-- Constraints for table `service`
--
ALTER TABLE `service`
  ADD CONSTRAINT `service_ibfk_1` FOREIGN KEY (`ClinicID`) REFERENCES `dentalclinic` (`ClinicID`);

--
-- Constraints for table `userprofile`
--
ALTER TABLE `userprofile`
  ADD CONSTRAINT `userprofile_ibfk_1` FOREIGN KEY (`ClinicID`) REFERENCES `dentalclinic` (`ClinicID`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
