using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenOrdinarioFundamentosSoftware.Clases
{
    public class Gato : IMascota
    {
        private static int contadorGatos = 1;
        private const int EdadMaxGato = 18;

        public string Id { get; }
        public string Nombre { get; }
        public int Edad { get; }
        public Temperamento Temperamento { get; }
        public Dueño Dueño { get; private set; }

        public Gato(string nombre, int edad, Temperamento temperamento, Dueño dueño = null)
        {
            Id = $"Gato-{contadorGatos++}";
            Nombre = nombre;
            Edad = (edad >= 0 && edad <= EdadMaxGato) ? edad : EdadMaxGato;
            Temperamento = temperamento;
            Dueño = dueño;
        }

        public void HacerRuido()
        {
            Console.WriteLine("Miau Miau");
        }

        public void CambiarDueño(Persona nuevoDueño)
        {
            if (nuevoDueño != null)
            {
                Dueño = nuevoDueño;
                Console.WriteLine($"El gato {Nombre} ha cambiado su dueño a {nuevoDueño.Nombre}");
            }
        }

        // Otros métodos específicos de los gatos
    }
}
