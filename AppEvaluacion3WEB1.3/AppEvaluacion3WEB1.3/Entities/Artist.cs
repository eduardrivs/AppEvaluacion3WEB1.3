using System;
using System.Collections.Generic;
using System.Text;

namespace AppEvaluacion3WEB1._3.Entities
{
    public class Artist
    {
        public string ImagenURL{ get; set; }
        public string Nombre { get; set; }
        public string Generos { get; set; }
        public int Edad { get; set; }
        public string Descripcion { get; set; }
        public List<Album> Discografia{ get; set; }

    }
}
