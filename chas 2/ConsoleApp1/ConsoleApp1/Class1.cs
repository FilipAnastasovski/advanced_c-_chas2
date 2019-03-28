
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    abstract class Animal
    {
        public abstract bool Feathers { get; set; }
        public virtual string Describe()
        {
            return "This is info for the animal. ";
        }
        public abstract string Features();
        public abstract bool HasFeathers();
    }

    class Dog : Animal
    {
        public override bool Feathers { get; set; }
        public override string Describe()
        {
            return base.Describe() + " This is a dog. ";
        }
        public override string Features()
        {
            return "Can bark";
        }
        public override bool HasFeathers()
        {
            return false;
        }
    }

    class Labrador : Dog 
    {
        public override bool Feathers { get; set; }
        public override string Describe()
        {
            return base.Describe() + " This is a golden dog";
        }
        public override string Features()
        {
            return "Can bark";
        }
        public override bool HasFeathers()
        {
            return false;
        }
    }

    class Bird : Animal
    {
        public override bool Feathers { get; set; }
        public override string Describe()
        {
            return base.Describe() + " This is a bird";
        }
        public override string Features()
        {
            return "Can fly";
        }
        public override bool HasFeathers()
        {
            return true;
        }
    }

}