using AnimalesFantasticosBusinessLogic;
using AnimalesFantasticosDBContext.Models;
using AnimalesFantasticosDTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalesFantasticosManager
{
    public class AnimalesManager : IAnimalesManager
    {
        public IAnimalesRepository animalesRepository;

        public AnimalesManager()
        {
            animalesRepository = new AnimalesRepository(new animalesfantasticosContext());
        }

        public AnimalesManager(IAnimalesRepository animalesRepository)
        {
            this.animalesRepository = animalesRepository;
        }

        public void DeleteAnimalById(int animalId)
        {
            animalesRepository.DeleteAnimal(animalId);
        }

        public AnimalesDTO GetAnimalByName(string animalName)
        {
            AnimalesDTO animalResult = null;

            List<Animales> allAnimales = animalesRepository.GetAnimales();
            Animales currentAnimal = allAnimales.Find(x => x.Nombre == animalName);
            if (currentAnimal != null)
            {

                animalResult = new AnimalesDTO()
                    .createAnimalesDTO(currentAnimal);
            }

            return animalResult;
        }

        public List<AnimalesDTO> GetAnimalesList()
        {
            List<AnimalesDTO> animalesList = new List<AnimalesDTO>();

            List<Animales> allAnimales = animalesRepository.GetAnimales();
            foreach (var animal in allAnimales)
            {
                AnimalesDTO currentAnimal = new AnimalesDTO()
                .createAnimalesDTO(animal); animalesList.Add(currentAnimal);
            }

            return animalesList;
        }

        public void UpdateAnimal(AnimalesDTO animalToUpdate)
        {
            Animales animal = new AnimalesDTO().createAnimales(animalToUpdate);
            animalesRepository.UpdateAnimal(animal);
        }

        public void CreateAnimal(AnimalesDTO animalToCreate)
        {
            Animales animal = new AnimalesDTO().createAnimales(animalToCreate);
            animalesRepository.InsertAnimal(animal);

        }
    }


}
