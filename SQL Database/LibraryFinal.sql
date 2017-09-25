CREATE DATABASE [db.libraryms1];
USE [db.libraryms1]

CREATE TABLE tbl_book (
	Bookid VARCHAR(50) NOT NULL,
	Title VARCHAR(60) NOT NULL,
	PublisherName VARCHAR(60)  NOT NULL
)



CREATE TABLE tbl_publishers (
	Name VARCHAR(60) NOT NULL, 
    Address VARCHAR(80) NOT NULL,
	Phone VARCHAR(50) NOT NULL
)


CREATE TABLE tbl_book_loans
	(Bookid VARCHAR(50) NOT NULL,
	Branchid INT NOT NULL,
	CardNo INT NOT NULL,
	DateOut VARCHAR(50) NOT NULL,
	DueDate VARCHAR(50) NOT NULL
	)


CREATE TABLE tbl_book_copies (
	Bookid VARCHAR(50) NOT NULL, 
	Branchid INT NOT NULL,
	No_Of_Copies INT NOT NULL 
)

CREATE TABLE tbl_library_branch (
	Branchid INT Not Null,
	Branchname VARCHAR(60) NOT NULL,
	Address VARCHAR(50) NOT NULL
)


CREATE TABLE tbl_borrowers (
	CardNo INT NOT NULL,
	Name VARCHAR(50) NOT NULL,
	Address VARCHAR(50) NOT NULL,
	Phone VARCHAR(50) NOT NULL
)


CREATE TABLE tbl_book_authors (
	Bookid VARCHAR(50) NOT NULL,
	AuthorName VARCHAR(50) NOT NULL
	)



