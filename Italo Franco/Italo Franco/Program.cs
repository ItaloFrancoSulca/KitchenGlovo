using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Italo_Franco
{
    class Program
    {




        static void Main(string[] args)
        {
            int numeroIngrediente;
            string primerIngrediente = "null";
            string segundoIngrediente = "null";

            

            Console.WriteLine("Bienvenido al Restaurante");

            Console.WriteLine("Hoy usted cocinará por su cuenta así que digame, ¿Qué ingredientes requiere usar?\nLos ingredientes serán comprados vía Glovo para su comodidad");
            Console.ReadLine();
            start1:
            Console.WriteLine();
            Console.WriteLine("Contamos con los siguientes ingredientes disponibles, elija seleccionando el número deseado");
            Console.WriteLine();
            Console.WriteLine("Lechuga(1), Repollo(2), Apio(3), Ajo(4), Papa(5) y Arroz(6)");
            numeroIngrediente = Convert.ToInt32(Console.ReadLine());
        
            switch (numeroIngrediente)
            {
                
                case 1:

                    VegetalYAnimal lechuga = new VegetalYAnimal();
                    lechuga.name = "lechuga";
                    lechuga.cantidad = 1;
                    lechuga.precioUnidad = 1;
                    Console.WriteLine("El precio es " + lechuga.precioUnidad + "\n¿Cuantas unidades desea llevar?");
                    lechuga.cantidad = Convert.ToInt32(Console.ReadLine());
                    lechuga.precioFinal = lechuga.cantidad * lechuga.precioUnidad;
                    Console.WriteLine("El precio final es "+lechuga.precioFinal+" sol(es)");
                    lechuga.verificarCooccion = false;
                    primerIngrediente = lechuga.name;

                    break;

                case 2:

                    VegetalYAnimal repollo = new VegetalYAnimal();
                    repollo.name = "repollo";
                    repollo.cantidad = 1;
                    repollo.precioUnidad = 2;
                    repollo.verificarCooccion = false;
                    primerIngrediente = repollo.name;
                    Console.WriteLine("El precio es " + repollo.precioUnidad + "\n¿Cuantas unidades desea llevar?");
                    repollo.cantidad = Convert.ToInt32(Console.ReadLine());
                    repollo.precioFinal = repollo.cantidad * repollo.precioUnidad;
                    Console.WriteLine("El precio final es " + repollo.precioFinal + " sol(es)");
                    break;

                case 3:
                    VegetalYAnimal apio = new VegetalYAnimal();

                    apio.name = "apio";
                    apio.cantidad = 1;
                    apio.precioUnidad = 1;
                    apio.verificarCooccion = false;
                    primerIngrediente = apio.name;
                    Console.WriteLine("El precio es " + apio.precioUnidad + "\n¿Cuantas unidades desea llevar?");
                    apio.cantidad = Convert.ToInt32(Console.ReadLine());
                    apio.precioFinal = apio.cantidad * apio.precioUnidad;
                    Console.WriteLine("El precio final es " + apio.precioFinal + " sol(es)");

                    break;

                case 4:
                    VegetalYAnimal ajo = new VegetalYAnimal();

                    ajo.name = "ajo";
                    ajo.cantidad = 1;
                    ajo.precioUnidad = 2f;
                    ajo.verificarCooccion = false;
                    primerIngrediente = ajo.name;
                    Console.WriteLine("El precio es " + ajo.precioUnidad + "\n¿Cuantas unidades desea llevar?");
                    ajo.cantidad = Convert.ToInt32(Console.ReadLine());
                    ajo.precioFinal = ajo.cantidad * ajo.precioUnidad;
                    Console.WriteLine("El precio final es " + ajo.precioFinal + " sol(es)");

                    break;

                case 5:

                    VegetalYAnimal papa = new VegetalYAnimal();

                    papa.name = "papa";
                    papa.cantidad = 1;
                    papa.precioUnidad = 4f;
                    papa.verificarCooccion = false;
                    primerIngrediente = papa.name;
                    Console.WriteLine("El precio es " + papa.precioUnidad + "\n¿Cuantos kilos desea llevar?");
                    papa.cantidad = Convert.ToInt32(Console.ReadLine());
                    papa.precioFinal = papa.cantidad * papa.precioUnidad;
                    Console.WriteLine("El precio final es " + papa.precioFinal + " sol(es)");

                    break;

                case 6:

                    VegetalYAnimal arroz = new VegetalYAnimal();

                    arroz.name = "arroz";
                    arroz.cantidad = 1;
                    arroz.precioUnidad = 5f;
                    arroz.verificarCooccion = false;
                    primerIngrediente = arroz.name;
                    Console.WriteLine("El precio es " + arroz.precioUnidad + "\n¿Cuantos kilos desea llevar?");
                    arroz.cantidad = Convert.ToInt32(Console.ReadLine());
                    arroz.precioFinal = arroz.cantidad * arroz.precioUnidad;
                    Console.WriteLine("El precio final es " + arroz.precioFinal + " sol(es)");

                    break;

                 default:
                    goto start1;

                    

            }

            Console.WriteLine("Usted selecciono " + primerIngrediente+" como primer ingrediente, inteligente decisión");
            Console.WriteLine();
            Console.ReadKey();
            numeroIngrediente = 0;
            Console.Clear();
            Console.WriteLine("A continuación usted podrá seleccionar su segundo ingrediente");
            start2:
            Console.WriteLine();
            Console.WriteLine("Contamos con los siguientes ingredientes, elija seleccionando el número deseado");
            Console.WriteLine();
            Console.WriteLine("Pollo(1), Res(2) y Pescado(3)");
            numeroIngrediente = Convert.ToInt32(Console.ReadLine());


            switch (numeroIngrediente)
            {

                case 1:

                    VegetalYAnimal pollo = new VegetalYAnimal();
                    pollo.name = "pollo";
                    pollo.cantidad = 1;
                    pollo.precioUnidad = 5;
                    Console.WriteLine("El precio es " + pollo.precioUnidad + "\n¿Cuantos kilos desea llevar?");
                    pollo.cantidad = Convert.ToInt32(Console.ReadLine());
                    pollo.precioFinal = pollo.cantidad * pollo.precioUnidad;
                    Console.WriteLine("El precio final es " + pollo.precioFinal + " sol(es)");
                    pollo.verificarCooccion = false;
                    segundoIngrediente = pollo.name;

                    break;

                case 2:

                    VegetalYAnimal res = new VegetalYAnimal();
                    res.name = "repollo";
                    res.cantidad = 1;
                    res.precioUnidad = 8;
                    res.verificarCooccion = false;
                    segundoIngrediente = res.name;
                    Console.WriteLine("El precio es " + res.precioUnidad + "\n¿Cuantos kilos desea llevar?");
                    res.cantidad = Convert.ToInt32(Console.ReadLine());
                    res.precioFinal = res.cantidad * res.precioUnidad;
                    Console.WriteLine("El precio final es " + res.precioFinal + " sol(es)");
                    break;

                case 3:
                    VegetalYAnimal pescado = new VegetalYAnimal();

                    pescado.name = "pescado";
                    pescado.cantidad = 1;
                    pescado.precioUnidad = 10;
                    pescado.verificarCooccion = false;
                    Console.WriteLine("El precio es " + pescado.precioUnidad + "\n¿Cuantos kilos desea llevar?");
                    pescado.cantidad = Convert.ToInt32(Console.ReadLine());
                    pescado.precioFinal = pescado.cantidad * pescado.precioUnidad;
                    Console.WriteLine("El precio final es " + pescado.precioFinal + " sol(es)");
                    segundoIngrediente = pescado.name;
                    break;

                default:
                    goto start2;
            }

            Console.WriteLine("Usted selecciono " + segundoIngrediente + " como segundo ingrediente, inteligente decisión");
            Console.WriteLine();
            Console.ReadKey();
            Console.WriteLine("Usted va a comer " + primerIngrediente + " con " + segundoIngrediente);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Gracias...");
            Console.ReadKey();
        }

        
    }
}
