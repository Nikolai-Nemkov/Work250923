// See https://aka.ms/new-console-template for more information
Console.WriteLine("Задача №10");

int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1,};  // массив который будем отсортировывать

void PrintArray(int[] array)   // метод void выводит данный массив на экран
{
    int count = array.Length;  //array.Length;   // получение количества эллементов
    
    for (int i = 0; i < array.Length; i++)  // цикл for в котором мы пробегаем по всем элементам массива
    {
        Console.Write($"{array[i]} ");  // показываем на экране массив
    }
    Console.WriteLine();    //  пустая строка
}

// PrintArray(arr);            // для тестирования 

//Теперь надо написать метод который будет упорядочивать наш массив


void SelectionSort(int[] array)     // SelectionSort метод который будет упорядочивать массив
{
    for (int i = 0; i < array.Length - 1; i++)     //  пробегаем по массиву 
    {
        int minPosition = i;      // присваиваем

        for (int j = i + 1; j < array.Length; j++)     //  ищем максимальный элемент  
        {
            if(array[j] < array[minPosition]) minPosition = j;    // ищем максимальный элемент
        }
        int temporary = array[i];   //  
        array[i] = array[minPosition]; // 
        array[minPosition] = temporary;  //  
    }
}
PrintArray(arr);  // 
SelectionSort(arr);   // 

PrintArray(arr);   //













