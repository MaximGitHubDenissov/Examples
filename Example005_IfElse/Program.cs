Console.WriteLine ("Введите имя пользователя");
string username = Console.ReadLine ()!;

if (username.ToLower () == "ольга")
{
    Console.WriteLine ("Ура, это же Слоник!");
} 
else
{
    Console.WriteLine ("Привет, ");
    Console.WriteLine (username);
} 