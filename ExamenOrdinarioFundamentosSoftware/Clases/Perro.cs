using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenOrdinarioFundamentosSoftware.Clases
{
    public class Perro : IMascota
    {
        private static int contadorPerros = 1;
        private const int EdadMaxPerro = 14;

        public string Id { get; }
        public string Nombre { get; }
        public int Edad { get; }
        public Temperamento Temperamento { get; }
        public Persona Dueño { get; private set; }

        public Perro(string nombre, int edad, Temperamento temperamento, Persona dueño = null)
        {
            Id = $"Perro-{contadorPerros++}";
            Nombre = nombre;
            Edad = (edad >= 0 && edad <= EdadMaxPerro) ? edad : EdadMaxPerro;
            Temperamento = temperamento;
            Persona = dueño;
        }

        public void HacerRuido()
        {
            Console.WriteLine("Guau Guau");
        }

        public void CambiarDueño(Persona nuevoDueño)
        {
            if (nuevoDueño != null)
            {
                Persona = nuevoDueño;
                Console.WriteLine($"El perro {Nombre} ha cambiado su dueño a {nuevoDueño.Nombre}");
            }
        }

        // Otros métodos específicos de los perros
    }
}
