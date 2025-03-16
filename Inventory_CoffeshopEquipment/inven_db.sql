USE inven_db;
CREATE TABLE equipment (
	id INT AUTO_INCREMENT PRIMARY KEY,
    name VARCHAR(255) NOT NULL,
    description TEXT,
    price DECIMAL(10,2),
    stock_quantity INT DEFAULT 0
);

SELECT * FROM equipment;
