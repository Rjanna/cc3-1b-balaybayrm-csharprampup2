using System;
namespace four

public class Activity
{
    public static void Main(string[] args)
    {
        Console.WriteLine("PART 1 OF the activity\n");

        Console.WriteLine ("PART 1 oF the activity\n");
        Console.WriteLine("CONVERSION ");
        Console.WriteLine("\nConvert Pounds to Kilograms ");
        Console.Write ("Enter weight in Pound(lbs):");
        double weight_to_lbs = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine ("Weight in Kilograms(kg):"+ weight_to_lbs*0.453592);
        Console.WriteLine ("=====================================");
     
        Console.WriteLine("Convert Miles to Kilometers ");
        Console.Write ("Enter length in Miles(mi):");
        double mi_to_km = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine ("Length in Kilometers(km):"+ mi_to_km*1.60934);
        Console.WriteLine ("=====================================");
     
        Console.WriteLine("Convert Fahrenheit to Celsius ");
        Console.Write ("Enter temperature in Fahrenheit:");
        double F_to_C = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine ("Temperature in Celsius:"+ (F_to_C-32)/1.8000);
        Console.WriteLine ("=====================================");

        Console.WriteLine("GET AVERAGE OF 10 STUDENTS\n ");
        Console.WriteLine("GET AVERAGE OF 10 STUDENTS\n ");
        Console.Write("Age of Student 1 :");
        int studentAge1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Age of Student 2 :");
        int studentAge2 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Age of Student 3 :");
        int studentAge3 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Age of Student 4 :");
        int studentAge4 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Age of Student 5 :");
        int studentAge5 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Age of Student 6 :");
        int studentAge6 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Age of Student 7 :");
        int studentAge7 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Age of Student 8 :");
        int studentAge8 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Age of Student 9 :");
        int studentAge9 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Age of Student 10 :");
        int studentAge10 = Convert.ToInt32(Console.ReadLine());
        Console.Write("The average age of the students is :"+ (studentAge1+studentAge2+studentAge3+studentAge4+studentAge5+studentAge6+studentAge7+studentAge8+studentAge9+studentAge10)/10);

        Console.WriteLine ("=====================================\n");
     
        Console.WriteLine ("STORY\n");
    
          string one = "~Khalil~";
          string two = "~Linus~";
          string three = "~Mr. X~";
          string four = "~Herald~ ";
          string five = "~Rami~";

          string a = "Wind of Death";
          string b = "Sword of Light";
          string c = "Dragon Armor";
          string d = "Amulet of Power";
          string e = "Demon Spear";

          string storyItem = "Fountain of Truth";

           // Start telling the story using concatenation
          string storyPart1 = "In the Lost World of Atlantis, where another reality is hidden from the existence of humans, lies great adventures for those who seek it. ";
          storyPart1 += "An ordinary young boy, " + one + ", had dreamt of being the greatest adventurer of the land. ";
          storyPart1 += "With his two friends, " + two + " and " + four + ", nothing was impossible as they are the owners of the three sacred weapons: ";
          storyPart1 += a + ", " + b + ", and " + c + ".";
          string storyPart2 = "Their journey led them to the " + storyItem + ", where a mysterious figure, " + three + ", awaited them. ";
          storyPart2 += "Wielding the " + e + ", " + three + " challenged them to a battle for the fate of Atlantis. ";
          storyPart2 += "But as the battle raged, a powerful ally, " + five + ", emerged with the " + d + ", shifting the tide in their favor.";

           Console.WriteLine(storyPart1);
           Console.WriteLine(storyPart2);

        Console.WriteLine("=====================================================================\n");
        Console.WriteLine("PART 2 OF the activity\n");

        // Experiment 1
        Console.Write("First Program- Input:");
        int number1 = Convert.ToInt32(Console.ReadLine());
        if (number1 > 0)
        {
            for (int i = 1; i <= number1; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
        }
        else
        {
            Console.WriteLine("Invalid input");
        }

        Console.WriteLine("=================================");

        // Experiment 2
        Console.Write("Second Program- Input:");
        int number2 = Convert.ToInt32(Console.ReadLine());
        if (number2 > 0)
        {
            int result = 0;
            string formula = "";

            for (int i = 1; i <= number2; i++)
            {
                result += i;
                if (i == number2)
                {
                    formula += i.ToString(); // Add last number without "+"
                }
                else
                {
                    formula += i.ToString() + "+"; // Add other numbers with "+"
                }
            }

            Console.WriteLine("Formula: " + formula);
            Console.WriteLine("Output: " + result);
        }
        else
        {
            Console.WriteLine("Invalid input");
        }

        Console.WriteLine("=================================");

        // Experiment 3
        Console.Write("Third Program- Input:");
        int number3 = Convert.ToInt32(Console.ReadLine());
        if (number3 > 0)
        {
            for (int i = number3; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
        }
        else
        {
            Console.WriteLine("Invalid input");
        }
    }
}
