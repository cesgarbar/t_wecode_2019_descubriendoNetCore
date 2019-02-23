using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AnimalesFantasticosDTO;
using AnimalesFantasticosManager;
using Microsoft.AspNetCore.Mvc;

namespace AnimalesFantasticos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnimalesController : ControllerBase
    {
        public IAnimalesManager animalesManager = new AnimalesManager();

        // GET api/animales 
        [HttpGet]
        public ActionResult<List<AnimalesDTO>> Get()
        {
            List<AnimalesDTO> resultList = new List<AnimalesDTO>(); try
            {
                resultList = animalesManager.GetAnimalesList();
                return resultList;

            }
            catch (Exception ex)
            {
                return BadRequest("Error del servidor" + ex.Message);
            }
        }

        // GET api/animales/name 
        [HttpGet("{name}")]
        public ActionResult<AnimalesDTO> Get(string name)
        {
            AnimalesDTO result = null;


            try
            {
                result = animalesManager.GetAnimalByName(name);
                return result;

            }
            catch (Exception exception)
            {
                return BadRequest("Error del servidor");
            }
        }

        // POST api/animales 
        [HttpPost]
        public ActionResult<bool> Post([FromBody] AnimalesDTO animal)
        {
            bool isOK = true; try
            {
                animalesManager.CreateAnimal(animal); return isOK;
            }
            catch (Exception exception)
            {
                return BadRequest("Error del servidor");
            }
        }

        // PUT api/animales/5 
        [HttpPut("{id}")]
        public ActionResult<bool> Put(int id, [FromBody] AnimalesDTO animal)
        {
            bool isOK = true; try
            {
                animalesManager.UpdateAnimal(animal); return isOK;
            }
            catch (Exception exception)
            {
                return BadRequest("Error del servidor");
            }
        }

        // DELETE api/animales/5 
        [HttpDelete("{id}")]
        public ActionResult<bool> Delete(int id)
        {
            bool isOK = true; try
            {
                animalesManager.DeleteAnimalById(id); return isOK;
            }
            catch (Exception exception)
            {
                return BadRequest("Error del servidor");
            }
        }
    }


}
