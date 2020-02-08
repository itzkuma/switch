using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace actividad_switch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Copie su salario mensual");
            double salario = Double.Parse(Console.ReadLine());
            Console.WriteLine("su tipo de contrato es:");
            Console.WriteLine("Copie 1 si su contrato es dependiente");
            Console.WriteLine("Copie 2 si su contrato es independiente");
            int contrato = int.Parse(Console.ReadLine());
            int riesgo = 0;
            double claseRiesgo = 0;
            double salariorealmensual = 0;

            switch (contrato)
            {
                case 2: 

                Console.WriteLine("Ingrese su clase de riesgo... de 1 a 5");
                riesgo = int.Parse(Console.ReadLine());
                    break;
               

            }
            switch (riesgo)
            {
                case 1: 
                claseRiesgo = (0.00522);
                    break;

                case 2:
                    
            
                claseRiesgo = (0.010044);
                    break;

                case 3:
                    
            
                claseRiesgo = (0.02436);
                    break;

                case 4:
                   
            
                claseRiesgo = (0.0435);
                    break;


                case 5:
                    
            
                claseRiesgo = (0.0696);
                    break;
            }

            Console.WriteLine("su salario real mensual es:");
            //salario mensual - deducciones
            double cotizacion = (salario * 0.4);
            if (cotizacion < 877803)
            {
                cotizacion = salario;
            }
            double pension1 = (cotizacion * 0.04);
            double pension2 = (cotizacion * 0.16);
            double eps1 = (cotizacion * 0.04);
            double eps2 = (cotizacion * 0.125);
            double arl1 = (0);
            double arl2 = (cotizacion * claseRiesgo);

            double deduccion1 = pension1 + eps1 + arl1;
            double deduccion2 = pension2 + eps2 + arl2;

            switch (contrato)
            {
                case 1:
                salariorealmensual = (salario - deduccion1);
                    break;

                case 2: 
            
                salariorealmensual = (salario - deduccion2);
                    break;
            }

            Console.WriteLine(salariorealmensual);

            Console.WriteLine("Su salario anual con deducciones y con bonificación es:");
            double salarioRealAnual = 0;

            switch (contrato)
            {
                case 1:
                salarioRealAnual = (salario + deduccion1 + salario);
                    break;

                case 2:
                   
            
                salarioRealAnual = (salario + deduccion2);
                    break;
            }

            Console.WriteLine(salarioRealAnual);







            //877803 
        }
    }
}
        
    
