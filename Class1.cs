using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Choose_Your_Class
{
    public class SortingHat
    {
        public string Name { get; set; }
        public string House { get; set; }
        public int Health { get; set; }
        public int Magic { get; set; }
        public int Energy { get; set; }
        public SortingHat()
        {
            Energy = 200;
            Health = 200;
            Magic = 200;
        }

        public void SetName(string name)
        {
            Name = name;
        }
        public string GetName()
        {
            return Name;
        }
        public void SetHouse(string house)
        {
            House = house;
        }
        public string GetHouse()
        {
            return House;
        }


        public void GetHouse(string house)
        {
            House = house;

        }
        public string SetHouse()
        {
            return House;
        }
        public void WizardStatus()
        {
            Console.WriteLine($"{Name}'s Status\nHealth: {Health} \nEnergy: {Energy} \nMagic: {Magic}\n");
        }
        public void StudyTime()
        {
            WizardStatus();
            Console.WriteLine("You have chosen to study\nHere's a status boost");
            Energy += 100;
            Health += 100;
            Magic += 100;
            WizardStatus();
        }
        public void SneakOut()
        {
            Console.WriteLine("You decied to sneak out into the woods.\nUnfortunately you ran into a centaur\nYou Took some Damage");
            Energy -= 60;
            Health -= 60;
            Magic -= 60;
            WizardStatus();
            Console.WriteLine("Do you want to go further into the woods?");
            string input = Console.ReadLine().ToUpper();
            if (input == "Y")
            {
                Console.WriteLine("A little farther in the wood you run into a pack of spiders\nBut fear not the car is here to save you");
                Energy -= 60;
                Health -= 60;
                Magic -= 60;
                WizardStatus();
            }
            else if (input == "N")
            {
                Console.WriteLine("It best you get back home");
            }
        }
        public void QuidditchPlay()
        {
            Console.WriteLine($"Welcome to Quidditch.\nYour team is {House} and you play Ravenclaw");
            Console.WriteLine("Do You want to be the star of your team?");
            string input = Console.ReadLine().ToUpper();
            if (input == "Y")
            {

                Console.WriteLine($"You scored all the points. The score was {House} 90 - Ravenclaw 60\nYou caught the golden snitch twice and scored 3 goals");
                Energy -= 30;
                Health += 30;
                Magic -= 30;
                WizardStatus();
            }
            else if (input == "N")
            {

                Console.WriteLine($"You scored twice. The score was Ravenclaw 90 - {House} 60\nYou caught the golden snitch twice and scored 3 goals");
                Energy -= 60;
                Health -= 60;
                Magic -= 60;
                WizardStatus();

            }

        }










    }
}
