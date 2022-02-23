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
        //y DEBE retornar un valor de tipo 'Double'
        Double suma(Datos datos);

        //Método resta DEBE recibir un objeto de tipo 'Datos'
        //y DEBE retornar un valor de tipo 'Double'
        Double resta(Datos datos);

        //Método division DEBE recibir un objeto de tipo 'Datos'
        //y DEBE retornar un valor de tipo 'Double'
        Double division(Datos datos);

        //Método multiplicacion DEBE recibir un objeto de tipo 'Datos'
        //y DEBE retornar un valor de tipo 'Double'
        Double multiplicacion(Datos datos);
    }
}
