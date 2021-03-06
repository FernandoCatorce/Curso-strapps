using System;
namespace Empleado.WebApi.Models
{
    public class Empleado : Persona
    {
         public int IdEmpleado{get; set;}
         public string RFC {get; set;}
         public string Puesto {get; set;}
         public DateTime FechaIngreso {get; set;}
         public decimal SalarioDiario {get; set;}
         public string NumerSeguroSocial{get; set;}
         public string Horario{get; set;}
         public string TotalFaltas{get; set;}
         public bool Activo {get; set;}
    }
}