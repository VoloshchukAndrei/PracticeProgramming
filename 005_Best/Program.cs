Console.WriteLine("Введите имя пользователя ");
string username = Console.ReadLine();

if(username.ToLower() == "данила")
{
    Console.WriteLine("Ура!!! Это же ДАНЯ!!!");
}
else
{
    Console.Write("Привет, ");
    Console.Write(username);
}
