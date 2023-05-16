using Microsoft.AspNetCore.Mvc;

namespace Ejemplo_de_Endpoint.Controllers
{
    //Vamos a tener un controller para cada una de nuestras entidades, en el cuál vamos a escribir nuestros métodos.

    [ApiController] //Lo primero que se hace al crear la clase es poner este decorador 
    [Route("api/alumnos")]//Junto con la ruta que vamos utilizar para nuestro controller
    public class AlumnoController : ControllerBase //Heredamos de la clase Controller, es una clase propia de .net
    {
        List<string>  alumnos = new List<string>() { "Juan", "Pedro", "Tomás" }; //Para este ejemplo no voy a utilizar entidades, si no que esta lista

        [HttpGet("GetAlumnos")]//Dentro de la clase instanciamos nuestro primer endpoint, indicamos en el decorador que va utilizar el método Get, segui de la ruta que va a tener el mismo
        public ActionResult GetAlumno()
        {
            return Ok(alumnos);
        }


    }
}
