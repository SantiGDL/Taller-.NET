using System.Runtime.CompilerServices;
using Actividad_2.Modelos;
using Microsoft.AspNetCore.Mvc;

namespace Actividad_2.Controllers
{
    [ApiController]
    [Route("api/tareas")]
    public class TareaController : Controller
    {
        //Esta variable sirve para loguar informacion (es como un console log)
        private readonly ILogger<TareaController> _logger;
        private readonly IList<Tarea> _listaTareas = new List<Tarea>(); //hago readonly la lista como tal, no su contenido, para que no borren la lista completa, pueden borrar elementos, no ella completa
        
        
        //Constructor de TareaController
        public TareaController(ILogger <TareaController> _logger)
        {
            this._logger = _logger;
            this._listaTareas.Add(new Tarea(1, "Tarea verduleria 2", "La primera" , 3 , "Gabriel Aramburu", new DateOnly(2026,3,12)));
            this._listaTareas.Add(new Tarea(2, "Tarea 2", "La segunda" , 2 , "Gabriel Aramburu", new DateOnly(2026,6,15)));
            this._listaTareas.Add(new Tarea(3, "Tarea 3", "La tercera" , 6 , "Gabriel Aramburu", new DateOnly(2026,3,12)));
            this._listaTareas.Add(new Tarea(4, "Tarea 4", "La cuarta" , 8 , "Gabriel Aramburu", new DateOnly(2026,3,12)));
            this._listaTareas.Add(new Tarea(5, "Tarea 5", "La quinta" , 29 , "Gabriel Aramburu", new DateOnly(2026,3,12)));
            this._logger.LogInformation("Carga inicial de Tareas realizada exitosamente");
        }
        
        //A este no le pongo Route porque la Route es el caso base [Route("api/tareas")], si no lo hiciera así me daria 404 al entrar a api/tareas
        [HttpGet]
        public ActionResult<IList<Tarea>> GetAll()  //ActionResult es como el Response de Java, luego le indico el tipo dentro de los <>. Después va el nombre que en este caso es GetAll y no lleva parametros
        {
            _logger.LogInformation("Retorno todas las tareas");
            return Ok(_listaTareas);
        }

        
        [HttpGet]
        [Route("{id}")]     //le paso la id el la url y me retona la tarea que está en la lista
        public ActionResult<Tarea> GetTareaPorId(int id)
        {
            _logger.LogInformation($"Retorno tarea numero {id}");
            //Uso esta variable auxiliar porque puede ser null si el usuario pregunta por una tarea inexistente
            Tarea? _tareaBuscada = _listaTareas.FirstOrDefault(tarea => tarea.Id == id);
            
            if (_tareaBuscada == null)
            {
                return NotFound($"La tarea con id {id} no existe");    
            }
            
            return Ok(_tareaBuscada);
        }

        [HttpPost] //Obtengo los parametros desde el body
        public ActionResult Crear([FromBody] Tarea nuevaTarea)
        {
            _logger.LogInformation("Inserto nueva tarea");
            this._listaTareas.Add(nuevaTarea);

            return Ok();
        }

        [HttpDelete]
        [Route("{id}")]
        public ActionResult Elimiar(int id)
        {
            _logger.LogInformation($"Elimino tarea {id}");
            this._listaTareas.RemoveAt(id);
            
            return Ok();
        }
        
        
        
        
        
        
        
        
    }
    
   

    
}