using CalculatorWeb.Models;
using CalculatorWeb.Services;

namespace CalculatorWeb.Bussines
{
    //En este caso, esta clase implementa la interface IOperaciones,
    //pero los procedimientos de sus métodos son
    //distintos y, en este caso a modo de ejemplo, contrarias
    //a su operación inicial.
    public class I_Hate_Math : IOperaciones
    {
        //El método suma DEBE devolver un dato de tipo 'double'.
        //El método suma DEBE recibir un objeto de tipo 'Datos'.
        //En este caso, en vez de sumar, resta.
        public double suma(Datos datos)
        {
            return datos.num1 - datos.num2;
        }

        //El método resta DEBE devolver un dato de tipo 'double'.
        //El método resta DEBE recibir un objeto de tipo 'Datos'.
        //En este caso, en vez de restar, suma.
        public double resta(Datos datos)
        {
            return datos.num1 + datos.num2;
        }

        //El método division DEBE devolver un dato de tipo 'double'.
        //El método division DEBE recibir un objeto de tipo 'Datos'.
        //En este caso, en vez de dividir, multiplica.
        public double division(Datos datos)
        {
            return datos.num1 * datos.num2;
        }

        //El método multiplicacion DEBE devolver un dato de tipo 'double'.
        //El método multiplicacion DEBE recibir un objeto de tipo 'Datos'.
        //En este caso, en vez de multiplicar, divide.
        public double multiplicacion(Datos datos)
        {
            return datos.num1 / datos.num2;
        }
    }
}
