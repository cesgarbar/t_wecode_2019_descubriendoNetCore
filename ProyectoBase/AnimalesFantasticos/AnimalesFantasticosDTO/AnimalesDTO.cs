using AnimalesFantasticosDBContext.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalesFantasticosDTO
{
    public class AnimalesDTO
    {
        public AnimalesDTO()
        {

        }

        public int id { get; set; }
        public string nombre { get; set; }
        public string especie { get; set; }
        public int? edad { get; set; }

        public bool isJunior
        {
            get
            {
                return edad < 3;
            }
            set { }
        }

        public bool isSenior
        {
            get
            {
                return edad > 10;
            }
            set { }
        }

        public AnimalesDTO createAnimalesDTO(Animales animalToCreate)
        {
            AnimalesDTO animal = new AnimalesDTO();
            animal.nombre = animalToCreate.Nombre;
            animal.especie = animalToCreate.Especie;
            animal.edad = animalToCreate.Edad;
            animal.id = animalToCreate.Id;

            return animal;
        }

        public Animales createAnimales(AnimalesDTO animalDTOToCreate)
        {
            Animales animal = new Animales();
            animal.Nombre = animalDTOToCreate.nombre;
            animal.Especie = animalDTOToCreate.especie;
            animal.Edad = animalDTOToCreate.edad;
            animal.Id = animalDTOToCreate.id;

            return animal;
        }

        public Animales createAnimales()
        {
            Animales animal = new Animales();
            animal.Nombre = nombre;
            animal.Especie = especie;
            animal.Edad = edad;
            animal.Id = id;

            return animal;
        }

    }


}
