using System;

namespace _2do_parcial_ejercicio_1
{
    class Empleado
    {
        private string[] nombres;
        private float[] salarios;

        public void Carga()
        {
            nombres = new string[5];
            salarios = new float[5];
            for(int v=0; v<nombres.Length; v++)
            {
                Console.WriteLine("Ingresar nombre del Empleado:");
                nombres[v] = Console.ReadLine();
                Console.WriteLine("Ingresar el Salario:");
                salarios[v] = float.Parse(Console.ReadLine());

            }
        }

        public void SalarioMayor()
        {
            float mayor = salarios[0];
            int posicion = 0;
            for(int v=1; v<salarios.Length; v++)
            {
                if (salarios[v] > mayor)
                {
                    mayor = salarios[v];
                    posicion = v;
                }
            }

            Console.WriteLine("El empleado con mayor salario es: " + nombres[posicion]);
            Console.WriteLine("Tiene un salario de: " + mayor);
        }
        static void Main(string[] args)
        {
            Empleado empleado1 = new Empleado();
            empleado1.Carga();
            empleado1.SalarioMayor();

            Console.ReadKey();
        }
    }
}
