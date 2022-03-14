using System;
using Packt.Shared;
using static System.Console;

namespace PeopleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var bob = new Person();
            bob.Name = "Xie Lian";
            bob.DateOfBirth = new DateTime(600, 07, 15);
            WriteLine(
                format: "{0} was born on {1:dddd, d MMMM yyyy}",
                arg0: bob.Name,
                arg1: bob.DateOfBirth);

            var alice = new Person
            {
                Name = "Jiang Cheng",
                DateOfBirth = new DateTime(1413, 11, 5)
                };
                WriteLine(
                    format: "{0} was born on {1:dd MMM yy}",
                    arg0: alice.Name,
                    arg1: alice.DateOfBirth);
            
            bob.FavoriteAncientWonder = WondersOfTheAncientWorld.StatueOfZeusAtOlympia;
            WriteLine(
                format: "{0}'s favorite wonder is {1}. It's integer is {2}.",
                arg0: bob.Name,
                arg1: bob.FavoriteAncientWonder,
                arg2: (int)bob.FavoriteAncientWonder);

            bob.BucketList = WondersOfTheAncientWorld.HangingGardensOfBabylon | WondersOfTheAncientWorld.MausoleumAtHalicarnassus;
            // bob.BucketList = (WondersOfTheAncientWorld)18;
            WriteLine($"{bob.Name}'s bucket list is {bob.BucketList}");

            bob.Children.Add(new Person { Name = "Tun" });
            bob.Children.Add(new Person { Name = "Lingyuan" });
            WriteLine(
                $"{bob.Name} has {bob.Children.Count} children:");
            for (int child = 0; child < bob.Children.Count; child++)
            {
                WriteLine($" {bob.Children[child].Name}");
            }

            BankAccount.InterestRate = 0.012M;
            var jonesAccount = new BankAccount();
            jonesAccount.AccountName = "Mrs. Hua";
            jonesAccount.Balance = 240000;
            WriteLine(
                format: "{0} earned {1:C} interest.",
                arg0: jonesAccount.AccountName,
                arg1: jonesAccount.Balance * BankAccount.InterestRate);
            
            var gerrierAccount = new BankAccount();
            gerrierAccount.AccountName = "Ms. He";
            gerrierAccount.Balance = -100000;
            WriteLine(
                format: "{0} earned {1:C} interest.",
                arg0: gerrierAccount.AccountName,
                arg1: gerrierAccount.Balance * BankAccount.InterestRate);

            WriteLine($"{bob.Name} is a {Person.Species}");
            WriteLine($"{bob.Name} was born on {bob.HomePlanet}");

            var blankPerson = new Person();
            WriteLine(
                format: "{0} of {1} was created at {2:hh:mm:ss} on a {2:dddd}.",
                arg0: blankPerson.Name,
                arg1: blankPerson.HomePlanet,
                arg2: blankPerson.Instantiated);

            var gunny = new Person("Wei Ying", "Mars");
            WriteLine(
                format: "{0} of {1} was created at {2:hh:mm:ss} on a {2:dddd}.",
                arg0: gunny.Name,
                arg1: gunny.HomePlanet,
                arg2: gunny.Instantiated);

            bob.WriteToConsole();
            WriteLine(bob.GetOrigin());

            (string, int) fruit = bob.GetFruit();
            WriteLine($"{fruit.Item1}, {fruit.Item2} there are.");

            var fruitNamed = bob.GetNamedFruit();
            WriteLine($"There are {fruitNamed.Number} {fruitNamed.Name}.");

            var thing1 = ("Neville", 4);
            WriteLine($"{thing1.Item1} has {thing1.Item2} children.");
            var thing2 = (bob.Name, bob.Children.Count);
            WriteLine($"{thing2.Name} has {thing2.Count} children.");

            (string fruitName, int fruitNumber) = bob.GetFruit();
            WriteLine($"Deconstructed: {fruitName}, {fruitNumber}");

            WriteLine(bob.SayHello());
            WriteLine(bob.SayHello("San Lang"));

            WriteLine(bob.OptimalsParameters());
            WriteLine(bob.OptimalsParameters("Jump!", 98.5));
            WriteLine(bob.OptimalsParameters(
                number: 52.7, command: "Hide!"));
            WriteLine(bob.OptimalsParameters("Poce!", active: false));    
            
            int a = 10;
            int b = 20;
            int c = 30;
            WriteLine($"Before: a = {a}, b = {b}, c = {c}");
            bob.PassingParameters(a, ref b, out c);
            WriteLine($"After: a = {a}, b = {b}, c = {c}");

            int d = 10;
            int e = 20;
            WriteLine(
                $"Before: d = {d}, e = {e}, f doesn't exist yet!");
            // упрощенный синтаксис параметров out в C# 7.0
            bob.PassingParameters(d, ref e, out int f);
            WriteLine($"After: d = {d}, e = {e}, f = {f}");

            var sam = new Person
            {
                Name = "Kim Namjoon",
                DateOfBirth = new DateTime(1994, 9, 12)
            };
                WriteLine(sam.Origin);
                WriteLine(sam.Greeting);
                WriteLine(sam.Age);

            sam.FavoriteIceCream = "Chocolate Mint";
            WriteLine($"Namjoon's favorite ice-cream flavor is {sam.FavoriteIceCream}.");
            sam.FavoritePrimaryColor = "Green";
            WriteLine($"Namjoon's favorite primary color is {sam.FavoritePrimaryColor}.");

            sam.Children.Add(new Person { Name = "Jimin" });
            sam.Children.Add(new Person { Name = "Jungkook" });
            WriteLine($"Namjoon's first child is {sam.Children[0].Name}");
            WriteLine($"Namjoon's second child is {sam.Children[1].Name}");
            WriteLine($"Namjoon's first child is {sam[0].Name}");
            WriteLine($"Namjoon's second child is {sam[1].Name}");
        }
    }
}
