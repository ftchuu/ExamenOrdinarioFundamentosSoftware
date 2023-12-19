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

        private string _id;
        public string Id { get { return _id; } }
        private string _nombre;
        public string Nombre { get { return _nombre; } }
        public int Edad { get; set; }
        public Temperamento Temperamento { get; }
        public Persona Dueño { get; set; }

        public Perro(string nombre, int edad, Temperamento temperamento, Persona dueño = null)
        {
            Id = $"Perro-{contadorPerros++}";
            Nombre = nombre;
            Edad = (edad >= 0 && edad <= EdadMaxPerro) ? edad : EdadMaxPerro;
            Temperamento = temperamento;
            Persona = dueño;
        }

         void HacerRuido()
        {
            Console.WriteLine("Guau Guau");
        }

        void CambiarDueño(Persona nuevoDueño)
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
