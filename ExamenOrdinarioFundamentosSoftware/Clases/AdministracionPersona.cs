using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenOrdinarioFundamentosSoftware.Clases
{
    public class AdministracionPersona
    {
        public List<Persona> personasRegistradas;
        public AdministracionPersona()
        {
            personasRegistradas = new List<Persona>();
        }
        public void MostrarPersonasRegistradas()
        {
            foreach(var persona in personasRegistradas)
            {
                Console.WriteLine($"{persona.Id} - {persona.Name}");
            }
        }

    }
}
