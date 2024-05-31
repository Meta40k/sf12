//Задание 12.1.5
//Для списка пользователей добавьте приветствие по имени. Если пользователь не имеет премиум-подписки, то ему нужно показать рекламу.

using ConsoleApp1;

internal class Program
{
    public static void Main(string[] args)
    {
       var mina = new User("mina", "Mina", true);
       var dina = new User("dina", "Dina", true);
       var vina = new User("vina", "Vina", false);
        
        //Список пользователей:
        var users = new User[3] {mina, dina, vina};



        foreach (var x in users)
        {
            x.ShowAds();
            Console.WriteLine($"Привет {x.Name}");
        }
        
        
        
    }
}