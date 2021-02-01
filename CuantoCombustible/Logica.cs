using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuantoCombustible
{
    public class Logica
    {

        public Calculo calculo = new Calculo();

        //  precio del combustible.
        public double precioCombustible;

        //  Distancia en kilometros.
        public double distanciaKilometros;

        //  Consumo de combustible.
        public double consumoCombustible;

        //  Gasto total.
        public double gastoTotal;

        public string Verificar(double precioComb, double kilometros )
        {
            if(precioComb < 0) { return "El precio de combustible introducido es menor a cero."; }
            else 
            {
                calculo.precioCombustible = precioComb;
                calculo.kilometros = kilometros;
                
                return Calcular();
            }

        }

        private string Calcular()
        {
            calculo.CalcularCombustiblePorKilometros();
            calculo.CalcularPrecioFinal();
            return "Calculo Realizado";
        }
    }
}
