using System;

class Program
{
    static void Main(string[] args)
    {
        StartGame();
    }

    static void StartGame()
    {
        Console.WriteLine("Welcome to the Forest Quest!");
        Console.WriteLine("You find yourself standing at the edge of a dense forest, tall trees swaying gently in the breeze.");
        Console.WriteLine("Press Enter to continue...");
        Console.ReadLine();

        // First decision
        Console.WriteLine("\nAs you step forward, you see two paths: one winding to the left, and one straight ahead into darkness.");
        Console.WriteLine("1) Take the left path");
        Console.WriteLine("2) Go straight ahead into the darkness");
        Console.Write("What do you do? (1/2): ");
        string? choice1 = Console.ReadLine();

        if (choice1 == "1")
        {
            LeftPath();
        }
        else if (choice1 == "2")
        {
            DarkPath();
        }
        else
        {
            Console.WriteLine("\nYou hesitate, unable to decide. Time passes, and eventually you wander away.");
            Console.WriteLine("Game Over.");
        }
    }

    static void LeftPath()
    {
        Console.WriteLine("\nYou take the left path, which is well-lit and lined with mushrooms.");
        Console.WriteLine("Press Enter to continue...");
        Console.ReadLine();

        Console.WriteLine("\nAfter a short walk, you encounter a friendly elf who offers to guide you.");
        Console.WriteLine("1) Accept the elf's offer");
        Console.WriteLine("2) Politely decline and continue alone");
        Console.Write("What do you do? (1/2): ");
        string? choice2 = Console.ReadLine();

        if (choice2 == "1")
        {
            Console.WriteLine("\nThe elf leads you safely out of the forest, and you reach a peaceful village.");
            Console.WriteLine("You have found a new home and friends. You win!");
        }
        else if (choice2 == "2")
        {
            Console.WriteLine("\nYou continue onward by yourself. The path grows narrow and the forest thicker.");
            Console.WriteLine("Eventually, you reach a calm pond where you rest, never finding your way out but living peacefully.");
            Console.WriteLine("Game Over.");
        }
        else
        {
            Console.WriteLine("\nConfused, you wander into a thicket of thorns and cannot escape.");
            Console.WriteLine("Game Over.");
        }
    }

    static void DarkPath()
    {
        Console.WriteLine("\nYou stride forward into the darkness, the light behind you fading.");
        Console.WriteLine("Press Enter to continue...");
        Console.ReadLine();

        Console.WriteLine("\nWithin the darkness, you hear rustling leaves. A pair of glowing eyes peer at you from the shadows.");
        Console.WriteLine("1) Call out to the creature");
        Console.WriteLine("2) Run back to the entrance");
        Console.Write("What do you do? (1/2): ");
        string? choice3 = Console.ReadLine();

        if (choice3 == "1")
        {
            Console.WriteLine("\nA soft voice replies, 'Lost traveler, why do you wander here?'");
            Console.WriteLine("You explain your situation, and the creature reveals itself as a gentle forest spirit.");
            Console.WriteLine("Guided by the spirit, you find a hidden grove filled with light and safety.");
            Console.WriteLine("You live there peacefully. You win!");
        }
        else if (choice3 == "2")
        {
            Console.WriteLine("\nYou turn and run, but in your panic you stumble over roots and rocks.");
            Console.WriteLine("You collapse, disoriented, and never find your way out.");
            Console.WriteLine("Game Over.");
        }
        else
        {
            Console.WriteLine("\nParalyzed by fear, you stand still until dawn. When the light returns, the path you came from is gone.");
            Console.WriteLine("You spend the rest of your days lost in the forest.");
            Console.WriteLine("Game Over.");
        }
    }
}
