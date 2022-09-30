namespace Endless_Dungeon
{
    class Program
    {
        public static Player CurrentPlayer = new Player();
        static void Main(String[] args)
        {
            Start();
        }

        static void Start()
        {
            Console.WriteLine("Welcome to Endless Dungeon");
            Console.WriteLine("Enter player name: ");
            CurrentPlayer.Name = Console.ReadLine();
        }
    }
}