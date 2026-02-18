using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace ConsoleApp1
{
    class Alumno
    {
        public int Legajo { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }

public Alumno(int legajo, string nombre, string apellido)
 {
 Legajo = legajo;
 Nombre = nombre;
 Apellido = apellido;
        }
    }

    class Nota
    {
        public int CodigoMateria { get; set; }
        public int Legajo { get; set; }
        public int Valor { get; set; }
 public Nota(int codigoMateria, int legajo, int valor)
        {
       CodigoMateria = codigoMateria;
       Legajo = legajo;
       Valor = valor;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Alumno> alumnos = new List<Alumno>()
            {
  new Alumno(0001, "Sofia", "Cottet"),
  new Alumno(0002, "Nicolas", "Garoni"),
    new Alumno(0003, "Florencia", "Padilla"),
   new Alumno(0004, "Lucas", "Castillo")
            };
 List<Nota> notas = new List<Nota>()
            {
  new Nota(001, 0001, 8),
  new Nota(002, 0001, 3),
  new Nota(003, 0001, 6),

    new Nota(001, 0002, 4),
    new Nota(004, 0002, 5),

   new Nota(001, 0003, 2),
     new Nota(002, 0003, 3),

 new Nota(001, 0004, 9),
 new Nota(002, 0004, 10),
 new Nota(003, 0004, 8)
       
 
 
 };

 string archivo = "promedios.txt";

using (StreamWriter sw = new StreamWriter(archivo))
 {
  sw.WriteLine("Legajo;Nombre;Apellido;Promedio;Notas");

                int i = 0;
                double mejorProm = -1;
                int mejorLegajo = -1;

   while (i < notas.Count)
  {
int legActual = notas[i].Legajo;
int suma = 0;
int contador = 0;

  List<int> notasOk = new List<int>();

  while (i < notas.Count && notas[i].Legajo == legActual)
    {
    if (notas[i].Valor > 4)
     {
   suma += notas[i].Valor;
   contador++;
  notasOk.Add(notas[i].Valor);
                        }
                        i++;
                    }

           Alumno alu = alumnos.Find(a => a.Legajo == legActual);

             string promedioStr;
            double promedio = 0;

                    if (contador > 0)
                    {
                        promedio = suma / (double)contador;
                        promedioStr = promedio.ToString();

                        if (promedio > mejorProm)
                        {
                            mejorProm = promedio;
                            mejorLegajo = legActual;
                        }
                    }
                    else
                    {
                        promedioStr = "-";
                    }

                    string notasStr = notasOk.Count > 0 ? string.Join("|", notasOk) : "(ninguna)";

                    sw.WriteLine(
                        alu.Legajo + ";" +
                        alu.Nombre + ";" +
                        alu.Apellido + ";" +
                        promedioStr + ";" +
                        notasStr
                    );
                }

                sw.WriteLine();
                sw.WriteLine("MejorPromedio;" + mejorLegajo + ";" + mejorProm.ToString("F2"));
            }

            Console.WriteLine("Archivo generado.");
            Console.ReadKey();
        }
    }
}