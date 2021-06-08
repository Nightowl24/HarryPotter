using System;

namespace Choose_Your_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Hogwarts");
            DisplayMenu();
        }
        public static void DisplayMenu()
        {
            SortingHat mySortingHat = new SortingHat();
            bool hat = true;
            while (hat)
            {



                Console.WriteLine("What would you like to do?");
                Console.WriteLine("1. Name your Wizard");
                Console.WriteLine("2. Status Of Wizard");
                Console.WriteLine("3. Go To Class");
                Console.WriteLine("4. Sneak Out At Night ");
                Console.WriteLine("5. Play A Game Of Quidditch ");
                Console.WriteLine("6. Exit");

                string menuChoice = Console.ReadLine();

                switch (menuChoice)
                {

                    case "1":
                        Console.WriteLine("What Is Your Wizard Name?");
                        string input = Console.ReadLine();
                        if (string.IsNullOrEmpty(input))
                        {
                            Console.WriteLine("The name can't be empty!  Please try again. ");
                            input = Console.ReadLine();
                        }
                        mySortingHat.SetName(input);



                        Console.WriteLine("What House Do You Perfer?\nGryffindor\nHufflepuff\nRavenclaw\nSlytherin");
                        input = Console.ReadLine();
                        if (string.IsNullOrEmpty(input))
                        {
                            Console.WriteLine("The name can't be empty!  Please try again. ");
                            input = Console.ReadLine();
                        }
                        mySortingHat.SetHouse(input);
                        break;
                    case "2":
                        mySortingHat.WizardStatus();
                        break;
                    case "3":
                        mySortingHat.StudyTime();
                        break;

                    case "4":
                        mySortingHat.SneakOut();
                        break;

                    case "5":
                        mySortingHat.QuidditchPlay();
                        break;

                    case "6":
                        Console.WriteLine("Thank you for coming to Hogwarts");
                        hat = false;
                        break;


                }
                Console.WriteLine("Press any key to continue");
                Console.ReadKey();
                Console.Clear();
            }

        }
    }
}
