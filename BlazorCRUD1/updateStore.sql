﻿CREATE PROCEDURE [dbo].[SP_Update_Store] 
		@ID 				INT,   
		@StoreName 			NVARCHAR(250)	,
		@StoreAddress		NVARCHAR (255) 	,
		@StoreLocalPhone	NVARCHAR (255)  ,
		@StoreMobilePhone	NVARCHAR (255)  ,
		@StoreFax			NVARCHAR (255)  ,
		@StoreBANKAC1		NVARCHAR (255)  ,
		@StoreBANKAC2		NVARCHAR (255)  ,
		@StoreBANKAC3		NVARCHAR (255)  ,
		@StoreEmail			NVARCHAR (255)  ,
		@StoreUnit			INT,
		@StoreItemPerPage	INT
	AS    
		BEGIN    

		UPDATE [Store] SET
			StoreName 		 = @StoreName,				
			StoreAddress	 = @StoreAddress,
			StoreLocalPhone  = @StoreLocalPhone,
			StoreMobilePhone = @StoreMobilePhone,
			StoreFax		 = @StoreFax,
			StoreBANKAC1	 = @StoreBANKAC1,
			StoreBANKAC2	 = @StoreBANKAC2,
			StoreBANKAC3	 = @StoreBANKAC3,
			StoreEmail		 = @StoreEmail,
			StoreUnit		 = @StoreUnit,
			StoreItemPerPage = @StoreItemPerPage
		
		WHERE ID = @ID 
	           
		END;