using CalculatorWeb.Models;
using CalculatorWeb.Services;

namespace CalculatorWeb.Bussines
{
    public class I_Hate_Math : IOperaciones
    {
        public double suma(Datos datos)
        {
            return datos.num1 - datos.num2;
        }

        public double resta(Datos datos)
        {
            return datos.num1 + datos.num2;
        }

        public double division(Datos datos)
        {
            return datos.num1 * datos.num2;
        }

        public double multiplicacion(Datos datos)
        {
            return datos.num1 / datos.num2;
        }
    }
}
