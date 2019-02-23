using AnimalesFantasticosDBContext.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalesFantasticosBusinessLogic
{
    public interface IAnimalesRepository : IDisposable
    {
        List<Animales> GetAnimales(); Animales GetAnimalById(int animalId);
        void InsertAnimal(Animales animalToAdd); void DeleteAnimal(int animalId);
        void UpdateAnimal(Animales animalToUpdate); void saveChanges();
    }

}
