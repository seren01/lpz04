﻿using System;
using System.Collections.Generic;
using static System.Console;

namespace Packt.Shared
{
    public partial class Person : object
    {
        public string Name;
        public DateTime DateOfBirth;
        public WondersOfTheAncientWorld FavoriteAncientWonder;
        public WondersOfTheAncientWorld BucketList;

        public List<Person> Children = new List<Person>();

        public const string Species = "Homo Sapien";

        public readonly string HomePlanet = "Earth";
        public readonly DateTime Instantiated;
        public Person()
        {
            Name = "Unknown";
            Instantiated = DateTime.Now;
        }

        public Person(string initialName, string homePlanet)
        {
            Name = initialName;
            HomePlanet = homePlanet;
            Instantiated = DateTime.Now;
        }

        public void WriteToConsole()
        {
            WriteLine($"{Name} was born on a {DateOfBirth:dddd}.");
        }
        public string GetOrigin()
        {
            return $"{Name} was born on {HomePlanet}.";
        }

        public (string, int) GetFruit()
        {
            return ("Apples", 5);
        }

        public (string Name, int Number) GetNamedFruit()
        {
            return (Name: "Apples", Number: 5);
        }

        public string SayHello()
        {
            return $"{Name} say 'Hi~~'";
        }

        public string SayHello(string name)
        {
            return $"{Name} say 'Hi {name}'";
        }

        public string OptimalsParameters(
            string command = "Run!",
            double number = 0.0,
            bool active = true
        )
        {
            return string.Format(
                format: "command is {0}, number is {1}, active is {2}",
                arg0: command, arg1: number, arg2: active);
        }

        public void PassingParameters(int x, ref int y, out int z)
        {
            z = 99; //нет значения по-умолчанию, должны быть инициализированы в методе
            
            //инкрементирование каждого параметра
            x++;
            y++;
            z++;
        }
    }
}
