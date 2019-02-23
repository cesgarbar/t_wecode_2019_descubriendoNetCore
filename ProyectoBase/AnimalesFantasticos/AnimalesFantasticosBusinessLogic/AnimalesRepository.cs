using AnimalesFantasticosDBContext.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnimalesFantasticosBusinessLogic
{
    public class AnimalesRepository : IAnimalesRepository
    {
        private animalesfantasticosContext context;
        private bool disposed = false;

        public AnimalesRepository(animalesfantasticosContext context)
        {
            this.context = context;
        }

        public void DeleteAnimal(int animalId)
        {
            Animales animalToDelete = context.Animales.Find(animalId);
            context.Animales.Remove(animalToDelete);
            saveChanges();
        }

        public Animales GetAnimalById(int animalId)
        {
            Animales animalObtained = context.Animales.Find(animalId);

            return animalObtained;
        }
        public List<Animales> GetAnimales()
        {
            List<Animales> allAnimales = context.Animales.ToList();

            return allAnimales;
        }

        public void InsertAnimal(Animales animalToAdd)
        {
            context.Animales.Add(animalToAdd);
            saveChanges();
        }

        public void saveChanges()
        {
            context.SaveChanges();
        }

        public void UpdateAnimal(Animales animalToUpdate)
        {
            context.Animales.Update(animalToUpdate);
            saveChanges();
        }
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true); GC.SuppressFinalize(this);
        }
    }

}
