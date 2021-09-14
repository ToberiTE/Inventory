# ASP.NET Core API

Datamodels are currently set up in a "product" fashion, to only accept particular server-validated data.

Can easily be modified by altering the datamodels.

#### Available endpoints:
* **GET api/products** -- Returns all products.
* **GET api/products/{id}** -- Returns specific product with supplied id.
* **POST api/products** -- Add new product.
* **PUT api/products/{id}** -- Update entire or part of product entry with supplied id.
* **PATCH api/products/{id}** -- Updates part of the product entry with supplied id.
* **DELETE api/products/{id}** -- Remove product with supplied id

#

Database:
![DB](https://user-images.githubusercontent.com/65503426/133178596-8976bbf8-030a-4f9c-98d5-3789e12770c8.PNG)


Returned data from calling "api/products" endpoint:
![JSONBROWSER](https://user-images.githubusercontent.com/65503426/133178604-d141896d-268e-4f13-bc19-423cbd5c019f.PNG)


