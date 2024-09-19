using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Övning_3a.Animals;
using Övning_3a.Errors;


namespace Övning_3a
{
    class Main
    {
        

        //Person person = new Person();
        //person.Age = 15;
        //person.FName = "Sara";
        //person.LName = "Schmidt";
        //person.Height = 1.68;
        //person.Weight = 64.6;

        public void Run()
        {

            //3.1
            Person person1 = PersonHandler.CreatePerson(16, "Emil", "Oskarsson", 1.79, 70.0);
            Person person2 = PersonHandler.CreatePerson(18, "Siri", "Jansson", 1.65, 65.5);


            //3.2
            TextInputError textInputError = new TextInputError();
            TextInputError textInputError1 = new TextInputError();
            NumericInputError numericInputError = new NumericInputError();
            NumericInputError numericInputError2 = new NumericInputError();
            NullInputError nullInputError = new NullInputError();
            BlankInputError blankInputError = new BlankInputError();
            ExcessInputError excessInputError = new ExcessInputError();

            List<UserError> UserErrors = new List<UserError> { numericInputError, numericInputError2, textInputError, textInputError1, nullInputError, blankInputError, excessInputError };


            foreach (UserError error in UserErrors)
            {
                Console.WriteLine( error.UEMessage());
            }

            //3.3

            Horse horse = new Horse("sarah", 136, 8, 2.3);
            Dog dog = new Dog("Tony", 36, 5, 10);
            Hedgehog hedgehog = new Hedgehog("Charles", 0.8, 2, 876);
            Worm worm = new Worm("Steve", 0.002, 1, 0.05);
            Bird bird = new Bird("Chika", 0.4, 2, 1.5);
            Wolf wolf = new Wolf("Gordon", 15, 9, 12);
            Swan swan = new Swan("Frida", 16, 3, 2, true);
            Pelican pelican = new Pelican("George", 12, 7, 2.3, 12.3);
            Flamingo flamingo = new Flamingo("Tina", 8.2, 12, 2.4, true);

            WolfMan wolfman = new WolfMan("Jacob", 82, 19, 8);

            List<Animal> animalList = new List<Animal> { horse, dog, hedgehog, worm, bird, wolf, swan, pelican, flamingo, wolfman };

            foreach (Animal animal in animalList)
            {
                Console.WriteLine(animal.Stats());
                animal.DoSound();
                if (animal is  IPerson)
                {
                    (animal as IPerson).Talk();
                }
                else if (animal is Dog)
                {
                    Console.WriteLine((animal as Dog).Sit());
                }
            }

            foreach (Animal animal in animalList)
            {
                if (animal is Dog)
                {
                    Console.WriteLine(animal.Stats());
                }
            }



        }
       
    }
}
