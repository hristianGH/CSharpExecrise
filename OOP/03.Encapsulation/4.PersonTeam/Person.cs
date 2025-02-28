﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.PersonTeam
{
    public class Person
    {
        public Person(string n, int a)
        {
            Name = n;
            Age = a;
        }
        public Person(string n, int a, double w) : this(n, a)
        {
            Wage = w;
        }
        public String Name { get; private set; }
        public int Age { get; private set; }
        public double Wage { get; private set; }
        public void WageInc(double perC)
        {
            if (Age >= 30)
            {
                perC = 0.01 * perC;
                Wage = Wage + (Wage * perC);
            }
            else
            {
                perC = 0.005 * perC;
                Wage = Wage + (Wage * perC);
            }
        }
        public override string ToString()
        {
            //return $"{Name} is {Age} years old.";
            return $"{Name} receives {Wage:f2} leva.";
        }

    }
}
