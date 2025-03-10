using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface IAnimal
    {
        List<Animal> Animals { get; set; }

        //method for creating animals
        void AddAnimal(Animal animal);

        //method for displaying animals
        List<Animal> GetAnimals();
    }
}
