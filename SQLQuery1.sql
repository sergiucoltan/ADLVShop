CREATE TABLE dbo.Products(
   ID                  INT         IDENTITY (1,1) NOT NULL
  ,Product_Name        VARCHAR(28) NOT NULL 
  ,Product_Description VARCHAR(42) NOT NULL
  ,Product_Price       NUMERIC(5,2) NOT NULL
  ,Available_Items     INTEGER  NOT NULL
  PRIMARY KEY CLUSTERED ([ID] ASC)
);
INSERT INTO dbo.Products(Product_Name,Product_Description,Product_Price,Available_Items) VALUES ('Bumper Stickers','Stickers / Bumper Stickers with ADLV logo',9.99,100);
INSERT INTO dbo.Products(Product_Name,Product_Description,Product_Price,Available_Items) VALUES ('CDs','with ADLV logo',29.99,100);
INSERT INTO dbo.Products(Product_Name,Product_Description,Product_Price,Available_Items) VALUES ('T-shirts','with ADLV logo',59.99,100);
INSERT INTO dbo.Products(Product_Name,Product_Description,Product_Price,Available_Items) VALUES ('Matchboxes','with ADLV logo',9.99,100);
INSERT INTO dbo.Products(Product_Name,Product_Description,Product_Price,Available_Items) VALUES ('Posters','with ADLV logo',19.99,100);
INSERT INTO dbo.Products(Product_Name,Product_Description,Product_Price,Available_Items) VALUES ('Autographed photos','with ADLV logo',14.99,100);
INSERT INTO dbo.Products(Product_Name,Product_Description,Product_Price,Available_Items) VALUES ('Lighters','with ADLV logo',14.99,100);
INSERT INTO dbo.Products(Product_Name,Product_Description,Product_Price,Available_Items) VALUES ('Drink coasters','with ADLV logo',9.99,100);
INSERT INTO dbo.Products(Product_Name,Product_Description,Product_Price,Available_Items) VALUES ('Beer cozies','with ADLV logo',19.99,100);
INSERT INTO dbo.Products(Product_Name,Product_Description,Product_Price,Available_Items) VALUES ('Shot glasses','with ADLV logo',14.99,100);
INSERT INTO dbo.Products(Product_Name,Product_Description,Product_Price,Available_Items) VALUES ('Coffee mugs','with ADLV logo',19.99,100);
INSERT INTO dbo.Products(Product_Name,Product_Description,Product_Price,Available_Items) VALUES ('Reusable shopping bags','with ADLV logo',9.99,100);
INSERT INTO dbo.Products(Product_Name,Product_Description,Product_Price,Available_Items) VALUES ('Patches','with ADLV logo',7.99,100);
INSERT INTO dbo.Products(Product_Name,Product_Description,Product_Price,Available_Items) VALUES ('Thongs','with ADLV logo',49.99,100);
INSERT INTO dbo.Products(Product_Name,Product_Description,Product_Price,Available_Items) VALUES ('Balloons','with ADLV logo',9.99,100);
INSERT INTO dbo.Products(Product_Name,Product_Description,Product_Price,Available_Items) VALUES ('Mousepads','with ADLV logo',19.99,100);
INSERT INTO dbo.Products(Product_Name,Product_Description,Product_Price,Available_Items) VALUES ('Memo pads','with ADLV logo',9.99,100);
INSERT INTO dbo.Products(Product_Name,Product_Description,Product_Price,Available_Items) VALUES ('Buttons','with ADLV logo',9.99,100);
INSERT INTO dbo.Products(Product_Name,Product_Description,Product_Price,Available_Items) VALUES ('Bandanas and scarves','with ADLV logo',29.99,100);
INSERT INTO dbo.Products(Product_Name,Product_Description,Product_Price,Available_Items) VALUES ('Sweatshirts','with ADLV logo',39.99,100);
INSERT INTO dbo.Products(Product_Name,Product_Description,Product_Price,Available_Items) VALUES ('Beach towels','with ADLV logo',49.99,100);
INSERT INTO dbo.Products(Product_Name,Product_Description,Product_Price,Available_Items) VALUES ('Pens and pencils','with ADLV logo',9.99,100);
INSERT INTO dbo.Products(Product_Name,Product_Description,Product_Price,Available_Items) VALUES ('Temporary tattoos','with ADLV logo',39.99,100);
INSERT INTO dbo.Products(Product_Name,Product_Description,Product_Price,Available_Items) VALUES ('Wine bottle cozies','with ADLV logo',29.99,100);
INSERT INTO dbo.Products(Product_Name,Product_Description,Product_Price,Available_Items) VALUES ('Ashtrays','with ADLV logo',29.99,100);
INSERT INTO dbo.Products(Product_Name,Product_Description,Product_Price,Available_Items) VALUES ('Jewelry','with ADLV logo',49.99,100);
INSERT INTO dbo.Products(Product_Name,Product_Description,Product_Price,Available_Items) VALUES ('Hats','with ADLV logo',59.99,100);
INSERT INTO dbo.Products(Product_Name,Product_Description,Product_Price,Available_Items) VALUES ('Water bottles','with ADLV logo',9.99,100);
INSERT INTO dbo.Products(Product_Name,Product_Description,Product_Price,Available_Items) VALUES ('Blankets','with ADLV logo',79.99,100);
INSERT INTO dbo.Products(Product_Name,Product_Description,Product_Price,Available_Items) VALUES ('Vinyl records','with ADLV logo',39.99,100);
INSERT INTO dbo.Products(Product_Name,Product_Description,Product_Price,Available_Items) VALUES ('Lanyards','with ADLV logo',9.99,100);
INSERT INTO dbo.Products(Product_Name,Product_Description,Product_Price,Available_Items) VALUES ('Pijamas','with ADLV logo',59.99,100);
INSERT INTO dbo.Products(Product_Name,Product_Description,Product_Price,Available_Items) VALUES ('Leggings','with ADLV logo',49.99,100);
INSERT INTO dbo.Products(Product_Name,Product_Description,Product_Price,Available_Items) VALUES ('Flashlights','with ADLV logo',39.99,100);
INSERT INTO dbo.Products(Product_Name,Product_Description,Product_Price,Available_Items) VALUES ('Magnets','with ADLV logo',19.99,100);
INSERT INTO dbo.Products(Product_Name,Product_Description,Product_Price,Available_Items) VALUES ('Ornaments','with ADLV logo',39.99,100);
INSERT INTO dbo.Products(Product_Name,Product_Description,Product_Price,Available_Items) VALUES ('Keychains','with ADLV logo',19.99,100);
INSERT INTO dbo.Products(Product_Name,Product_Description,Product_Price,Available_Items) VALUES ('DVDs','with ADLV logo',49.99,100);
INSERT INTO dbo.Products(Product_Name,Product_Description,Product_Price,Available_Items) VALUES ('Boxer shorts','with ADLV logo',49.99,100);
INSERT INTO dbo.Products(Product_Name,Product_Description,Product_Price,Available_Items) VALUES ('Tank tops','with ADLV logo',49.99,100);
INSERT INTO dbo.Products(Product_Name,Product_Description,Product_Price,Available_Items) VALUES ('Bobble heads','with ADLV logo',59.99,100);
INSERT INTO dbo.Products(Product_Name,Product_Description,Product_Price,Available_Items) VALUES ('Disposable cameras','with ADLV logo',59.99,100);
INSERT INTO dbo.Products(Product_Name,Product_Description,Product_Price,Available_Items) VALUES ('Guitar picks','with ADLV logo',9.99,100);
INSERT INTO dbo.Products(Product_Name,Product_Description,Product_Price,Available_Items) VALUES ('Journals','with ADLV logo',29.99,100);
INSERT INTO dbo.Products(Product_Name,Product_Description,Product_Price,Available_Items) VALUES ('Flip flops','with ADLV logo',39.99,100);
INSERT INTO dbo.Products(Product_Name,Product_Description,Product_Price,Available_Items) VALUES ('Windbreakers and jackets','with ADLV logo',99.99,100);
INSERT INTO dbo.Products(Product_Name,Product_Description,Product_Price,Available_Items) VALUES ('Onesies and other baby stuff','with ADLV logo',79.99,100);
INSERT INTO dbo.Products(Product_Name,Product_Description,Product_Price,Available_Items) VALUES ('Letter openers','with ADLV logo',19.99,100);
INSERT INTO dbo.Products(Product_Name,Product_Description,Product_Price,Available_Items) VALUES ('Flasks','with ADLV logo',9.99,100);
INSERT INTO dbo.Products(Product_Name,Product_Description,Product_Price,Available_Items) VALUES ('Shoe horns','with ADLV logo',9.99,100);
INSERT INTO dbo.Products(Product_Name,Product_Description,Product_Price,Available_Items) VALUES ('Aprons','with ADLV logo',59.99,100);
INSERT INTO dbo.Products(Product_Name,Product_Description,Product_Price,Available_Items) VALUES ('Banners and flags','with ADLV logo',39.99,100);
INSERT INTO dbo.Products(Product_Name,Product_Description,Product_Price,Available_Items) VALUES ('Pillowcases','with ADLV logo',49.99,100);
INSERT INTO dbo.Products(Product_Name,Product_Description,Product_Price,Available_Items) VALUES ('Decals','with ADLV logo',29.99,100);
INSERT INTO dbo.Products(Product_Name,Product_Description,Product_Price,Available_Items) VALUES ('Photo books','with ADLV logo',49.99,100);
INSERT INTO dbo.Products(Product_Name,Product_Description,Product_Price,Available_Items) VALUES ('Wallets','with ADLV logo',89.99,100);
INSERT INTO dbo.Products(Product_Name,Product_Description,Product_Price,Available_Items) VALUES ('Tissue packs','with ADLV logo',9.99,100);
INSERT INTO dbo.Products(Product_Name,Product_Description,Product_Price,Available_Items) VALUES ('Phone or laptop cases','with ADLV logo',49.99,100);
INSERT INTO dbo.Products(Product_Name,Product_Description,Product_Price,Available_Items) VALUES ('Car air fresheners','with ADLV logo',9.99,100);
INSERT INTO dbo.Products(Product_Name,Product_Description,Product_Price,Available_Items) VALUES ('Candies and mints','with ADLV logo',9.99,100);
