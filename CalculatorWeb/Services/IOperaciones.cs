using CalculatorWeb.Models;
using System;

namespace CalculatorWeb.Services
{
    //Al usar la Interface IOperaciones obligamos
    //al programador a implementar los cuatro 
    //métodos de las diferentes operaciones matemáticas.
    public interface IOperaciones
    {
        //Método suma DEBE recibir un objeto de tipo 'Datos'
        Double suma(Datos datos);

        //Método resta DEBE recibir un objeto de tipo 'Datos'
        Double resta(Datos datos);

        //Método division DEBE recibir un objeto de tipo 'Datos'
        Double division(Datos datos);

        //Método multiplicacion DEBE recibir un objeto de tipo 'Datos'
        Double multiplicacion(Datos datos);
    }
}
