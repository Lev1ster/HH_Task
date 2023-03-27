# Second task
SELECT product_name as Product, category_name as Category
FROM Products
Left Join Category_Product on product_id = Products.ID
