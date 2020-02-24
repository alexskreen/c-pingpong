using System;

class PingPong
{
    static void Main()
    {
        Console.WriteLine("Please enter a number:");
        string userNumber = Console.ReadLine();
        int pingPongNumber = int.Parse(userNumber);
        // int pingPongList = {};
        Console.WriteLine("Ping Pong:");
        for (int index = 1; index <= pingPongNumber; index++)
        {
            if (index % 3 == 0 && index % 5 == 0)
            {
                Console.WriteLine("Ping-Pong");
            }
            else if (index % 5 == 0)
            {
                Console.WriteLine("Pong");
            }
            else if (index % 3 == 0)
            {
                Console.WriteLine("Ping");
            }
            else
            {
            Console.WriteLine(index);
            }
        }
    }
}
