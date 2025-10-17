SELECT register_id, [status], dateregister, student_id, group_id FROM register

DROP PROCEDURE AddrRegister

SELECT * FROM register

INSERT INTO register ([status], dateregister, student_id, group_id)
VALUES ('active', '2024-06-01', 1, 1);

SELECT * FROM student

INSERT INTO student (Phone_number, zipcode, house_number, road, district_d, district_a, Province, student_name, student_lastname)
VALUES 
('0912345678', 46170, 1, 'one', 'banone', 'city1', 'udon1', 'somsak', 'hyai'),
('0897654321', 46170, 22, 'maple', 'banmaple', 'city2', 'udon2', 'preecha', 'tangchai'),
('0841122334', 46000, 7, 'sunset', 'bansun', 'city3', 'udon3', 'ananya', 'chokdee'),
('0985566778', 46110, 15, 'pine', 'banpine', 'city4', 'udon4', 'kittisak', 'mongkol'),
(0903344550, 46220, 9, 'lotus', 'banlotus', 'city5', 'udon5', 'nichapa', 'wanjai')

Addstudent 0903344550, 46220, 9, 'lotus', 'banlotus', 'city5', 'udon5', 'nichapa', 'wanjai'

SELECT * FROM instructor

ALTER PROCEDURE Addstudent
    @Phone_number   int,
    @zipcode        int,
    @house_number   VARCHAR(5),
    @road           VARCHAR(50),    
    @district_d     VARCHAR(50),
    @district_a     VARCHAR(50),
    @Province       VARCHAR(50),
    @student_name   VARCHAR(50),
    @student_lastname VARCHAR(50)
AS
BEGIN
    INSERT INTO student (Phone_number, zipcode, house_number, road, district_d, district_a, Province, student_name, student_lastname)
    VALUES (@Phone_number, @zipcode, @house_number, @road, @district_d, @district_a, @Province, @student_name, @student_lastname);
END



EXEC Delstudent 7

CREATE PROCEDURE Delstudent
    @student_id   int 
AS 
BEGIN
    DELETE FROM student WHERE student_id = @student_id;
END

EXEC Editstudent  1, 0912345670, 46171, 1, 'one10', 'banone2', 'city2', 'udon3', 'somsakdee', 'hyaimak'

ALTER  PROCEDURE Editstudent
    @student_id       INT,
    @Phone_number     INT,
    @zipcode          INT,
    @house_number     VARCHAR(5),
    @road             VARCHAR(50),    
    @district_d       VARCHAR(50),
    @district_a       VARCHAR(50),
    @Province         VARCHAR(50),
    @student_name     VARCHAR(50),
    @student_lastname VARCHAR(50)
AS
BEGIN
    UPDATE student
    SET 
        Phone_number = @Phone_number,
        zipcode = @zipcode,
        house_number = @house_number,
        road = @road,
        district_d = @district_d,
        district_a = @district_a,
        Province = @Province,
        student_name = @student_name,
        student_lastname = @student_lastname
    WHERE student_id = @student_id;
END;
GO


EXEC AddrRegister 1, 'active', '2024-06-01'


CREATE  PROCEDURE Addregister
    @status        VARCHAR(50),
    @dateregister  DATE,
    @student_id    INT,
    @group_id      INT
AS
BEGIN
    INSERT INTO register ([status], dateregister, student_id, group_id)
    VALUES (@status, @dateregister, @student_id, @group_id);
END;
GO


-- ********** 5. จัดการข้อมูลการลงทะเบียนเรียน (Register) **********

SELECT * FROM register
SELECT * FROM student
SELECT * FROM studygroup

ALTER

-- เพิ่มการลงทะเบียน (Add/Insert)
ALTER PROCEDURE AddRegister
    @status         VARCHAR(60),
    @dateregister   DATE,
    @student_id     INT,
    @group_id        INT
AS
BEGIN
    INSERT INTO register (status, dateregister, student_id, group_id)
    VALUES (@status, @dateregister, @student_id, @group_id);
END
GO

