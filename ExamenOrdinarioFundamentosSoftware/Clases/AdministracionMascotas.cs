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

        public void MostrarMascotas(){

            Console.WriteLine("Mascotas registradas:");
            foreach (var mascota in mascotas)
            {
                Console.WriteLine($"Id: {mascota.Id}, Nombre: {mascota.Nombre}, Especie: {mascota.Especie}");
            }

        }

        public void RegistrarMascota(){

        }

        public void BuscarPorEspecie(EspecieEnum especie){

            System.Console.WriteLine("¿De cuál especie deseas ver las mascotas?");
            System.Console.WriteLine("1 - Perro");
            System.Console.WriteLine("2 - Gato");
            System.Console.WriteLine("3 - Capibara");
            System.Console.WriteLine("4 - Párajo");
            int especieABuscar = int.Parse(Console.ReadLine());

            switch (especieABuscar){

                case 1: 

                    MostrarMascotasPorEspecie(EspecieEnum.Perro);
                    break;

                case 2: 

                    MostrarMascotasPorEspecie(EspecieEnum.Gato);
                    break;

                case 3:

                    MostrarMascotasPorEspecie(EspecieEnum.Capibara);
                    break;

                case 4:

                    MostrarMascotasPorEspecie(EspecieEnum.Pajaro);
                    break;

            }

        }

        private void MostrarMascotasPorEspecie(EspecieEnum especie)
        {
            Console.WriteLine($"Mascotas de la especie: {especie}");

            var mascotasEncontradas = mascotas
                .Where(m => m.Especie.ToLower() == especie.ToString().ToLower())
                .ToList();

            MostrarMascotasEncontradas(mascotasEncontradas);

        }

        private void BuscarPorNombre(){

            System.Console.WriteLine("Ingrese el nombre de la mascota que quiere buscar:");
            string nombre = Console.ReadLine();

            var mascotasEncontradas = mascotas
                .Where(m => m.Nombre.ToLower().Contains(nombre.ToLower()))
                .ToList();

            MostrarMascotasEncontradas(mascotasEncontradas);
            
        }

        private void MostrarMascotasEncontradas(List<Mascota> mascotasEncontradas)
        {
            Console.WriteLine("Mascotas encontradas:");
            foreach (var mascota in mascotasEncontradas)
            {
                Console.WriteLine($"Id: {mascota.Id}, Nombre: {mascota.Nombre}, Especie: {mascota.Especie}");
            }
        }

        public void ExaminarMascota(){

            

        }

    }


}