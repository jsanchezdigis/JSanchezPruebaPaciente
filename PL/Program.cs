using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL
{
    public class Program
    {
        static void Main(string[] args)
        {
            int fin = 0;
            while (fin != 1)
            {
                Console.Write("\n1-Agregar(ADD) \n2.-Actualizar(Update) \n3.-Eliminar(Delete) \n4.-Mostrar(GetAll) \n5.-MostarID(GetById)\n6.-Salir");
                Console.Write("\nIngrese la opcion deseada: ");
                int op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        PL.Paciente.Add();
                        break;
                    case 2:
                        PL.Paciente.Update();
                        break;
                    case 3:
                        PL.Paciente.Delete();
                        break;
                    case 4:
                        PL.Paciente.GetAll();
                        break;
                    case 5:
                        PL.Paciente.GetById();
                        break;
                    case 6:
                        fin = 1;
                        break;
                    default:
                        Console.WriteLine("opcion incorecta");
                        Console.ReadKey();
                        break;
                }
            }
            Console.ReadLine();
        }
    }
}
