using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuantoCombustible
{
    public class Calculo
    {
        //  Precio del combustible.
        public double precioCombustible;

        // Distancia a calcular.
        public double kilometros;

        //  Consumo a calcular.
        public double combustibleTotal;

        //  Gasto total.
        public double precioTotal;


        //  Consumo de combustible por kilometro.
        private const double mililitrosPorKilometro = 0.100;


        //  Retorna el total de combustible consumido.
        public void CalcularCombustiblePorKilometros()
        {
            combustibleTotal = mililitrosPorKilometro * kilometros;
        }

        //  Retorna el precio total del combustible consumido.
        public void CalcularPrecioFinal()
        {
            precioTotal = combustibleTotal * precioCombustible;
        }
        

    }
}
