using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL
{
    public class Paciente
    {
        public static void Add()
        {
            ML.Paciente paciente = new ML.Paciente();

            Console.WriteLine("Ingresa el Nombre: ");
            paciente.Nombre = Console.ReadLine();

            Console.WriteLine("Ingresa el Apellido Paterno: ");
            paciente.ApellidoPaterno = Console.ReadLine();

            Console.WriteLine("Ingresa el Apellido Materno: ");
            paciente.ApellidoMaterno = Console.ReadLine();

            Console.WriteLine("Ingresa la Fecha de nacieminto(dd-mm-yyyy): ");
            paciente.FechaNacimiento = Console.ReadLine();

            Console.WriteLine("Ingresa el IdTipoSangre: ");
            paciente.TipoSangre = new ML.TipoSangre();
            paciente.TipoSangre.IdTipoSangre = byte.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa el Sexo(M/F): ");
            paciente.Sexo = Console.ReadLine();

            Console.WriteLine("Ingresa el Diagnostico: ");
            paciente.Diagnostico = Console.ReadLine();

            ML.Result result = BL.Paciente.Add(paciente);

            if (result.Correct)
            {
                Console.WriteLine("Se Inserto el paciente");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("No se inserto el paciente");
                Console.ReadKey();
            }
        }


        public static void Update()
        {
            ML.Paciente paciente = new ML.Paciente();

            Console.WriteLine("Ingresa el ID: ");
            paciente.IdPaciente = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa el Nombre: ");
            paciente.Nombre = Console.ReadLine();

            Console.WriteLine("Ingresa el Apellido Paterno: ");
            paciente.ApellidoPaterno = Console.ReadLine();

            Console.WriteLine("Ingresa el Apellido Materno: ");
            paciente.ApellidoMaterno = Console.ReadLine();

            Console.WriteLine("Ingresa la Fecha de nacieminto(dd-mm-yyyy): ");
            paciente.FechaNacimiento = Console.ReadLine();

            Console.WriteLine("Ingresa el IdTipoSangre: ");
            paciente.TipoSangre = new ML.TipoSangre();
            paciente.TipoSangre.IdTipoSangre = byte.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa el Sexo(M/F): ");
            paciente.Sexo = Console.ReadLine();

            Console.WriteLine("Ingresa el Diagnostico: ");
            paciente.Diagnostico = Console.ReadLine();

            ML.Result result = BL.Paciente.Update(paciente);

            if (result.Correct)
            {
                Console.WriteLine("Se Actualizo el paciente");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("No se Actualizo el paciente");
                Console.ReadKey();
            }
        }

        public static void Delete()
        {
            ML.Paciente paciente = new ML.Paciente();

            Console.WriteLine("Ingresa el IdPaciente: ");
            paciente.IdPaciente = int.Parse(Console.ReadLine());

            ML.Result result = BL.Paciente.Delete(paciente);

            if (result.Correct)
            {
                Console.WriteLine("Se elimino el paciente");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("No se elimino el paciente");
                Console.ReadKey();
            }
        }

        public static void GetAll()
        {
            ML.Result result = BL.Paciente.GetAll();

            if (result.Correct)
            {
                foreach (ML.Paciente paciente in result.Objects)
                {
                    Console.WriteLine("IdPaciente: " + paciente.IdPaciente);
                    Console.WriteLine("Nombre: " + paciente.Nombre);
                    Console.WriteLine("Apellido Paterno: " + paciente.ApellidoPaterno);
                    Console.WriteLine("Apellido Materno: " + paciente.ApellidoMaterno);
                    Console.WriteLine("Fecha de nacimiento: " + paciente.FechaNacimiento);

                    Console.WriteLine("IdTipoSangre: " + paciente.TipoSangre.IdTipoSangre);
                    //Console.WriteLine("NombreTipoSangre: " + paciente.TipoSangre.Nombre);

                    Console.WriteLine("Sexo: " + paciente.Sexo);
                    Console.WriteLine("FechaIngreso: " + paciente.FechaIngreso);
                    Console.WriteLine("Dignostico: " + paciente.Diagnostico);
                    Console.WriteLine("-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-");
                }
            }
            Console.ReadKey();
        }
        public static void GetById()
        {
            Console.WriteLine("Ingresa el ID: ");
            int IdPaciente = int.Parse(Console.ReadLine());

            ML.Result result = BL.Paciente.GetById(IdPaciente);

            if (result.Correct)
            {
                ML.Paciente paciente = (ML.Paciente)result.Object;

                Console.WriteLine("IdPaciente: " + paciente.IdPaciente);
                Console.WriteLine("Nombre: " + paciente.Nombre);
                Console.WriteLine("Apellido Paterno: " + paciente.ApellidoPaterno);
                Console.WriteLine("Apellido Materno: " + paciente.ApellidoMaterno);
                Console.WriteLine("Fecha de nacimiento: " + paciente.FechaNacimiento);

                Console.WriteLine("IdTipoSangre: " + paciente.TipoSangre.IdTipoSangre);
                //Console.WriteLine("NombreTipoSangre: " + paciente.TipoSangre.Nombre);

                Console.WriteLine("Sexo: " + paciente.Sexo);
                Console.WriteLine("FechaIngreso: " + paciente.FechaIngreso);
                Console.WriteLine("Dignostico: " + paciente.Diagnostico);
                Console.WriteLine("-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-");

            }
            Console.ReadKey();
        }
    }
}
