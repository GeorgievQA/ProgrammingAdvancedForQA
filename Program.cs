using System.ComponentModel.Design;

namespace _02.SummerClothing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double temp = double.Parse(Console.ReadLine());
            string TimeOfDay = Console.ReadLine();
            string outfit = "";
            string shoes = "";
            if (10 <= temp && temp <= 18)
            {
                if (TimeOfDay == "Morning")
                {
                    outfit = "Sweatshirt";
                    shoes = "Sneakers";
                }
                else if (TimeOfDay == "Afternoon")
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
                else if (TimeOfDay == "Evening")
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
            }
            else if (18 < temp && temp <= 24)
            {
                if (TimeOfDay == "Morning")
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
                else if (TimeOfDay == "Afternoon")
                {
                    outfit = "T-Shirt";
                    shoes = "Sandals";
                }
                else if (TimeOfDay == "Evening")
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
            }
            else if (temp >= 25)
            {
                if (TimeOfDay == "Morning")
                {
                    outfit = "T-Shirt";
                    shoes = "Sandals";
                }
                else if (TimeOfDay == "Afternoon")
                {
                    outfit = "Swim Suit";
                    shoes = "Barefoot";
                }
                else if (TimeOfDay == "Evening")
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
            }
            Console.WriteLine($"It's {temp} degrees, get your {outfit} and {shoes}.");
        }
    }
}