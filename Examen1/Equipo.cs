using System;
namespace Examen1
{
    public class Equipo
    {
        public string id { get; set; }
        public string nom { get; set; }
        public Tipo tipo { get; set; }
        public DateTime fecha { get; set; }
        public bool persona { get; set; }
        public Aula aula { get; set; }


        public Equipo()
        {
        }

        public Equipo(string id, string nom, Tipo tipo, DateTime fecha, bool persona, Aula aula)
        {
            this.id = id;
            this.nom = nom;
            this.tipo = tipo;
            this.fecha = fecha;
            this.persona = persona;
            this.aula = aula;
        }

        public Equipo(string id)
        {
            this.id = id;
        }
    }
}
