# Разработка программного модуля складского учета ювелирного магазина
Программа представляет собой модуль складского учёта для ювелирного магазина. Она позволяет эффективно управлять поставками, товарами, продажами, категориями изделий, а также осуществлять учёт материалов и драгоценных камней. Интерфейс реализован в виде WPF-приложения с использование архитектуры MVVM и подключения к базе данных MS SQL SERVER. \
\
![C#](https://img.shields.io/badge/c%23-%23239120.svg?style=for-the-badge&logo=csharp&logoColor=white)
![Visual Studio](https://img.shields.io/badge/Visual%20Studio-5C2D91.svg?style=for-the-badge&logo=visual-studio&logoColor=white)
![MicrosoftSQLServer](https://img.shields.io/badge/Microsoft%20SQL%20Server-CC2927?style=for-the-badge&logo=microsoft%20sql%20server&logoColor=white)

## Содержание
- [Введение](#введение)
- [Установка](#установка)
- [Библиотеки](#библиотеки)
- [Базы данных](#базы-данных)
- [Диаграммы сущностей](#диаграммы-сущностей)
- [Памятка](#памятка)

## Введение
Программный модуль разработан с целью автоматизации процессов поставок и упрощения отслеживания ювелирных изделий на складе и в торговых точках магазина. Он обеспечивает более точный и эффективный учёт товаров, снижая нагрузку на персонал и минимизируя ошибки при обработке информации.

## Установка
Для установки в **`Power Shell`** введите эту команду:
```
git clone https://github.com/PuliOtBabuli228/JewelleryStoreApplication.git
```

## Библиотеки
* [Microsoft.EntityFrameworkCore.Tools](https://www.nuget.org/packages/Microsoft.EntityFrameworkCore.Tools/10.0.0-preview.2.25163.8)
* [Microsft.EntityFrameworkCore](https://www.nuget.org/packages/Microsoft.EntityFrameworkCore/)
* [Microsoft.EntityFrameworkCore.Sqlite](https://www.nuget.org/packages/Microsoft.EntityFrameworkCore.Sqlite/10.0.0-preview.2.25163.8)
* [Microsoft.EntityFrameworkCore.SqlServer](https://www.nuget.org/packages/Microsoft.EntityFrameworkCore.SqlServer/10.0.0-preview.2.25163.8)

## Базы данных
В проекте есть возможность использовать такие варианты **БД** как **MS Sql Server** и **Sqlite** 


## Диаграммы сущностей
![Диаграмма классов](https://github.com/user-attachments/assets/6947af8f-3cb8-47ed-8c31-37d24cdc6bdc)

## Памятка
1. Открыть решение в Visual Studio.
2. Убедиться, что настроено подключение к SQL Server.
3. Применить миграции базы данных (через Update-Database в консоли).
4. Построить и запустить проект.
