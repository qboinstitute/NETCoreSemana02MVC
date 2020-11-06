using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NETCoreSemana02MVC.Models
{
    public class Persona
    {
        public int personaID { get; set; }

        public string personaNombre { get; set; }

        public string personaCorreo { get; set; }

        public Persona()
        {

        }

        public Persona(int id, string nombre, string correo)
        {
            this.personaID = id;
            this.personaNombre = nombre;
            this.personaCorreo = correo;
        }


    }
}
