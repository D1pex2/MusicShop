/****** Object:  UserDefinedFunction [dbo].[GetAvgRating]    Script Date: 01.06.2022 15:39:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[GetAvgRating]
(
    @idProduct int
)
RETURNS decimal(3,1)
AS
BEGIN
	DECLARE @avgRating decimal(3,1)
	SELECT @avgRating = CAST(ROUND(AVG(rating), 1) AS decimal(3,1))
	FROM Comment
	WHERE Comment.idProduct = @idProduct
    RETURN @avgRating
END
GO
/****** Object:  UserDefinedFunction [dbo].[GetLastImage]    Script Date: 01.06.2022 15:39:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[GetLastImage]
(
    @idProduct int
)
RETURNS varbinary(MAX)
AS
BEGIN

    DECLARE @image varbinary(MAX)
	SELECT TOP(1) @image = dbo.ProductImage.image
	FROM dbo.ProductImage
	WHERE dbo.ProductImage.idProduct = @idProduct
	ORDER BY ProductImage.idImage DESC
	RETURN @image

END
GO
/****** Object:  UserDefinedFunction [dbo].[GetUserCartProduct]    Script Date: 01.06.2022 15:39:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[GetUserCartProduct]
(
    @idUser int
)
RETURNS TABLE AS RETURN
(
    SELECT Product.*
	FROM Product JOIN Cart ON Product.idProduct = Cart.idProduct
	WHERE Cart.idUser = @idUser
)
GO
