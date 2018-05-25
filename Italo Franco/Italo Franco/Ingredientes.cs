using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Italo_Franco
{
    class Ingredientes
    {
        public float precioUnidad;
        public float cantidad;
        public string name;
        public float precioFinal;
        
    }

    class VegetalYAnimal : Ingredientes
    {
        public bool verificarCooccion;

        
    }

    class DerivadosSolidos : Ingredientes
    {
        public bool servirPan;

        public void IntanciarDerivado()
        {
            DerivadosSolidos queso = new DerivadosSolidos();
            {
                name = "queso";
                cantidad = 1;
                precioUnidad = 4;
                precioFinal = cantidad * precioUnidad;
                servirPan = false;
            }

            DerivadosSolidos mantequilla = new DerivadosSolidos();
            {
                name = "mantequilla";
                cantidad = 1;
                precioUnidad = 2;
                precioFinal = cantidad * precioUnidad;
                servirPan = false;
            }

            DerivadosSolidos jamonada = new DerivadosSolidos();
            {
                name = "jamonada";
                cantidad = 1;
                precioUnidad = 3;
                precioFinal = cantidad * precioUnidad;
                servirPan = false;
            }

            DerivadosSolidos hotdog = new DerivadosSolidos();
            {
                name = "hotdog";
                cantidad = 1;
                precioUnidad = 2f;
                precioFinal = cantidad * precioUnidad;
                servirPan = false;
            }
            
        }

    }

    class Liquidos : Ingredientes
    {
        public bool vertir;

        public void InstanciarLiquido()
        {
            Liquidos agua = new Liquidos();
            {
                name = "agua";
                cantidad = 1;
                precioUnidad = 1;
                precioFinal = cantidad * precioUnidad;
                vertir = false;
            }

            Liquidos jugo = new Liquidos();
            {
                name = "jugo";
                cantidad = 1;
                precioUnidad = 2;
                precioFinal = cantidad * precioUnidad;
                vertir = false;
            }

            Liquidos gaseosa = new Liquidos();
            {
                name = "gaseosa";
                cantidad = 1;
                precioUnidad = 3;
                precioFinal = cantidad * precioUnidad;
                vertir = false;
            }
        }
    }
    
}
