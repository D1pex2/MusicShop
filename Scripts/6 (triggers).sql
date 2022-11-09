CREATE TRIGGER [dbo].[TR_DecreaseInStockQuantity]
    ON [dbo].[OrderProduct]
    AFTER INSERT
    AS
    BEGIN
    UPDATE Product
	SET Product.quantity = Product.quantity - inserted.quantity
	FROM Product JOIN inserted
	ON Product.idProduct = inserted.idProduct;
    END

CREATE TRIGGER [dbo].[TR_DeleteProduct]
    ON [dbo].[Product]
    AFTER DELETE
    AS
    BEGIN
    INSERT INTO DeletedProduct
    SELECT *
    FROM deleted
    END;