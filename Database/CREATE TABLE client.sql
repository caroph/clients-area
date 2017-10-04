CREATE EXTENSION "uuid-ossp";

CREATE TABLE client (
    clientId uuid PRIMARY KEY DEFAULT uuid_generate_v4(),
    name varchar(250) null, 
    address varchar(250) null, 
    email varchar(250) null, 
    phone varchar(20) null, 
    latitude int not null, 
    longitude int not null
);