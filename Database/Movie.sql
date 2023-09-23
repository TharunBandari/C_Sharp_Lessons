-- Use the Testdb database
USE Testdb;

-- Create the Movie table
CREATE TABLE Movie (
    Id INT PRIMARY KEY,
    Title VARCHAR(255),
    Language VARCHAR(50),
    Hero VARCHAR(100),
    Director VARCHAR(100),
    ReleaseDate DATE,
    Cost DECIMAL(10, 2),
    Collection DECIMAL(10, 2),
);


SELECT * FROM Movie;


INSERT INTO Movie (id, Title, Language, Hero, Director, ReleaseDate, Cost, Collection, Review)
VALUES (01, 'Jailer', 'Tamil', 'Rajinikanth', 'Nelson', '2023-08-08', 200.00, 500.00, 4.5);


INSERT INTO Movie (id, Title, Language, Hero, Director, ReleaseDate, Cost, Collection, Review)
VALUES (02, 'OG', 'Telugu', 'PK', 'Sujeeth', '2000-12-19', 300.00, 500.00, 5.0);

INSERT INTO Movie (id, Title, Language, Hero, Director, ReleaseDate, Cost, Collection, Review)
VALUES (03, 'Leo', 'Tamil', 'Vijay', 'LK', '2023-10-20', 100.00, 200.00, 4.0);