# Комментарии по коду

Руководство по использованию
Файл TestLibrary представляет собой библиотеку, а файл TestingLibrary - unit-тесты. Библиотека написана как консольное приложение на платформе .Net Core 3.1
Обьяснение реализации:
Т.к вычисление площади каждой фигуры разное, то был написан абстрактный класс который реализует 2 метода: подсчет площади, вывод информации о площади фигуры. Второй метод реализован больше для пользователя что бы ему предоставлялась информация о площади фигуры. Для того чтобы добавить новую фигуру, достаточно наследовать класс Figure и переопределить два метода. Можно было реализовать через интерфейс, но хотелось сделать что то похожее на фабричный метод

# Создание базы данных
Первым делом создадим базу данных которую назовем STORE
Команда для ее выполнения: 

```
CREATE DATABASE STORE;
```

## Далее нужно создать таблицы, для этого я сделал 2 варианта
### Вариант 1, создание 2 таблиц
Первым делом были созданы две таблицы - Продуктов и Категорий и соединены ключом (CategoryId):

```
USE STORE

CREATE TABLE Goods(
ProductId INT IDENTITY(1,1) NOT NULL CONSTRAINT PK_ProductId PRIMARY KEY,
Category INT NULL,
ProductName VARCHAR(100) NOT NULL
);

GO

CREATE TABLE Categories(
CategoryId INT IDENTITY(1,1) NOT NULL CONSTRAINT PK_CategoryId PRIMARY KEY,
CategoryName VARCHAR(100) NOT NULL
);

GO

ALTER TABLE Goods ADD CONSTRAINT FK_Category
FOREIGN KEY(Category)
REFERENCES Categories (CategoryId)
ON DELETE SET DEFAULT
ON UPDATE NO ACTION;
```

Далее эти таблицы были заполнены значениями:
#### Заполнение таблицы категорий

```
use STORE
insert into Categories values ('Фрукт'), ('Овощ'), ('Ягода'), ('Молочный продукт'), ('Мясной продукт');
```

#### Заполнение таблицы продуктов

```
use STORE

insert into Goods values 
(1,'Яблоко'),(1,'Груша'),(2,'Помидор'),
(3,'Арбуз'),(1,'Персик'),(4,'Моловка'),(4,'Сливки'),
(5,'Свинина'),(5,'Курица'),(2,'Огурец'),(4,'Сыр')

insert into Goods values
(NULL,'Банан')
select * from Goods;
```

**После чего был написано соответсвующий запрос:**

```
use STORE

select ProductName, CategoryName from Goods as g
left join Categories as c on g.Category=c.CategoryID;
```

