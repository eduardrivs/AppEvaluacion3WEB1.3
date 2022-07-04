using System;
using System.Collections.Generic;
using System.Text;

namespace AppEvaluacion3WEB1._3.Entities
{
    public class PersonaVM
    {

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string APaterno { get; set; }
        public string AMaterno { get; set; }
        public string Telefono { get; set; }
        public int IdEstado { get; set; }
        public int IdMunicipio { get; set; }
        public string Colonia { get; set; }
        public string Direccion { get; set; }

    }
}
