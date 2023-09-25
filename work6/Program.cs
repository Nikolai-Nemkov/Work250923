// See https://aka.ms/new-console-template for more information
Console.WriteLine("Задача №6");

// Приветствуем одного из пользователе  по особенному, как любимчика 
              // все работает

Console.WriteLine("Введите имя пользователя ");
string username = Console.ReadLine();

if(username == "Коля")  // if(username.ToLower() == "Коля") позволяет не ошибиться
                         // при вводе имени с большой или маленькой буквы.
{
 Console.WriteLine("Ура это же Коля!");
}
else
{
    Console.WriteLine("Привет, ");
    Console.WriteLine(username);
}