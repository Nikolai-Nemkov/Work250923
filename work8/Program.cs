// See https://aka.ms/new-console-template for more information
Console.WriteLine("Задача №8");


  //                               Не сработал
// Задача про точки. Берем две точки ставим еще одну по середине, затем следующу и т.д. Цикл
// console.Clear();  // Очистка консоли
// console.SetCursorPosition(10, 4); // отступы строками от левого края и отступ от лверхнего края. Позиция курсора
// Console.WriteLine("+");   // рисовка + (плюсиками)
// Определяем вершины треугольника

int xa = 40;
    ya = 1;
    xb = 1;
    yb = 1;
    xc = 80; 
    yc = 30;

Console.SetCursorPosition(xa, ya);
Console.WriteLine("+"); 

Console.SetCursorPosition(xb, xb);
Console.WriteLine("+"); 
 
Console.SetCursorPosition(xc, yc);
Console.WriteLine("+"); 

int x = xa, y = xb; //  случайные точки

int count = 0;  // ставим счетчик на цикл количества точек

while(count < 10000)  // ставим счетчик на цикл количества точек
{
    int what = new Random().Next(0,3); //
    if(what == 0)
    {
        x = (x + xa)/2;
        y = (y + ya)/2;
    }
    if(what == 1)
    {
        x = (x + xb)/2;
        y = (y + yb)/2;
    }
    if(what == 2)
    {
        x = (x + xc)/2;
        y = (y + yc)/2;
    }

    Console.SetCursorPosition(x, y);
    Console.WriteLine("+"); 
    count++;

}