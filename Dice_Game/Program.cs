class Program
{
    static void Main(string[] args)
    {
        int playerRandomNum;
        int enemyRandomNum;

        int playerPoint = 0;
        int enemyPoint = 0;

        Random random = new Random();

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("Press Enter key to roll the Dice");
            Console.ReadKey();

            playerRandomNum = random.Next(1, 7);
            Console.WriteLine($"You roll a {playerRandomNum}");

            Console.WriteLine("......");
            System.Threading.Thread.Sleep(1000);

            enemyRandomNum = random.Next(1, 7);
            Console.WriteLine($"Enemy roll a {enemyRandomNum}");
            Console.WriteLine();

            if (playerRandomNum > enemyRandomNum)
            {
                playerPoint++;
                Console.WriteLine("Player is Win this round!");
            }
            else if (playerRandomNum < enemyRandomNum)
            {
                enemyPoint++;
                Console.WriteLine("Enemy is Win this round!");
            }
            else
            {
                Console.WriteLine("Draw!");
            }
            Console.WriteLine($"The point is now - Player: {playerPoint} and Enemy: {enemyPoint}");
            Console.WriteLine();
        }

        if (playerPoint > enemyPoint)
        {
            Console.WriteLine("Congratulations You're Win!");
        }
        else if (playerPoint < enemyPoint)
        {
            Console.WriteLine("Opps! You are Lose!");
        }
        else
        {
            Console.WriteLine("It's a Draw!");
        }
        Console.ReadKey();
    }
}