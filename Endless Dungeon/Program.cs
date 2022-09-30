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
            Console.WriteLine(
                $"You are {CurrentPlayer.Name}, a knight living in the kingdom of Larion. You have a steel longsword and" +
                $" a wooden shield. You are on a quest to defeat the evil dragon of Larion. You've heard he lives up at " +
                $"the north of the kingdom. You set on the path to defeat him and walk into a dark forest. As you enter " +
                $"the forest you see that it is getting lighter outside. Day is breaking. It's been a long time since " +
                $"you've slept. You could rest for a few minutes, and then continue on your path...");
        }
    }
}