# Описание решения задачи

## Последовательность шагов:
1. Вводим команду, чтобы задать количество элементов в массиве;
2. Делаем проверку, чтобы введенное количество элементов было > 0;
3. Инициализируем переменную _string arrayStr_ с помощью которой в дальнейшем запустим метод _**GetArrayString**_;
4. Создаем метод для создания массива строк _**GetArrayString**_:
    * создаем массив с присвоением ему размера в соответствии с количеством заданных элементов массива;
    * запускаем цикл **for** в котором задаем каждый отдельный элемент массива посредством ввода с клавиатуры _(Console.ReadLine())_
5. Заполняем массив _string[ ] mainArray_ с использованием метода _**GetArrayString**_
6. Создаем метод _**CountNumberOfShortElem**_, который будет считать количество элементов в массиве _mainArray_ с числом символов < 4;
    * так же используем цикл **for**
7. Создаем метод _**SelectShortElements**_, который будет отбирать из имеющегося массива _mainArray_ элементы массива с числом символов <4;
    * в данном методе размер массива будет задаваться исходя из количества элементов массива с числом символов <4 (метод _**CountNumberOfShortElem**_);
8. Создаем новый массив _string[] selectedElements_, который заполняем с помощью метода _**SelectShortElements**_;
9. Готовый результат выводим на экран с помощью команды **Console.Write**
