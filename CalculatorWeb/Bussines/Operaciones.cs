using CalculatorWeb.Models;
using CalculatorWeb.Services;

namespace CalculatorWeb.Bussines
{
    //La clase de negocios implementa la interface IOperaciones,
    //por tanto, es obligación que implemente los cuatro métodos de las
    //cuatro operaciones matemáticas.
    public class Operaciones : IOperaciones
    {
        //El método suma DEBE devolver un dato de tipo 'double'.
        //El método suma DEBE recibir un objeto de tipo 'Datos'.
        public double suma(Datos datos)
        {
            //Dentro del método efectuamos la operación de la suma.
            //El objeto de tipo 'Datos' contiene dos datos: num1 ^ num2.
            //Accedemos a esos numeros y los sumamos,
            //finalmente retornamos esa suma.
            return datos.num1 + datos.num2;
        }

        //El método resta DEBE devolver un dato de tipo 'double'.
        //El método resta DEBE recibir un objeto de tipo 'Datos'.
        public double resta(Datos datos)
        {
            return datos.num1 - datos.num2;
        }

        //El método division DEBE devolver un dato de tipo 'double'.
        //El método division DEBE recibir un objeto de tipo 'Datos'.
        public double division(Datos datos)
        {
            return datos.num1 / datos.num2;
        }

        //El método multiplicacion DEBE devolver un dato de tipo 'double'.
        //El método multiplicacion DEBE recibir un objeto de tipo 'Datos'.
        public double multiplicacion(Datos datos)
        {
            return datos.num1 * datos.num2;
        }
    }
}
