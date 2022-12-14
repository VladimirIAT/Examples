Console.WriteLine("Введите имя пользователя");
string username = Console.ReadLine();
if(username == "Маша")
{
    Console.WriteLine("Ура, это Маша!");
} else {
    Console.WriteLine("Привет, " + username);
}