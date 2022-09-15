# Итоговый проект за 1 четверть

## Содержание проекта

* Постановка задачи

* Алгоритм решения (приложен отдельным файлом)

* Описание решения

* Программа (скриншот программы и результата её работы, а также файл)


## Постановка задачи

Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше или равна 3 символа.

Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.

## Описание решения

Спрашиваем у пользователя каким способом заполнить строковый массив (ручным или автоматическим). Если ручным, то спрашиваем длину массива, если автоматическим тогда спрашиваем длину массива и максимальную длину элемента массива.
Пробегаемся по всем элементам созданного строкового массива с помощью цикла for и с помощью ветвления if проверяем длину элемента массива, если длина элемента массива меньше или равна 3, то записываем этот элемент во временный массив. Также запоминаем после проходжа по всего массиву количество элементов заполненных во врменном массиве.
Создаем результирующий массив с размером равным количеству заполненных элементов из временного массива.
Переносим элементы из временного массива в результирующий массив нужной нам длины.
Выводим в консоль исходный массив и результирующий массив.


## Программа

(Разработанный алгоритм реализован на языке C#, программа написана в редакторе Visual Studio Code)
