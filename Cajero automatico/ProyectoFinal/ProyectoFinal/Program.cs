using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal
{
    class Program
    {
        static void Main(string[] args)
        {

            int tarjetaBanreserva = 123456789;
            int clave1 = 1111;
            int monto1 = 20000;
            int tarjetaPopular = 213456789;
            int clave2 = 2222;
            int monto2 = 30000;
            int tarjetaBHD = 312456789;
            int monto3 = 40000;
            int clave3 = 3333;
            int num = 0;
            int opcion1 = 0;
            int continuar = 0;
            while (num == 2 || num != 1 || opcion1 <= 0  || opcion1 >=4  || continuar <=0 || continuar ==1  )
            {
                Console.Clear();
                Console.WriteLine("************************************************");
                Console.WriteLine("                CAJERO AUTOMATICO");
                Console.WriteLine("************************************************");
                Console.WriteLine("");
                Console.WriteLine("Bienvenid@!!!");
                Console.WriteLine("Para continuar elije una opcion del 1 al 2");
                Console.WriteLine("--------------------------------------------");
                Console.WriteLine("1-Ingresar una tarjeta. ");
                Console.WriteLine("2-Salir. ");

                num = int.Parse(Console.ReadLine());

                if (num == 1)
                {
                    int tarjeta = 0;
                    Console.WriteLine("");
                    Console.WriteLine("Ingresa tu numero de tarjeta: ");
                    
                 
                     tarjeta = int.Parse(Console.ReadLine());

                    int pin1 = 0;

                    //Codigo para tarjeta Banreserva
                    if (tarjeta == tarjetaBanreserva)
                    {
                        Console.WriteLine("Haz ingresado con la tarjeta del BANCO BANRESERVAS");
                        Console.WriteLine("");
                        Console.WriteLine("Ingresa el pin: ");
                        pin1 = int.Parse(Console.ReadLine());

                        if (pin1 == clave1)
                        {
                            Console.WriteLine("");
                            Console.WriteLine("--------------------------");
                            Console.WriteLine("BANCO BANRESERVAS");
                            Console.WriteLine("--------------------------");
                            Console.WriteLine("Ahora elije una opcion: ");
                            Console.WriteLine("1-Depositar balance");
                            Console.WriteLine("2-Retirar balance");
                            Console.WriteLine("3-Consultar balance");
                            Console.WriteLine("4-Salir");
                            Console.WriteLine("");


                             opcion1 = int.Parse(Console.ReadLine());

                            if (opcion1 == 1)
                            {
                                Console.WriteLine("");
                                Console.WriteLine("--------------------------");
                                Console.WriteLine("Ingrese el monto que desea depositar: ");
                                Console.WriteLine("--------------------------");
                                int montoNuevo1 = int.Parse(Console.ReadLine());

                                monto1 = montoNuevo1 + monto1;

                                Console.WriteLine("");
                                Console.WriteLine("El nuevo balance es: " + monto1);
                                
                                Console.WriteLine("");
                                Console.WriteLine("------------------------------------------");
                                Console.WriteLine("Desea continuar con el CAJERO AUTOMATICO");
                                Console.WriteLine("1-Si");
                                Console.WriteLine("2-No");
                              

                                continuar = int.Parse(Console.ReadLine());

                                if (continuar <=0 || continuar >= 2)
                                {
                                    Console.WriteLine("---------------------------------------");
                                    Console.WriteLine("Gracias por utilizar nuestros servicios.");
                                    Console.WriteLine("----------------------------------------");
                                    Console.ReadLine();
                                }
                            }
                            if (opcion1 == 2)
                            {
                                Console.WriteLine("");
                                Console.WriteLine("--------------------------");
                                Console.WriteLine("Ingrese el balance que desea retirar: ");
                                Console.WriteLine("--------------------------");
                                int retiroNuevo1 = int.Parse(Console.ReadLine());

                                if (retiroNuevo1 <= monto1)
                                {
                                    Console.WriteLine("");
                                    Console.WriteLine("Transaccion realizada con exito.");
                                  
                                    Console.WriteLine("");
                                    Console.WriteLine("------------------------------------------");
                                    Console.WriteLine("Desea continuar con el CAJERO AUTOMATICO");
                                    Console.WriteLine("1-Si");
                                    Console.WriteLine("2-No");

                                    continuar = int.Parse(Console.ReadLine());

                                    if (continuar <= 0 || continuar >= 2)
                                    {
                                        Console.WriteLine("---------------------------------------");
                                        Console.WriteLine("Gracias por utilizar nuestros servicios.");
                                        Console.WriteLine("----------------------------------------");
                                        Console.ReadLine();
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("");
                                    Console.WriteLine("No tienes fondos suficientes para realizar esta transaccion");
                                    
                                    Console.WriteLine("------------------------------------------");
                                    Console.WriteLine("Desea continuar con el CAJERO AUTOMATICO");
                                    Console.WriteLine("1-Si");
                                    Console.WriteLine("2-No");

                                    continuar = int.Parse(Console.ReadLine());

                                    if (continuar <= 0 || continuar >= 2)
                                    {
                                        Console.WriteLine("---------------------------------------");
                                        Console.WriteLine("Gracias por utilizar nuestros servicios.");
                                        Console.WriteLine("----------------------------------------");
                                        Console.ReadLine();
                                    }
                                }
                            }

                            if (opcion1 == 3)
                            {
                                Console.WriteLine("");
                                Console.WriteLine("--------------------------");
                                Console.WriteLine("Tu balance es " + "$" + monto1);
                                Console.WriteLine("--------------------------");
                            
                                Console.WriteLine("");
                                Console.WriteLine("------------------------------------------");
                                Console.WriteLine("Desea continuar con el CAJERO AUTOMATICO");
                                Console.WriteLine("1-Si");
                                Console.WriteLine("2-No");

                                continuar = int.Parse(Console.ReadLine());

                                if (continuar <= 0 || continuar >= 2)
                                {
                                    Console.WriteLine("---------------------------------------");
                                    Console.WriteLine("Gracias por utilizar nuestros servicios.");
                                    Console.WriteLine("----------------------------------------");
                                    Console.ReadLine();
                                }
                            }

                        }
                        else
                        {


                            Console.WriteLine("Pin invalido");
                            Console.ReadLine();


                        }
                    } 




                    //Codigo para tarjeta Popular
                    else if (tarjeta == tarjetaPopular)
                    {
                        Console.WriteLine("Haz ingresado con la tarjeta del BANCO POPULAR");
                        Console.WriteLine("");
                        Console.WriteLine("Ingresa el pin: ");
                        int pin2 = int.Parse(Console.ReadLine());

                        if (pin2 == clave2)
                        {
                            Console.WriteLine("");
                            Console.WriteLine("--------------------------");
                            Console.WriteLine("BANCO POPULAR");
                            Console.WriteLine("--------------------------");
                            Console.WriteLine("Ahora elije una opcion: ");
                            Console.WriteLine("1-Depositar balance");
                            Console.WriteLine("2-Retirar balance");
                            Console.WriteLine("3-Consultar balance");
                            Console.WriteLine("4-Salir");
                            Console.WriteLine("");


                             opcion1 = int.Parse(Console.ReadLine());

                            if (opcion1 == 1)
                            {
                                Console.WriteLine("");
                                Console.WriteLine("--------------------------");
                                Console.WriteLine("Ingrese el monto que desea depositar: ");
                                Console.WriteLine("--------------------------");

                                int montoNuevo2 = int.Parse(Console.ReadLine());

                                monto2 = montoNuevo2 + monto2;

                                Console.WriteLine("");
                                Console.WriteLine("El nuevo balance es: " + monto2);
                               
                                Console.WriteLine("");
                                Console.WriteLine("------------------------------------------");
                                Console.WriteLine("Desea continuar con el CAJERO AUTOMATICO");
                                Console.WriteLine("1-Si");
                                Console.WriteLine("2-No");

                                continuar = int.Parse(Console.ReadLine());

                                if (continuar <= 0 || continuar >= 2)
                                {
                                    Console.WriteLine("---------------------------------------");
                                    Console.WriteLine("Gracias por utilizar nuestros servicios.");
                                    Console.WriteLine("----------------------------------------");
                                    Console.ReadLine();
                                }
                            }
                            if (opcion1 == 2)
                            {
                                Console.WriteLine("");
                                Console.WriteLine("--------------------------");
                                Console.WriteLine("Ingrese el balance que desea retirar: ");
                                Console.WriteLine("--------------------------");
                                int retiroNuevo2 = int.Parse(Console.ReadLine());

                                if (retiroNuevo2 <= monto2)
                                {
                                    Console.WriteLine("");
                                    Console.WriteLine("Transaccion realizada con exito.");
                                    Console.WriteLine("Tu nuevo balance es $" + (monto2 - retiroNuevo2));
                                  
                                    Console.WriteLine("");
                                    Console.WriteLine("------------------------------------------");
                                    Console.WriteLine("Desea continuar con el CAJERO AUTOMATICO");
                                    Console.WriteLine("1-Si");
                                    Console.WriteLine("2-No");

                                    continuar = int.Parse(Console.ReadLine());

                                    if (continuar <= 0 || continuar >= 2)
                                    {
                                        Console.WriteLine("---------------------------------------");
                                        Console.WriteLine("Gracias por utilizar nuestros servicios.");
                                        Console.WriteLine("----------------------------------------");
                                        Console.ReadLine();
                                    }

                                }
                                else
                                {
                                    Console.WriteLine("");
                                    Console.WriteLine("No tienes fondos suficientes para realizar esta transaccion");
                                    Console.WriteLine("");
                                    Console.WriteLine("------------------------------------------");
                                    Console.WriteLine("Desea continuar con el CAJERO AUTOMATICO");
                                    Console.WriteLine("1-Si");
                                    Console.WriteLine("2-No");

                                    continuar = int.Parse(Console.ReadLine());

                                    if (continuar <= 0 || continuar >= 2)
                                    {
                                        Console.WriteLine("---------------------------------------");
                                        Console.WriteLine("Gracias por utilizar nuestros servicios.");
                                        Console.WriteLine("----------------------------------------");
                                        Console.ReadLine();
                                    }
                                }
                            }

                            if (opcion1 == 3)
                            {
                                Console.WriteLine("");
                                Console.WriteLine("--------------------------");
                                Console.WriteLine("Tu balance es $" + monto2);
                                Console.WriteLine("--------------------------");
                                
                                Console.WriteLine("");
                                Console.WriteLine("------------------------------------------");
                                Console.WriteLine("Desea continuar con el CAJERO AUTOMATICO");
                                Console.WriteLine("1-Si");
                                Console.WriteLine("2-No");

                                continuar = int.Parse(Console.ReadLine());

                                if (continuar <= 0 || continuar >= 2)
                                {
                                    Console.WriteLine("---------------------------------------");
                                    Console.WriteLine("Gracias por utilizar nuestros servicios.");
                                    Console.WriteLine("----------------------------------------");
                                    Console.ReadLine();
                                }
                            }

                           
                        }
                        else
                        {


                            Console.WriteLine("Pin invalido");
                            Console.ReadLine();


                        }

                    }


                    //Codigo para tarjeta BHD
                    else if (tarjeta == tarjetaBHD)
                    {
                        Console.WriteLine("Haz ingresado con la tarjeta del BANCO BHD LEON");
                        Console.WriteLine("");
                        Console.WriteLine("Ingresa el pin: ");
                        int pin3 = int.Parse(Console.ReadLine());

                        if (pin3 == clave3)
                        {
                            Console.WriteLine("");
                            Console.WriteLine("--------------------------");
                            Console.WriteLine("BANCO BHD LEON");
                            Console.WriteLine("--------------------------");
                            Console.WriteLine("Ahora elije una opcion: ");
                            Console.WriteLine("1-Depositar balance");
                            Console.WriteLine("2-Retirar balance");
                            Console.WriteLine("3-Consultar balance");
                            Console.WriteLine("4-Salir");
                            Console.WriteLine("");


                             opcion1 = int.Parse(Console.ReadLine());

                            if (opcion1 == 1)
                            {
                                Console.WriteLine("");
                                Console.WriteLine("--------------------------");
                                Console.WriteLine("Ingrese el monto que desea depositar: ");
                                Console.WriteLine("--------------------------");

                                int montoNuevo3 = int.Parse(Console.ReadLine());

                                monto3 = montoNuevo3 + monto3;

                                Console.WriteLine("");
                                Console.WriteLine("El nuevo balance es: " + monto3);
                               
                                Console.WriteLine("");
                                Console.WriteLine("------------------------------------------");
                                Console.WriteLine("Desea continuar con el CAJERO AUTOMATICO");
                                Console.WriteLine("1-Si");
                                Console.WriteLine("2-No");

                                continuar = int.Parse(Console.ReadLine());

                                if (continuar <= 0 || continuar >= 2)
                                {
                                    Console.WriteLine("---------------------------------------");
                                    Console.WriteLine("Gracias por utilizar nuestros servicios.");
                                    Console.WriteLine("----------------------------------------");
                                    Console.ReadLine();
                                }
                            }
                            if (opcion1 == 2)
                            {
                                Console.WriteLine("");
                                Console.WriteLine("--------------------------");
                                Console.WriteLine("Ingrese el balance que desea retirar: ");
                                Console.WriteLine("--------------------------");
                                int retiroNuevo3 = int.Parse(Console.ReadLine());

                                if (retiroNuevo3 <= monto3)
                                {
                                    Console.WriteLine("");
                                    Console.WriteLine("Transaccion realizada con exito.");
                                    Console.WriteLine("Tu nuevo balance es $" + (monto3 - retiroNuevo3));
                                    
                                    Console.WriteLine("");
                                    Console.WriteLine("------------------------------------------");
                                    Console.WriteLine("Desea continuar con el CAJERO AUTOMATICO");
                                    Console.WriteLine("1-Si");
                                    Console.WriteLine("2-No");

                                    continuar = int.Parse(Console.ReadLine());

                                    if (continuar <= 0 || continuar >= 2)
                                    {
                                        Console.WriteLine("---------------------------------------");
                                        Console.WriteLine("Gracias por utilizar nuestros servicios.");
                                        Console.WriteLine("----------------------------------------");
                                        Console.ReadLine();
                                    }

                                }
                                else
                                {
                                    Console.WriteLine("");
                                    Console.WriteLine("No tienes fondos suficientes para realizar esta transaccion");
                                    Console.WriteLine("");
                                    Console.WriteLine("------------------------------------------");
                                    Console.WriteLine("Desea continuar con el CAJERO AUTOMATICO");
                                    Console.WriteLine("1-Si");
                                    Console.WriteLine("2-No");

                                    continuar = int.Parse(Console.ReadLine());

                                    if (continuar <= 0 || continuar >= 2)
                                    {
                                        Console.WriteLine("---------------------------------------");
                                        Console.WriteLine("Gracias por utilizar nuestros servicios.");
                                        Console.WriteLine("----------------------------------------");
                                        Console.ReadLine();
                                    }
                                }
                            }

                            if (opcion1 == 3)
                            {
                                Console.WriteLine("");
                                Console.WriteLine("--------------------------");
                                Console.WriteLine("Tu balance es $" + monto3);
                                Console.WriteLine("--------------------------");
                                   Console.WriteLine("");
                                Console.WriteLine("------------------------------------------");
                                Console.WriteLine("Desea continuar con el CAJERO AUTOMATICO");
                                Console.WriteLine("1-Si");
                                Console.WriteLine("2-No");

                                continuar = int.Parse(Console.ReadLine());

                                if (continuar <= 0 || continuar >= 2)
                                {
                                    Console.WriteLine("---------------------------------------");
                                    Console.WriteLine("Gracias por utilizar nuestros servicios.");
                                    Console.WriteLine("----------------------------------------");
                                    Console.ReadLine();
                                }
                            }

                        }
                        else
                        {


                            Console.WriteLine("Pin invalido");
                            Console.ReadLine();


                        }

                    }
                    else
                    {
                        Console.WriteLine("Tarjeta invalida.");
                        Console.ReadLine();
                    }

                }
                
            }
            
        }
    }
}
