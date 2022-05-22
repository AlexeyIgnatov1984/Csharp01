Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "алёха")
{
    Console.WriteLine("Ура, это же Алёха!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}