EXEC AddRegister 'active', '2024-06-01' , 13, 6

-- ลบการลงทะเบียน (Delete)
CREATE PROCEDURE DelRegister
    @register_id   INT
AS
BEGIN
    DELETE FROM register WHERE register_id = @register_id;
END
GO

-- แก้ไขการลงทะเบียน (Edit/Update)
CREATE PROCEDURE EditRegister
    @register_id    INT,
    @status         VARCHAR(60),
    @dateregister   DATE,
    @student_id     INT,
    @grop_id        INT
AS
BEGIN
    UPDATE register
    SET 
        status = @status,
        dateregister = @dateregister,
        student_id = @student_id,
        grop_id = @grop_id
    WHERE register_id = @register_id;
END
GO


-- ********** 2. จัดการข้อมูลหลักสูตร (Course) **********

DELETE FROM student
DELETE FROM register 
DELETE FROM studygroup
DELETE FROM instructor 
DELETE FROM course

SELECT student_id, Phone_number, zipcode, house_number, road, district_d, district_a, Province, student_name, student_lastname from student
SELECT register_id, [status], dateregister, student_id, group_id FROM register
SELECT group_id, enddate, startdate,[status] , room, course_id, ist_id FROM studygroup
SELECT ist_id, ist_name, ist_Lastname, namenumber, mobilenumber, email FROM instructor
SELECT course_id, course_nameTH, course_nameENG, tuitionfees, course_list, hours_study FROM course

INSERT INTO student (student_id, Phone_number, zipcode, house_number, road, district_d, district_a, Province, student_name, student_lastname) VALUES
('0812345678', '10210', '88/1', 'Sukhumvit', 'Bang Na', 'Bangkok', 'Bangkok', 'Anan', 'Srisuk'),
('0823456789', '40000', '22', 'Mittraphap', 'Mueang', 'Khon Kaen', 'Khon Kaen', 'Kanya', 'Phonchai'),
('0834567890', '83000', '55/9', 'Phuket Rd.', 'Talad Yai', 'Mueang', 'Phuket', 'Somchai', 'Wongdee');

INSERT INTO register ([status], dateregister, student_id, group_id) VALUES
('Completed', '2025-06-10', 13, 6),
( 'Pending', '2025-06-11', 14, 7),
('Completed', '2025-06-12', 15, 8);

INSERT INTO studygroup ( enddate, startdate, [status], room, course_id, ist_id) VALUES
('2025-07-01', '2025-10-01',  'Completed','101', 13, 2),
( '2025-07-15', '2025-10-15',  'Completed','202', 14, 3),
( '2025-08-01',  '2025-11-01', 'Pending','303', 15, 4);

INSERT INTO instructor (ist_name, ist_Lastname, namenumber, mobilenumber, email) VALUES
( 'Sudarat', 'Thongchai', 'ST001', '0891112233', 'sudarat.th@university.ac.th'),
( 'Prasert', 'Manee', 'PM002', '0892223344', 'prasert.ma@university.ac.th'),
('Warin', 'Chanok', 'WC003', '0893334455', 'warin.ch@university.ac.th');

INSERT INTO course (course_nameTH, course_nameENG, tuitionfees, course_list, hours_study) VALUES
( 'พื้นฐานการเขียนโปรแกรม', 'Programming Fundamentals', 3500, 'PF101', 45),
( 'ระบบฐานข้อมูล', 'Database Systems', 4000, 'DB201', 60),
('โครงสร้างข้อมูล', 'Data Structures', 4500, 'DS301', 75);




-- เพิ่มหลักสูตร (Add/Insert)
CREATE PROCEDURE AddCourse
    @course_nameTH  VARCHAR(200),
    @course_nameENG VARCHAR(200),
    @tuitionfees    INT,
    @course_list    VARCHAR(200),
    @hours_study    INT
AS
BEGIN
    INSERT INTO course (course_nameTH, course_nameENG, tuitionfees, course_list, hours_study)
    VALUES (@course_nameTH, @course_nameENG, @tuitionfees, @course_list, @hours_study);
