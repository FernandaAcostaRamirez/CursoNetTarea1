
using System;

class Program
{
    static void Main()
    {
        int[] cantidades = null;

        while (true)
        {
            Console.WriteLine("-----------------------Banco CDIS---------------------------");
            Console.WriteLine("1. Ingresar la cantidad de retiros hechos por los usuarios.");
            Console.WriteLine("2. Revisar la cantidad entregada de billetes y monedas.");
          Console.WriteLine("");
            Console.Write("Ingresa la opción: ");

            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    Console.Write("¿Cuántos retiros se hicieron (máximo 10)? ");
                    int numRetiros = int.Parse(Console.ReadLine());
                    cantidades = new int[numRetiros];
                    for (int i = 0; i < numRetiros; i++)
                    {
                        Console.Write($"Ingresa la cantidad del retiro #{i+1}: ");
                        cantidades[i] = int.Parse(Console.ReadLine());
                    }
                    break;
                case "2":
                    if (cantidades == null)
                    {
                        Console.WriteLine("Primero debes ingresar las cantidades de los retiros.");
                    }
                    else
                    {
                        int[] denominaciones = {500, 200, 100, 50, 20, 10, 5, 1};
                        for (int i = 0; i < cantidades.Length; i++)
                        {
                            Console.WriteLine($"Retiro #{i+1}:");
                            int cantidad = cantidades[i];
                            int totalBilletes = 0;
                            int totalMonedas = 0;
                            for (int j = 0; j < denominaciones.Length; j++)
                            {
                                int contador = 0;
                                while (cantidad >= denominaciones[j])
                                {
                                    cantidad -= denominaciones[j];
                                    contador++;
                                }
                                if (denominaciones[j] >= 20)
                                {
                                    totalBilletes += contador;
                                }
                                else
                                {
                                    totalMonedas += contador;
                                }
                            }
                            Console.WriteLine("Billetes entregados: " + totalBilletes);
                            Console.WriteLine("Monedas entregadas: " + totalMonedas);
                            Console.WriteLine();
                        }
                        Console.WriteLine("Presiona 'enter' para continuar ...");
                        Console.ReadLine();
                    }
                    break;
                default:
                    Console.WriteLine("Opción no válida. Intenta de nuevo.");
                    break;
            }
        }
    }
}
