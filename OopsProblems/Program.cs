using OopsProblems;
using System;
using System.Security.Principal;

namespace ExmapleOops
{
    class Oopscodes
    {
        static void Main(string[] args)
        {

            //--------For Inheritance
            //Dog myDog = new Dog
            //{
            //    Name = "Buddy", Age = 3, Breed = "Labrador"
            //};
            //Console.WriteLine($"Name: {myDog.Name}");
            //Console.WriteLine($"Age: {myDog.Age}");
            //Console.WriteLine($"Breed: {myDog.Breed}");
            //myDog.Eat();
            //myDog.Sleep();
            //myDog.Bark();

            //-------For Polymorphism
            PolymorphismShape shape1 = new Circle();
            PolymorphismShape shape2 = new Square();

            shape1.Draw();
            shape2.Draw();

            //--------Encapsulation

            //EncapsulationBankAcc acc = new EncapsulationBankAcc();
            //acc.AccountHolder = "Lokesh";
            //acc.Deposit(10000);
            //acc.Withdraw(2000);

            //Console.WriteLine($"Account Holder: {acc.AccountHolder}");
            //Console.WriteLine($"Balance: {acc.Balance}");

            //--------Abstraction

            // Using abstraction with the abstract class
            //Shape circleShape = new Circlee(5.0);
            //circleShape.Draw();
            //circleShape.DisplayArea();

            //Console.WriteLine();

            //// Using abstraction with the interface
            //IDrawable circleDrawable = new Circlee(3.0);
            //circleDrawable.Draw();
        }
    }
}
