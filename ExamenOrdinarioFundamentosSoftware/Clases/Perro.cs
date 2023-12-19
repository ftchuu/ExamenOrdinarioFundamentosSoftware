using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ExamenOrdinarioFundamentosSoftware.Clases
{
    public class Perro : IMascota, IAcariciable, IBailarina
    {
        private static int contadorPerro = 1;
        private const int EdadMaxima = 14;

        public string Id { get; }
        public string Nombre { get; }
        public int Edad { get; set; }
        public Temperamento Temperamento { get; }
        public Persona Dueño { get; set; }

        public Perro(string nombre, int edad, Temperamento temperamento, Persona dueño)
        {
            Id = $"Perro-{contadorPerro++}";
            Nombre = nombre;
            Edad = (edad > EdadMaxima) ? EdadMaxima : edad;
            Temperamento = temperamento;
            Dueño = dueño;
        }

        public void HacerRuido()
        {
            Console.WriteLine("Guau Guau");
        }

        public void CambiarDueño(Persona nuevoDueño)
        {
            Console.WriteLine($"{Nombre} ha cambiado su dueño a {nuevoDueño.Name}");
            Dueño = nuevoDueño;
        }

        public void SerAcariciado()
        {
            Console.WriteLine($"{Nombre} está siendo acariciado");
        }

        public void ResponderACaricia()
        {
            MoverCola();
        }

        private void MoverCola()
        {
            Console.WriteLine($"{Nombre} está moviendo la cola.");
        }

        public void Bailar()
        {
            Console.WriteLine($"{Nombre} está sacando los prohibidos");
        }
    }
}
