using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public class Animal : IAnimal
    {
        public List<Animal> Animals { get; set; } = new List<Animal>();
        public string Name { get; set; }
        
        public Animal(string name)
        {
            this.Name = name;
        }

        public Animal() { }

        public void AddAnimal(Animal animal)
        {
            this.Animals.Add(animal);
        }

        public List<Animal> GetAnimals() => this.Animals;
    }
}
