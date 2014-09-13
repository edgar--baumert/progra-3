using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace actividad2_final_
{
    class Program
    {
        static void Main(string[] args)
        {

            excepciones();




            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("presione cualquier tecla para salir");
            Console.ReadKey();

        }
        static void excepciones()
        {
            try
            {

                string nombre, apellidos, mes, rut;
                string ssalud;
                int año, valorhora, cantidadhorassemana, cantidadhorasfindesemana, anticipo, bono, dscto;

                Console.WriteLine("ingrese su nombre: ");
                nombre = Console.ReadLine();
                Console.WriteLine("ingrese sus apellidos: ");
                apellidos = Console.ReadLine();
                Console.WriteLine("ingrese su rut: ");
                rut = Console.ReadLine();
                Console.WriteLine("ingrese el mes a cotizar: ");
                mes = Console.ReadLine();
                Console.WriteLine("ingrese año: ");
                año = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("ingrese valor hora:");
                valorhora = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("ingrese cantidad de horas trabajadas");
                cantidadhorassemana = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("ingrese la cantidad de horas de fin de semana trabajadas");
                cantidadhorasfindesemana = Convert.ToInt16(Console.ReadLine());
                int valortotalhabil = cantidadhorassemana * valorhora;
                double valortotalfin = (cantidadhorasfindesemana * (1.5)) * valorhora;
                double sueldoimponible = valortotalhabil + valortotalfin;
                //Console.WriteLine("ganado en horas habiles: " + valortotalhabil);
                //Console.WriteLine("ganado en horas fin de semana: " + valortotalfin );
                //Console.WriteLine("ganado imponible: " + sueldoimponible);
                Console.WriteLine("ingrese el monto total de los anticipos otorgados (si no hubieron anticipos, digite un cero): ");
                anticipo = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("ingrese el monto total por bonos otorgados (si no recibio bonos, digite un cero): ");
                bono = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("ingrese monto total de descuentos aplicados (si no le realizaron dsctos., digite un cero): ");
                dscto = Convert.ToInt16(Console.ReadLine());

                Console.WriteLine("elija su sistema de salud: 1 Fonasa 2 Isapre: ");
                ssalud = Console.ReadLine();
                if (ssalud == "1")
                {
                    ssalud = "Fonasa";
                    double descfon = (sueldoimponible - anticipo - dscto + bono) - ((sueldoimponible - anticipo - dscto + bono) * 7 / 100);
                    sueldoimponible = (sueldoimponible - anticipo - dscto + bono) - ((sueldoimponible - anticipo - dscto + bono) * 7 / 100);
                    //Console.WriteLine("sueldo menos sistema de salud: " + descfon);
                }
                else if (ssalud == "2")
                {
                    ssalud = "Isapre";
                    Console.WriteLine("Seleccione su Isapre: 1 Banmedica 2 GoldenCross 3 Consalud");
                    string isap = Console.ReadLine();
                    if (isap == "1")
                    {
                        sueldoimponible = (sueldoimponible - anticipo - dscto + bono) - ((sueldoimponible - anticipo - dscto + bono) * 10 / 100);
                        //Console.WriteLine(sueldoimponible);
                    }
                    else if (isap == "2")
                    {
                        sueldoimponible = (sueldoimponible - anticipo - dscto + bono) - ((sueldoimponible - anticipo - dscto + bono) * 15 / 100);
                        //Console.WriteLine(sueldoimponible);
                    }
                    else if (isap == "3")
                    {
                        sueldoimponible = (sueldoimponible - anticipo - dscto + bono) - ((sueldoimponible - anticipo - dscto + bono) * 9 / 100);
                        //Console.WriteLine(sueldoimponible);
                    }
                }
                else if (ssalud != "1" || ssalud != "2")
                {
                    ssalud = "no ingreso numero o no es correcto";
                }

                Console.WriteLine("seleccione su AFP: 1 Capital 2 Cuprum 3 Habitat 4 Modelo 5 Planvital 6 Provida");
                string AFP = Console.ReadLine();
                if (AFP == "1")
                {
                    Console.WriteLine();
                    Console.WriteLine(""+(sueldoimponible - (sueldoimponible * (11.44 / 100))));
                    sueldoimponible=(sueldoimponible - (sueldoimponible * (11.44 / 100)));
                }
                else if (AFP == "2")
                {
                    Console.WriteLine();
                    Console.WriteLine((sueldoimponible - (sueldoimponible * (11.48 / 100))));
                    sueldoimponible = (sueldoimponible - (sueldoimponible * (11.48 / 100)));
                }
                else if (AFP == "3")
                {
                    Console.WriteLine();
                    Console.WriteLine((sueldoimponible - (sueldoimponible * (11.27 / 100))));
                    sueldoimponible = (sueldoimponible - (sueldoimponible * (11.27 / 100)));
                }
                else if (AFP == "4")
                {
                    Console.WriteLine();
                    Console.WriteLine((sueldoimponible - (sueldoimponible * (10.77 / 100))));
                    sueldoimponible = (sueldoimponible - (sueldoimponible * (10.77 / 100)));
                }
                else if (AFP == "5")
                {
                    Console.WriteLine();
                    Console.WriteLine(""+(sueldoimponible - (sueldoimponible * (10.47 / 100))));
                    sueldoimponible = (sueldoimponible - (sueldoimponible * (10.47 / 100)));
                }
                else if (AFP == "6")
                {
                    Console.WriteLine();
                    Console.WriteLine((sueldoimponible - (sueldoimponible * (11.54 / 100))));
                    sueldoimponible = (sueldoimponible - (sueldoimponible * (11.54 / 100)));
                }

                //Console.WriteLine("tu sistema de salud es: "+ ssalud);


                //valorhora = valorhora * cantidadhorassemana;
                //Console.WriteLine("ganado en horas semanales habil: " + valorhora);




                Console.Clear();

                Console.WriteLine("     nombre: " + nombre + "       " + "apellidos: " + apellidos + "        Rut: " + rut);
                Console.WriteLine("Horas Normales:- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - " + valortotalhabil);
                Console.WriteLine("Horas Fines de Semana: - - - - - - - - - - - - - - - - - - - - - - - - - - " + valortotalfin);
                Console.WriteLine("Valor Hora: - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - " + valorhora);
                Console.WriteLine("Mes : - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - " + mes);
                Console.WriteLine("Año : - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - " + año);
                Console.WriteLine("AFP : - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - ");
                Console.WriteLine("DES SALUD : - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -  ");
                Console.WriteLine("Anticipo : - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -  " + anticipo);
                Console.WriteLine("Descuento : - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - " + dscto);
                Console.WriteLine("Bonos : - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - " + bono);
                Console.WriteLine("total semana: - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -  " + valortotalhabil);
                Console.WriteLine("Total Fines de Semana: - - - - - - - - - - - - - - - - - - - - - - - - - " + valortotalfin);

                Console.WriteLine("Sueldo Liquido : - - - - - - - - - - - - - - - - - - - - - - - - - - - - " + sueldoimponible);

                //Console.ReadKey();




            }
            catch (FormatException)
            {

                Console.WriteLine("solo se admiten numeros en esta linea");

                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("presione cualquier tecla para salir");
                Console.ReadKey();

            }






        }




    }

}
