using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenOrdinarioFundamentosSoftware.Clases
{
    public class AdminstracionMascotas
    {

        private List<Mascota> mascotas = new List<Mascota>();
        private List<Dueño> dueños = new List<Dueño>();

        static void Main(string[] args)
        {
            System.Console.WriteLine("Seleccione lo que quiere realizar");
            System.Console.WriteLine("1 - Mostrar todas las mascotas registradas");
            System.Console.WriteLine("2 - Registrar mascota nueva");
            System.Console.WriteLine("3 - Buscar mascotas por especie");
            System.Console.WriteLine("4 - Buscar mascotas por nombre");
            System.Console.WriteLine("5 - Examinar mascota");
            System.Console.WriteLine("6 - Volver al menú anterior");
        }

        public MostrarMascotas(){

            Console.WriteLine("Mascotas registradas:");
            foreach (var mascota in mascotas)
            {
                Console.WriteLine($"Id: {mascota.Id}, Nombre: {mascota.Nombre}, Especie: {mascota.Especie}");
            }

        }

        public RegistrarMascota(){

        }

        public BuscarPorEspecie(EspecieEnum especie){

            System.Console.WriteLine("¿De cuál especie deseas ver las mascotas?");
            System.Console.WriteLine("1 - Perro");
            System.Console.WriteLine("2 - Gato");
            System.Console.WriteLine("3 - Capibara");
            System.Console.WriteLine("4 - Párajo");
            int especieABuscar = int.Parse(Console.ReadLine());

        }

        public BuscarPorNombre(Mascota ){
            
        }

        public ExaminarMascota(){

        }

    }


}