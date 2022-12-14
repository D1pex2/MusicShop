/****** Object:  StoredProcedure [dbo].[ChangeRole]    Script Date: 01.06.2022 15:38:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ChangeRole]
    @idUser int,
    @idRole int  
AS
    UPDATE [User] SET idRole = @idRole;
GO
/****** Object:  StoredProcedure [dbo].[CreateOrderFromCart]    Script Date: 01.06.2022 15:38:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[CreateOrderFromCart]
    @idUser int,
	@deliveryDate smalldatetime,
	@deliveryAddress nvarchar(300)
AS
BEGIN
    INSERT INTO [Order] (idUser, deliveryDate, deliveryAddress) VALUES (@idUser, @deliveryDate, @deliveryAddress);
    DECLARE @idOrder int = scope_identity();
	INSERT INTO OrderProduct
	SELECT idProduct, @idOrder, quantity
	FROM Cart
	WHERE Cart.idUser = @idUser;
END;
GO
