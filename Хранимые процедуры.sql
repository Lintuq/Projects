USE College_Library;

go
CREATE PROCEDURE BookData AS
SET NOCOUNT ON;
SELECT [Name_book],  [Author], [Publisher], [Year_of_Publishing], [LBC], [Amount], [IdStore] FROM Book;
go

exec BookData;

go
CREATE PROCEDURE StoreData AS
SELECT * FROM Store;
go

exec StoreData;

go
CREATE PROCEDURE DataBookOnShelf (@number_place int) AS 
SELECT bo.Name_book, bo.Author, bo.LBC, bo.Publisher, bo.Year_of_Publishing, bo.Amount, st.NumberShelf FROM Book AS bo INNER JOIN Store AS st 
ON bo.IdStore = st.IdStore WHERE st.IdStore = @number_place;
go

exec DataBookOnShelf 101;
--***************************************************************************************
go
CREATE PROCEDURE SearchByNameBook (@namebook nvarchar(100)) AS
SELECT bo.Name_book, bo.Author, bo.LBC, bo.Publisher, bo.Year_of_Publishing, bo.Amount, st.IdStore ,st.NumberShelf FROM Book AS bo INNER JOIN Store AS st 
ON bo.IdStore = st.IdStore WHERE bo.Name_book LIKE '%' + @namebook + '%';
go

exec SearchByNameBook 'Основы'

go
CREATE PROCEDURE SearchByAuthor (@author nvarchar(100)) AS
SELECT bo.Name_book, bo.Author, bo.LBC, bo.Publisher, bo.Year_of_Publishing, bo.Amount, st.IdStore, st.NumberShelf FROM Book AS bo INNER JOIN Store AS st 
ON bo.IdStore = st.IdStore WHERE Author LIKE '%' + @author + '%';
go

exec SearchByAuthor 'Семакин'

go
CREATE PROCEDURE SearchNyPublisher (@publisher nvarchar(100)) AS
SELECT bo.Name_book, bo.Author, bo.LBC, bo.Publisher, bo.Year_of_Publishing, bo.Amount, st.IdStore, st.NumberShelf FROM Book AS bo INNER JOIN Store AS st 
ON bo.IdStore = st.IdStore WHERE bo.Publisher LIKE '%' + @publisher + '%';
go

exec SearchNyPublisher 'АКАДЕМИЯ';

--*********************************************************************************
go
CREATE PROCEDURE InsertBook (
@namebook nvarchar(100),
@author nvarchar(100),
@publisher nvarchar(100),
@year_of_publish nvarchar(100),
@LBC nvarchar(80),
@Amount int,
@IdStore int
) AS
INSERT INTO Book VALUES (
@namebook, @author, @publisher, @year_of_publish, @LBC, @Amount, @IdStore
);
go

exec InsertBook 'Программирование', 'Фишман', 'Токио сити', '2011', '83.12', 22, 123

go
CREATE PROCEDURE LoadBookDataForDelete AS
SELECT * FROM Book;
go

exec LoadBookDataForDelete;

go
CREATE PROCEDURE DeleteBook (@idbook int, @name_book nvarchar(100)) AS
DELETE FROM Book WHERE IdBook = @idbook AND Name_book LIKE '%' + @name_book + '%';
go

exec DeleteBook 48, 'Нор'

go
CREATE PROCEDURE UpdateBookData( @id int,
@namebook nvarchar(100), @author nvarchar(100),
@publisher nvarchar(80), @year_of_publishing nvarchar(100), 
@LBC nvarchar(100), @amount int, @idstore int) AS
UPDATE Book SET Name_book = @namebook, Author = @author, Publisher = @publisher,
Year_of_Publishing = @year_of_publishing, LBC = @LBC, Amount = @amount, IdStore = @idstore
WHERE IdBook = @id;
go

exec UpdateBookData 52, 'Диана', 'Леона', 'Лунари и солари', '2012', '233.211.23', 21, 123

go
CREATE PROCEDURE StoreDataLoad AS
SELECT * FROM Store;
go

exec StoreDataLoad

go
CREATE PROCEDURE InsertStoreData (@IdStore int, @NumberShelf int, @NumberBook int) AS
INSERT INTO Store VALUES 
(@IdStore, @NumberShelf, @NumberBook);
go

