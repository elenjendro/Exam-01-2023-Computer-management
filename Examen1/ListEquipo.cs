using System;
using System.Collections.Generic;

namespace Examen1
{
    public class ListEquipo: List<Equipo>
    {

        public ListEquipo()
        {

        }

        public Equipo BuscarEquipo(Equipo equipo)
        {
            foreach (Equipo equipo1 in this)
            {
                if (equipo.id.Equals(equipo1.id))
                {
                    return equipo1;
                }
            }
            return null;
        }
        public bool Insertar(Equipo equipo)
        {
            if (this.BuscarEquipo(equipo) == null)
            {
                this.Add(equipo);
                return true;
            }
           
            return false;
        }
        public bool ModificarEquipo(string id, Aula aula, bool persona)
        {
            foreach(Equipo equipo1 in this)
            {
                if (equipo1.id.Equals(id))
                {
                    equipo1.aula = aula;
                    equipo1.persona = persona;
                    return true;
                }
            }
            return false;
        }

        public void datosmock()
        {
            this.Insertar(
                new Equipo(
                    "1234",
                    "Ord1",
                    Tipo.ordenador,
                    DateTime.Now,
                    true,
                    Aula.Barroca
                    )
                );
            this.Insertar(
                new Equipo(
                    "2234",
                    "Ord2",
                    Tipo.ordenador,
                    DateTime.Now,
                    false,
                    Aula.Barroca
                    )
                );
            this.Insertar(
                new Equipo(
                    "3234",
                    "Imp1",
                    Tipo.impresora,
                    DateTime.Now,
                    true,
                    Aula.Barroca
                    )
                );
            this.Insertar(
                new Equipo(
                    "4234",
                    "Ord4",
                    Tipo.ordenador,
                    DateTime.Now,
                    true,
                    Aula.S41
                    )
                );
            this.Insertar(
               new Equipo(
                   "5234",
                   "Ord5",
                   Tipo.ordenador,
                   DateTime.Now,
                   false,
                   Aula.S41
                   )
               );
            this.Insertar(
               new Equipo(
                   "6234",
                   "Tab1",
                   Tipo.tablet,
                   DateTime.Now,
                   false,
                   Aula.S40
                   )
               );
        }
    }
}
