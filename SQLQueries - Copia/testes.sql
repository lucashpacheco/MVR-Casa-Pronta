CREATE DATABASE Images;

USE Images;

CREATE TABLE Images(IMG_ID INT PRIMARY KEY IDENTITY , IMG_BYTE IMAGE,IMG_NAME VARCHAR(200), IMG_DESCRIPTION VARCHAR(MAX) );

SELECT * FROM Images

--DROP TABLE Images


INSERT INTO Images( IMG_BYTE , IMG_NAME , IMG_DESCRIPTION)
VALUES( 


(SELECT
    IMG_BYTE.BulkColumn AS IMG_BYTE
	
FROM
    OPENROWSET(BULK N'C:\Users\WorkStationW10\Documents\MVR-Casa-Pronta\MVR-Casa-Pronta\images\6.jpg', SINGLE_BLOB) AS IMG_BYTE),
	'cozinha' ,
	'Reforma cozinha , moveis e decoração'
	)

UPDATE Images SET IMG_NAME = '3.jpg' WHERE IMG_ID = 2;
UPDATE Images SET IMG_DESCRIPTION = '3.jpg para teste descrição' WHERE IMG_ID = 2;

DELETE FROM Images WHERE IMG_ID = 11
	