exec InsertStoreData 125, 1, 2

go
CREATE PROCEDURE UpdateStoreData (@idoldstore int, @idnewstore int, @numbershelf int, @numberbook int) AS
UPDATE Store SET
IdStore = @idnewstore, NumberShelf = @numbershelf, NumberBook = @numberbook WHERE IdStore = @idoldstore;
go

exec UpdateStoreData 1240, 124, 1, 1

go
CREATE PROCEDURE DeleteStore (@iddelete int) AS
DELETE FROM Store WHERE IdStore = @iddelete;
go

exec DeleteStore 125

go
CREATE PROCEDURE SelectProfessors AS
SELECT * FROM Professor;
go

exec SelectProfessors;

go
CREATE PROCEDURE SelectGroup AS
SELECT * FROM [Group];
go

exec SelectGroup;

go
CREATE PROCEDURE SelectLibraryCard AS
SELECT * FROM Library_Card;
go

exec SelectLibraryCard;

go
CREATE PROCEDURE SelectForm AS
SELECT * FROM Form;
go

exec SelectForm

go
CREATE PROCEDURE SelectStudent AS
SELECT * FROM Student;
go

exec SelectStudent

go
CREATE PROCEDURE InsertGiveBook (@IdStudent int, @IdForm int, @IdBook int, @IdRecord int, @DateRecord datetime, @StatusBook nvarchar(20)) 
AS
INSERT INTO Form VALUES 
(@IdStudent, @IdForm, @IdBook, @IdRecord, @DateRecord, @StatusBook);
go

exec InsertGiveBook 3, 2, 1, 3, '2020.02.12', 'На руках'

go
CREATE PROCEDURE UpdateStatusBook (@IdRecord int, @StatusBook nvarchar(18)) AS
UPDATE Form SET StatusBook = @StatusBook WHERE IdRecord = @IdRecord;
go

exec UpdateStatusBook 1, 'Возварщена'; 

go
CREATE PROCEDURE NotBookLibrary AS
SELECT Name_book, Author, Name, Surname, Lastname FROM Book AS bo JOIN Form As fo ON bo.IdBook = fo.IdBook JOIN Library_Card AS li ON
fo.IdStudent = li.IdStudent JOIN Student as st ON li.IdStudent = st.IdStudent WHERE StatusBook != 'Возвращена';
go
 
go
CREATE PROCEDURE BookBackLibrary AS
SELECT Name_book, Author, Name, Surname, Lastname FROM Book AS bo JOIN Form As fo ON bo.IdBook = fo.IdBook JOIN Library_Card AS li ON
fo.IdStudent = li.IdStudent JOIN Student as st ON li.IdStudent = st.IdStudent WHERE StatusBook = 'Возвращена';
go

go
CREATE PROCEDURE UpdateCountBook(@IdBook int) AS
UPDATE Book SET Amount = Amount - 1 WHERE IdBook = @IdBook;
go

go
CREATE PROCEDURE UpdateBookBack(@IdRecord int) AS
UPDATE Book SET Amount = Amount + 1 WHERE IdBook = (SELECT IdBook FROM Form WHERE IdRecord = @IdRecord); 
go

go
CREATE PROCEDURE BookDataForInsert AS
SELECT [Name_book],  [Author], [Publisher], [Year_of_Publishing], [LBC], [Amount], [IdStore] FROM Book;
go

go
CREATE PROCEDURE ChooseStudentWithDebtor (@idstudent int) AS
SELECT bo.Name_book, bo.Author, st.Name, st.Surname, st.Lastname, gr.NumberGroup, pr.Name, pr.Surname, pr.Lastname, pr.Email
FROM Book AS bo JOIN FORM AS fo ON bo.IdBook = fo.IdBook JOIN Library_Card AS LC ON fo.IdStudent = LC.IdStudent JOIN Student AS
st ON LC.IdStudent = st.IdStudent JOIN [Group] AS gr ON st.IdGroup = gr.IdGroup JOIN Professor AS pr ON gr.IdProfessor = pr.IdProfessor
WHERE st.IdStudent = @idstudent AND (fo.StatusBook != 'Возвращена');
go

exec ChooseStudentWithDebtor 4
