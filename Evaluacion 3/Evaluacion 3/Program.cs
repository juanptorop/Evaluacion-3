using System;

namespace Evaluacion_3
{
    public class Program
    {
        public static void Main(string[] args)
        {

            string dato = "";
            int edadperro = 0;
            int ActividadPerro = 0;
            double peso = 0.0;
            int edad = 0;
            int opcion = 0;
            int tamaño = 0;



            do
            {

                Console.WriteLine("Bienvenidos al programa para saber cuanto debe comer su perro\n\n");

                Console.WriteLine("¿su perro es adulto o cachorro?:");
                Console.WriteLine("1 - cachorro");
                Console.WriteLine("2 - adulto");
                dato = Console.ReadLine();
                edadperro = Convert.ToInt32(dato);


                switch (edadperro)
                {
                    case 1:
                        Console.WriteLine("Por favor ingrese el tamaño de su perro:");
                        Console.WriteLine("1=miniatura");
                        Console.WriteLine("2=pequeño");
                        Console.WriteLine("3=mediano");
                        Console.WriteLine("4=grande");
                        dato = Console.ReadLine();
                        tamaño = Convert.ToInt32(dato);

                        switch (tamaño)
                        {
                            case 1:
                                Console.WriteLine("¿Cuantos meses tiene su perro?::");
                                Console.WriteLine("2 meses");
                                Console.WriteLine("3 mese");
                                Console.WriteLine("4 meses");
                                Console.WriteLine("5 meses");
                                Console.WriteLine("6-12 meses");
                                dato = Console.ReadLine();
                                edad = Convert.ToInt32(dato);

                                switch (edad)
                                {
                                    case 1:
                                        Console.WriteLine("Su perro debe comer 50 gramos .");
                                        break;
                                    case 2:
                                        Console.WriteLine("Su perro debe comer  60 gramos.");
                                        break;
                                    case 3:
                                        Console.WriteLine("Su perro debe comer 60 gramos.");
                                        break;
                                    case 4:
                                        Console.WriteLine("Su perro debe comer 60 gramos.");
                                        break;
                                    case 5:
                                        Console.WriteLine("Su perro debe comer 55 gramos.");
                                        break;
                                }
                                break;

                            case 2:
                                Console.WriteLine("¿Cuantos meses tiene su perro?:");
                                Console.WriteLine("2 meses");
                                Console.WriteLine("3 mese");
                                Console.WriteLine("4 meses");
                                Console.WriteLine("5 meses");
                                Console.WriteLine("6-12 meses");
                                dato = Console.ReadLine();
                                edad = Convert.ToInt32(dato);

                                switch (edad)
                                {
                                    case 1:
                                        Console.WriteLine("Su perro debe comer entre 95 y 155 gramos .");
                                        break;
                                    case 2:
                                        Console.WriteLine("Su perro debe comer entre 110 y 185 gramos.");
                                        break;
                                    case 3:
                                        Console.WriteLine("Su perro debe comer entre 115 y 195 gramos.");
                                        break;
                                    case 4:
                                        Console.WriteLine("Su perro debe comer entre 115 y 190 gramos.");
                                        break;
                                    case 5:
                                        Console.WriteLine("Su perro debe comer entre 110 y 185 gramos.");
                                        break;
                                }

                                break;
                            case 3:
                                Console.WriteLine("¿Cuantos meses tiene su perro?:");
                                Console.WriteLine("2 meses");
                                Console.WriteLine("3 mese");
                                Console.WriteLine("4 meses");
                                Console.WriteLine("5 meses");
                                Console.WriteLine("6-12 meses");
                                dato = Console.ReadLine();
                                edad = Convert.ToInt32(dato);

                                switch (edad)
                                {
                                    case 1:
                                        Console.WriteLine("Su perro debe comer 215 gramos .");
                                        break;
                                    case 2:
                                        Console.WriteLine("Su perro debe comer 265 gramos.");
                                        break;
                                    case 3:
                                        Console.WriteLine("Su perro debe comer 285 gramos.");
                                        break;
                                    case 4:
                                        Console.WriteLine("Su perro debe comer 285 gramos.");
                                        break;
                                    case 5:
                                        Console.WriteLine("Su perro debe comer 280 gramos.");
                                        break;
                                }

                                break;

                            case 4:
                                Console.WriteLine("¿¿Cuantos meses tiene su perro?:");
                                Console.WriteLine("2 meses");
                                Console.WriteLine("3 mese");
                                Console.WriteLine("4 meses");
                                Console.WriteLine("5 meses");
                                Console.WriteLine("6-12 meses");
                                dato = Console.ReadLine();
                                edad = Convert.ToInt32(dato);

                                switch (edad)
                                {
                                    case 1:
                                        Console.WriteLine("Su perro debe comer entre 270 y 580 gramos .");
                                        break;
                                    case 2:
                                        Console.WriteLine("Su perro debe comer entre 350 y 670 gramos.");
                                        break;
                                    case 3:
                                        Console.WriteLine("Su perro debe comer entre 375 y 685 gramos.");
                                        break;
                                    case 4:
                                        Console.WriteLine("Su perro debe comer entre 375 y 625 gramos.");
                                        break;
                                    case 5:
                                        Console.WriteLine("Su perro debe comer entre 370 y 530 gramos.");
                                        break;
                                }
                                break;
                        }


                        break;
                    case 2:
                        Console.WriteLine("¿Cuanto pesa su perro:");
                        dato = Console.ReadLine();
                        peso = Convert.ToDouble(dato);


                        Console.WriteLine("¿Cuan activa considera a su mascota?");
                        Console.WriteLine("1 - Actividad Alta");
                        Console.WriteLine("2 - Actividad Normal");
                        Console.WriteLine("3 - Actividad Baja");
                        dato = Console.ReadLine();
                        ActividadPerro = Convert.ToInt32(dato);


                        //Tamaño Miniatura
                        if (peso <= 5 && peso >= 2)
                        {

                            switch (ActividadPerro)
                            {
                                case 1:
                                    Console.WriteLine("Su perro debe comer entre 60 y 115 gramos.");
                                    break;
                                case 2:
                                    Console.WriteLine("Su perro debe comer entre 55 y 100 gramos.");
                                    break;
                                case 3:
                                    Console.WriteLine("Su perro debe comer entre 45 y 85 gramos.");
                                    break;
                            }

                        }

                        //Tamaño pequeño
                        if (peso <= 10 && peso >= 5)
                        {

                            switch (ActividadPerro)
                            {
                                case 1:
                                    Console.WriteLine("Su perro debe comer entre 115 y 190 gramos.");
                                    break;
                                case 2:
                                    Console.WriteLine("Su perro debe comer entre 100 y 170 gramos.");
                                    break;
                                case 3:
                                    Console.WriteLine("Su perro debe comer entre 85 y 145 gramos.");
                                    break;
                            }

                        }
                        //Tamaño Mediano
                        if (peso <= 15 && peso >= 10)
                        {

                            switch (ActividadPerro)
                            {
                                case 1:
                                    Console.WriteLine("Su perro debe comer entre 190 y 255 gramos.");
                                    break;
                                case 2:
                                    Console.WriteLine("Su perro debe comer entre 170 y 225 gramos.");
                                    break;
                                case 3:
                                    Console.WriteLine("Su perro debe comer entre 145 y 195 gramos.");
                                    break;
                            }

                        }

                        //Tamaño grande
                        if (peso <= 25 && peso >= 15)
                        {

                            switch (ActividadPerro)
                            {
                                case 1:
                                    Console.WriteLine("Su perro debe comer entre 255 y 380 gramos.");
                                    break;
                                case 2:
                                    Console.WriteLine("Su perro debe comer entre 225 y 330 gramos.");
                                    break;
                                case 3:
                                    Console.WriteLine("Su perro debe comer entre 195 y 285 gramos.");
                                    break;
                            }

                        }

                        if (peso <= 40 && peso >= 25)
                        {

                            switch (ActividadPerro)
                            {
                                case 1:
                                    Console.WriteLine("Su perro debe comer entre 380 y 535 gramos.");
                                    break;
                                case 2:
                                    Console.WriteLine("Su perro debe comer entre 330 y 475 gramos.");
                                    break;
                                case 3:
                                    Console.WriteLine("Su perro debe comer entre 285 y 410 gramos.");
                                    break;
                            }

                        }

                        if (peso <= 56 && peso >= 40)
                        {

                            switch (ActividadPerro)
                            {
                                case 1:
                                    Console.WriteLine("Su perro debe comer entre 535 y 680 gramos.");
                                    break;
                                case 2:
                                    Console.WriteLine("Su perro debe comer entre 475 y 600 gramos.");
                                    break;
                                case 3:
                                    Console.WriteLine("Su perro debe comer entre 410 y 520 gramos.");
                                    break;
                            }

                        }

                        if (peso <= 70 && peso >= 56)
                        {

                            switch (ActividadPerro)
                            {
                                case 1:
                                    Console.WriteLine("Su perro debe comer entre 680 y 820 gramos.");
                                    break;
                                case 2:
                                    Console.WriteLine("Su perro debe comer entre 600 y 720 gramos.");
                                    break;
                                case 3:
                                    Console.WriteLine("Su perro debe comer entre 520 y 620 gramos.");
                                    break;
                            }

                        }

                        if (peso <= 90 && peso >= 70)
                        {

                            switch (ActividadPerro)
                            {
                                case 1:
                                    Console.WriteLine("Su perro debe comer entre 820 y 985 gramos.");
                                    break;
                                case 2:
                                    Console.WriteLine("Su perro debe comer entre 720 y 870 gramos.");
                                    break;
                                case 3:
                                    Console.WriteLine("Su perro debe comer entre 620 y 750 gramos.");
                                    break;
                            }

                        }

                        break;
                }

                Console.WriteLine("Si desea continuar escriba 1\n de lo contrario escriba 4");
                dato = Console.ReadLine();
                opcion = Convert.ToInt32(dato);

                Console.Clear();


            } while (opcion != 4);




        }
    }
}

        
