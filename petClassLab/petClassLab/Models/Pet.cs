using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace petClassLab.Models
{
    class Pet
    {
        public string Name { get;}
        public string Owner { get; private set; }
        public int Age { get;}
        public string Description { get;}
        public bool IsHouseTrained { get; private set; }

        public Pet(string name, int age, string description)
        {
            Name = name;
            Age = age;
            Description = description;
            Owner = "no one";
            IsHouseTrained = false;
        }
        public override string ToString()
        {
            return $"Name: {Name}\n" +
                   $"Age: {Age}\n" +
                   $"About: {Description}\n" +
                   $"Owner: {Owner}\n" +
                   $"Trained: {IsHouseTrained}\n";
        }
        public void SetOwner(string newOwner)
        {
            Owner = newOwner;
        }
        public void Train()
        {
            IsHouseTrained = true;
        }
    }
}
