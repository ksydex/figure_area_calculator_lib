# Question 2

В базе данных MS SQL Server есть продукты и категории. Одному продукту может соответствовать много категорий, в одной категории может быть много продуктов. Напишите SQL запрос для выбора всех пар «Имя продукта – Имя категории». Если у продукта нет категорий, то его имя все равно должно выводиться.

---

## Solution

### SQL Query #1

Creates 3 tables and inserts basic test data

```sql

-- create the products table
CREATE TABLE products (
    product_id INT PRIMARY KEY,
    product_name VARCHAR(50) NOT NULL
);

-- create the categories table
CREATE TABLE categories (
    category_id INT PRIMARY KEY,
    category_name VARCHAR(50) NOT NULL
);

-- create the product_category table to link products and categories
CREATE TABLE product_category (
    product_id INT,
    category_id INT,
    PRIMARY KEY (product_id, category_id),
    FOREIGN KEY (product_id) REFERENCES products (product_id),
FOREIGN KEY (category_id) REFERENCES categories (category_id)
);

-- insert test data into the products table
INSERT INTO products (product_id, product_name)
VALUES
    (1, 'Product A'),
    (2, 'Product B'),
    (3, 'Product C'),
    (4, 'Product D');

-- insert test data into the categories table
INSERT INTO categories (category_id, category_name)
VALUES
    (1, 'Category X'),
    (2, 'Category Y'),
    (3, 'Category Z');

-- insert test data into the product_category table
INSERT INTO product_category (product_id, category_id)
VALUES
    (1, 1),
    (1, 2),
    (2, 2),
    (2, 3),
    (3, 1);
```

### SQL Query #2

Retrieving pairs of Product - Category. If product has no categories it's still retrieved
```sql
SELECT p.id AS product_id,
    p.name AS product_name,
    c.id AS category_id,
    c.name AS category_name,
    CONCAT(p.name,
          CASE WHEN c.name IS NULL THEN '' ELSE CONCAT(' - ', c.name) END
       ) AS name
FROM products p
LEFT JOIN product_category pc ON p.id = pc.product_id
LEFT JOIN categories c ON pc.category_id = c.id
ORDER BY p.name;
```