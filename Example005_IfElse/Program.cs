Console.WriteLine ("Введите имя пользователя");
string usernsme = Console.ReadLine ();

if (usernsme.ToLower () == "маша")
{
    Console.WriteLine ("Ура, это же Маша!");
} 
else
{
    Console.WriteLine ("Привет, ");
    Console.WriteLine (usernsme);
} 