END
GO

EXEC AddCourse 'tahis', 'thai' , 3500, 'yhfhgt', 15

-- ลบหลักสูตร (Delete)
CREATE PROCEDURE DelCourse
    @course_id   INT
AS
BEGIN
    DELETE FROM course WHERE course_id = @course_id;
END
GO

EXEC DelCourse 1

-- แก้ไขหลักสูตร (Edit/Update)
CREATE PROCEDURE EditCourse
    @course_id      INT,
    @course_nameTH  VARCHAR(200),
    @course_nameENG VARCHAR(200),
    @tuitionfees    INT,
    @course_list    VARCHAR(200),
    @hours_study    INT
AS
BEGIN
    UPDATE course
    SET 
        course_nameTH = @course_nameTH,
        course_nameENG = @course_nameENG,
        tuitionfees = @tuitionfees,
        course_list = @course_list,
        hours_study = @hours_study
    WHERE course_id = @course_id;
END
GO

EXEC EditCourse 3,'tahti', 'eng' , 3300, 'ssstog', 14


-- ********** 3. จัดการข้อมูลหมู่เรียน (StudyGroup) **********

-- เพิ่มหมู่เรียน (Add/Insert)
CREATE PROCEDURE AddStudyGroup 
    @startdate  DATE,
    @enddate    DATE,
    @status     VARCHAR(60),
    @room       INT,
    @course_id  INT,
    @ist_id     INT
AS
BEGIN
    INSERT INTO studygroup (startdate, enddate, status, room, course_id, ist_id)
    VALUES (@startdate, @enddate, @status, @room, @course_id, @ist_id);
END
GO

EXEC AddStudyGroup '2024-06-01', '2024-06-01', 'active', 1 ,1, 1

-- ลบหมู่เรียน (Delete)
CREATE PROCEDURE DelStudyGroup
    @group_id   INT
AS
BEGIN
    DELETE FROM studygroup WHERE group_id = @group_id;
END
GO

-- แก้ไขหมู่เรียน (Edit/Update)
CREATE PROCEDURE EditStudyGroup
    @group_id   INT,
    @startdate  DATE,
    @enddate    DATE,
    @status     VARCHAR(60),
    @room       INT,
    @course_id  INT,
    @ist_id     INT
AS
BEGIN
    UPDATE studygroup
    SET 
        startdate = @startdate,
        enddate = @enddate,
        status = @status,
        room = @room,
        course_id = @course_id,
        ist_id = @ist_id
    WHERE group_id = @group_id;
END
GO

-- ********** 1. จัดการข้อมูลผู้สอน (Instructor) **********

SELECT * FROM instructor

-- เพิ่มผู้สอน (Add/Insert)
ALTER PROCEDURE AddInstructor
    @ist_name       VARCHAR(60),
    @ist_Lastname   VARCHAR(60),
    @namenumber     INT,
    @mobilenumber   INT, 
    @email          VARCHAR(60)
AS
BEGIN
    INSERT INTO instructor (ist_name, ist_Lastname, namenumber, mobilenumber, email, picture)
    VALUES (@ist_name, @ist_Lastname, @namenumber, @mobilenumber, @email, NULL); -- picture เป็น NULL
END
GO

-- ลบผู้สอน (Delete)
CREATE PROCEDURE DelInstructor
    @ist_id   INT
AS
BEGIN
    DELETE FROM instructor WHERE ist_id = @ist_id;
END
GO

-- แก้ไขผู้สอน (Edit/Update)
CREATE PROCEDURE EditInstructor
    @ist_id         INT,
    @ist_name       VARCHAR(60),
    @ist_Lastname   VARCHAR(60),
    @namenumber     INT,
    @mobilenumber   BIGINT, 
    @email          VARCHAR(60)
AS
BEGIN
    UPDATE instructor
    SET 
        ist_name = @ist_name,
        ist_Lastname = @ist_Lastname,
        namenumber = @namenumber,
        mobilenumber = @mobilenumber,
        email = @email
    WHERE ist_id = @ist_id;
END
GO