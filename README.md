# Итоговая проверочная работа

## Задача:
*Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив  можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.*

*Пример:* ["hello", "2", "world", ":-)"] -> ["2", ":-)"]

## Алгоритм решения:
1. Задаем на старте массив строк *input* и переменную *n* равную 3;
2. Создаем метод *ElementsLengthLessOrEqualN*, который находит все элементы из первого массива длина которых меньше либо равна 3 символа и затем записывает их в новый массив *result*.
3. Создаем метод *PrintArray*, который выводит массив на печать.
4. Выводим на печать заданный массив *input*.
5. Выводим на печать полученный массив *result*.