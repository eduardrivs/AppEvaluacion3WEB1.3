using System;
using System.Collections.Generic;
using System.Text;

namespace AppEvaluacion3WEB1._3.Entities
{
    public class CatDireccionVM
    {
        public int Id { get; set; }
        public int CodigoPostal{ get; set; }
        public int IdEstado { get; set; }
        public int IdMunicipio { get; set; }
        public int IdColonia { get; set; }
    }
}
