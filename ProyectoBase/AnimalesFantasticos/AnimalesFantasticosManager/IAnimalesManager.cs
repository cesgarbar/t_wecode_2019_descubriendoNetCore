using AnimalesFantasticosDTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalesFantasticosManager
{
    public interface IAnimalesManager
    {
        List<AnimalesDTO> GetAnimalesList();
        AnimalesDTO GetAnimalByName(string animalName);
        void UpdateAnimal(AnimalesDTO animalToUpdate);
        void DeleteAnimalById(int animalId);
        void CreateAnimal(AnimalesDTO animalToCreate);
    }

}
