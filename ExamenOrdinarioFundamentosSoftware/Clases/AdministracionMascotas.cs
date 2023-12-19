using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
                System.Console.WriteLine($"Id: {mascota.Id}, Nombre: {mascota.Nombre}, Especie: {mascota.Especie}");
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
            System.Console.WriteLine($"Mascotas de la especie: {especie}");

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
            System.Console.WriteLine("Mascotas encontradas:");
            foreach (var mascota in mascotasEncontradas)
            {
                System.Console.WriteLine($"Id: {mascota.Id}, Nombre: {mascota.Nombre}, Especie: {mascota.Especie}");
            }
        }

        public void ExaminarMascota(){

            System.Console.WriteLine("Ingrese el ID de la mascota que desea examinar");
            int idMascota = int.Parse(Console.ReadLine());

            Mascota mascota = mascotas.FirstOrDefault(m => m.Id == idMascota);

            if (mascota != null)
            {
                MostrarDatosMascota(mascota);
            }
            else
            {
                System.Console.WriteLine("No se encontró una mascota con ese ID.");
                System.Console.Write("¿Desea buscar mascota por nombre? (S/N): ");
                if (Console.ReadLine().ToUpper() == "S")
                {
                    System.Console.WriteLine("Ingrese el nombre de la mascota que quiere buscar:");
                    string nombre = Console.ReadLine();

                    var mascotasEncontradas = mascotas
                        .Where(m => m.Nombre.ToLower().Contains(nombre.ToLower()))
                        .ToList();

                    if (mascotasEncontradas.Count == 1)
                    {
                        MostrarDatosMascota(mascotasEncontradas.First());

                    }
                    else if (mascotasEncontradas.Count > 1)
                    {
                        System.Console.WriteLine("Múltiples mascotas encontradas:");
                        foreach (var mascotaEncontrada in mascotasEncontradas)
                        {
                            Console.WriteLine($"Id: {mascotaEncontrada.Id}, Nombre: {mascotaEncontrada.Nombre}, Especie: {mascotaEncontrada.Especie}");
                        }

                        System.Console.Write("Ingrese el ID de la mascota que desea examinar: ");
                        int idMascotaSeleccionada = int.Parse(Console.ReadLine());

                        Mascota mascotaSeleccionada = mascotasEncontradas.FirstOrDefault(m => m.Id == idMascotaSeleccionada);

                        if (mascotaSeleccionada != null)
                        {
                            MostrarDatosMascota(mascotaSeleccionada);

                        }
                        else
                        {
                            System.Console.WriteLine("ID de mascota no válido");
                        }
                    }
                    else
                    {
                        System.Console.WriteLine("No se encontraron mascotas con ese nombre.");
                    }
                }
            }

        }

        private void MostrarDatosMascota(Mascota mascota)
        {
            System.Console.WriteLine($"Datos de la mascota:");
            System.Console.WriteLine($"Id: {mascota.Id}");
            System.Console.WriteLine($"Nombre: {mascota.Nombre}");
            System.Console.WriteLine($"Especie: {mascota.Especie}");
            System.Console.WriteLine($"Temperamento: {mascota.Temperamento}");
            System.Console.WriteLine($"Edad: {mascota.Edad}");

            if (mascota.Dueño != null)
            {
                System.Console.WriteLine($"Dueño: {mascota.Dueño.Nombre}");
            }
            else
            {
                System.Console.WriteLine("La mascota no tiene asignado un dueño.");
            }
        }

    }

}