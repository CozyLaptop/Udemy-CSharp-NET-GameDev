using System;

namespace IntermediateCSharp
{
    enum Meal
    {
        Breakfast,
        Lunch,
        Dinner
    }
    class Program
    {
        static void Main(string[] args)
        {
            Meal mostImportantMeal = Meal.Breakfast;

            if(mostImportantMeal == Meal.Breakfast)
            {
                Console.WriteLine("eggs and bacon");
            }
            Console.WriteLine((Meal)0);
            Console.WriteLine((int)Meal.Lunch);
            Console.WriteLine((int)Meal.Dinner);
        }
    }
}
