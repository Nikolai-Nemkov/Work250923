// See https://aka.ms/new-console-template for more information
Console.WriteLine("Задача №5");


//        Все работает
// Случайности, (генератор псевдослучайных чисел)
// new Random().Next(min, max)
//  даcт случайное число от min до max-1 (дает на единицу меньше)
// [min, max-1] или [min, max]
//       Пример

int numberA = new Random().Next(1, 10);  // 1,2,3.....9
Console.WriteLine(numberA);
int numberB = new Random().Next(1, 10);
Console.WriteLine(numberB);
Console.WriteLine(numberA + numberB);
    // ответ вывод  9, 5, 14.
