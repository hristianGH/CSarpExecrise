# SiteX
## Project Description

SiteX is a site. Its purpose is to be easy to use site for a small company.
Best used for selling clothes and featuring your own articles/blogs.
Blog site but mostly shop site.

 
## Features
- SiteX has a Shop, generaly for clothing.
-- You can add products and categories/colors/sizes for your products
- SiteX has a Blog, generaly for updates from the site admin.
-- You can add Posts with genres and a body edited with ckeditor5 so the post can look exactly how you want
-- Also you can add comments to posts
- SiteX has a Article page scraped from pubmed.gov using using Anglesharp
- Team page showing partners of the site
 
## Views for admin
```python
 Shop menu
 -Create/Edit/Delete Product 
 -Create/Edit Category 
 -Create/Edit Location 
 -Crate/Edit Color
 -Crate/Edit Size
```

```python
 Blog/Post menu 
 -Create/Edit/Delete Post
 -Create/Edit Genre
 -Edit/Delete Comment
```

```python
 Article menu 
 -Create/Edit/Delete Article 
```
## Views for All
```python
-Shop
-View all products
-View single product
-Filter product by Category/Size/Color/Gender
-Buy Product
```
```python
-Blog
-View all posts
-View single post
-Filter product by Genre
-Add comment to post/Add comment to comment
```
```python
-Articles
-View all articles
-View single article
```
## Pictures

## WebApi
```python
-MyAccount (For login with jwt)
-> POST: "/api/MyAccount" => login for admin
```
```python
-Article 
-> GET: "/api/Article/All" => get all articles
-> POST: "/api/Article/Create" => creates article
-> PUT: "/api/Article/Edit" => edits an article
-> DELETE: "/api/Article/Delete" => deletes an article
```
```python
-Category 
-> GET: "/api/Category/All" => get all categories
-> POST: "/api/Category/Create" => creates categories
-> PUT: "/api/Category/Edit" => edits an categories
```
```python
-Color 
-> GET: "/api/Color/All" => get all colors
-> POST: "/api/Color/Create" => creates colors
-> PUT: "/api/Color/Edit" => edits an colors
```
```python
-Genre 
-> GET: "/api/Genre/All" => get all genres
-> POST: "/api/Genre/Create" => creates genres
-> PUT: "/api/Genre/Edit" => edits an genres
```
```python
-Location 
-> GET: "/api/Location/All" => get all locations
-> POST: "/api/Location/Create" => creates locations
-> PUT: "/api/Location/Edit" => edits an locations
```
```python
-Member 
-> GET: "/api/Member/All" => get all members
-> POST: "/api/Member/Create" => creates members
-> PUT: "/api/Member/Edit" => edits an members
-> DELETE: "/api/Member/Delete" => deletes an members
```
```python
-Post 
-> GET: "/api/Post/All" => get all posts
-> PUT: "/api/Post/Edit" => edits an posts
```
```python
-Product 
-> GET: "/api/Product/All" => get all products
-> GET: "/api/Product/ById{id}" => get product by id
-> POST: "/api/Product/Create" => creates product
-> PUT: "/api/Product/Edit" => edits an product
-> DELETE: "/api/Product/Delete" => deletes an product
```
```python
-Size 
-> GET: "/api/Size/All" => get all sizes
-> POST: "/api/Size/Create" => creates size
-> PUT: "/api/Size/Edit" => edits an size
```

## Technology used

- Asp.Net.Core
- Entity Framework Core
- MS SQL
- JQuery
- HTML/CSS
- SendGrid
- CkEditor5
- JWT
- WebApi
- Swagger
- JQuery
- AutoMapper
- AngleSharp
- XUnit
- Moq
- Selenium
 
## Installation
Download SiteX
Download SqlServer
Open project SiteX solution in visual studio
Run either WebMVC or WebApi
SiteX will create connection to local server in sql
run migration/Update-Database
Done!

| Plugin | README |
| ------ | ------ |
|
| GitHub | [https://github.com/hristianGH] |
 



## License

MIT

**Free Software, Hell Yeah!**
