using System.Diagnostics.CodeAnalysis;
using System.Net;

namespace DRY
{
    class program
    {
        public class PayRoll
        {
            public static decimal CalculateSalary(decimal Salary)
            {
                decimal tax = Salary * 0.18m;
                decimal bonus = Salary * 0.05m;
                return Salary - tax + bonus;
            }
            public decimal CalculateSalaryForFullTime(decimal Salary)
            {
                return CalculateSalary(Salary);
            }
            public decimal CalculateSalaryForPartTime(decimal hourlyRate, int hoursWorked)
            {
                decimal Salary = hourlyRate * hoursWorked;
                return CalculateSalary(Salary);
            }
        }
        static void Main(string[] args)
        {
            bool menu = true;

            while (menu)
            {
                Console.WriteLine("Menu de Opciones: ");
                Console.WriteLine(" 1- Empleado de tiempo completo");
                Console.WriteLine(" 2- Empleado por horas ");
                Console.WriteLine(" 3- Salir del sistema ");
                Console.Write("   Elija el tipo de empleado >>>");

                int opc = Convert.ToInt32(Console.ReadLine());

                PayRoll payRoll = new PayRoll();

                switch (opc)
                {
                    case 1:
                        Console.Write("Ingrese el salario base del empleado: ");
                        decimal SalaryBase = Convert.ToDecimal(Console.ReadLine());
                        decimal NetSalary = payRoll.CalculateSalaryForFullTime(SalaryBase);
                        Console.WriteLine("El salario neto despues de impuestos y bonus: " + NetSalary);
                        break;
                    case 2:
                        Console.Write("Ingrese el sueldo por hora: ");
                        decimal hourlyRate = Convert.ToDecimal(Console.ReadLine());
                        Console.Write("Ingrese las horas trabajadas: ");
                        int hoursWorked = Convert.ToInt32(Console.ReadLine());
                        decimal netSalaryPartTime = payRoll.CalculateSalaryForPartTime(hourlyRate, hoursWorked);
                        Console.WriteLine("Salario neto después de impuestos y bono: " + netSalaryPartTime);
                        break;
                    case 3:
                        menu = false;
                        break;
                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }
            }
        }
    }
}


            
        
        
        
        
        


    
