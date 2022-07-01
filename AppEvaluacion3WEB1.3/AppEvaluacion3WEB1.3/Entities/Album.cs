using System;
using System.Collections.Generic;
using System.Text;

namespace AppEvaluacion3WEB1._3.Entities
{
    public class Album
    {
        public string ImagenURL { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string FechaLanzamiento { get; set; }
        public string Discografica { get; set; }
        public string Generos { get; set; }

        public List<Song> Canciones { get; set; }
    }
}
