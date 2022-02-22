using System;

namespace CalculatorWeb.Models
{
    //Clase que nos servirá para almacenar
    //los datos(num1^num2) que el usuario quiera procesar
    //ya sea por suma, resta, división o multiplicación.
    public class Datos
    {
        public Double num1 { get; set; }
        public Double num2 { get; set; }
    }
}
