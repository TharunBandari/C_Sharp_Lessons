use Testdb;

CREATE TABLE [dbo].[emptbl_TharunCity]( /* Running iN DDL9*/
[eno][int]NOT NULL, [name][nvarchar](20)NOT NULL,
[salary][numeric](18,0)NOT NULL, [city][nvarchar](20)NOT NULL,
CONSTRAINT [PK_emptb]PRIMARY KEY CLUSTERED( [eno]ASC));
ALTER TABLE [dbo].[emptbl_Tharun] WITH CHECK ADD CONSTRAINT 
[CK_emptbl_City]CHECK(([city]='Chennai' OR [CITY]='Bgl'));