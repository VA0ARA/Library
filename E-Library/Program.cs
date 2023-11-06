namespace E_Library
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            DataBase.intilazingListBook();
            MainMenu obj = new MainMenu();
            obj.WelcomMenu();
            
        }
    }
}