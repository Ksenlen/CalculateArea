SELECT P.ProductName, C.CategoryName
FROM Products P
LEFT JOIN ProductCategory PC ON P.ProductID = PC.ProductID
LEFT JOIN Categories C ON C.CategoryID = PC.CategoryID;


/* В данном запросе предполагается, что у нас есть три таблицы:

1)Products со столбцом ProductID и ProductName, содержащая информацию о продуктах.

2)Categories со столбцом CategoryID и CategoryName, содержащая информацию о категориях.

3)ProductCategory со столбцами ProductID и CategoryID, представляющая связь между продуктами и категориями (многие ко многим.
Операция LEFT JOIN гарантирует, что даже если у продукта нет категорий, его имя все равно будет выводиться в результате запроса. Если у продукта есть несколько категорий, то для каждой пары "Имя продукта - Имя категории" будет создан отдельный результат запроса.) */
