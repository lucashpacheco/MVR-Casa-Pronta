CREATE TABLE IF NOT EXISTS Images(

    id              bigint AUTO_INCREMENT NOT NULL,
    name            varchar(500) NOT NULL,
    quantity        int NOT NULL,
    price           decimal(10,2) NOT NULL, 
    PRIMARY KEY (id)
) ;