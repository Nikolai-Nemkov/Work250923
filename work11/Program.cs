// See https://aka.ms/new-console-template for more information
Console.WriteLine();
Console.WriteLine("Задача №11");
Console.WriteLine();

int[] arr = { 3, -5, 1, -8, 9, 2, 0, 5, 6, }; // массив который будем упорядочивать.

void PrintArray(int[] array)      // метод void должен выводить массив на экран
{
    int count = array.Length;   //  получение количества эллементов  (перевод array.Length - длинна массива),

    for (int i = 0; i < array.Length; i++)   //  цикл for в котором мы пробегаем по всем элементам массива
    {
        Console.Write($"{array[i]} ");   // показываем на экране массив

    }
    Console.WriteLine();//  пустая строка
}

PrintArray(arr);  // тестирование 

Console.WriteLine();  //  пустая строка

//Теперь надо написать метод который будет упорядочивать наш массив

//  показываем максимальный элемент и начинается он от i
// array[i] = array[minPosition];  обмен местами с найденным мин элементом
// ищем минимальный элемент через  for и  if

void selectionSort(int[] array)   // SelectionSort метод который будет упорядочивать массив
{
    for (int i = 0; i < array.Length - 1; i++)   //  пробегаем по элементам массива
    {
        int minPosition = i;  //  ищем мИНимальный элемент (minPosition - мин пзиция)и начинается он от i

        for (int j = i + 1; j < array.Length; j++) //   ищем минимальный элемент через  for и  if  
        {
            if (array[j] < array[minPosition])   // array[i] = array[minPosition];  обмен местами с найденным мин элементом
                minPosition = j;
        }
        int temporary = array[i];   // temporary - переводится как временный.
        array[i] = array[minPosition]; 
        array[minPosition] = temporary;
    }
}

selectionSort(arr);

PrintArray(arr);
Console.WriteLine();
