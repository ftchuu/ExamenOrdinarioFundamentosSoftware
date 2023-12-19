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

        public void RegistraPersonaNueva()
        {
            Console.WriteLine("¿Cómo se llama la persona que quiere registrar?");
            string nombrePersona = Console.ReadLine();
            Persona nuevaPersona = new Persona(nombrePersona);
            personasRegistradas.Add(nuevaPersona);
        }

    }
}
