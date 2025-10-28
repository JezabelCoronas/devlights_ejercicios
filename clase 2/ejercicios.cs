
//Alumna: CORONAS , JEZABEL 
//En C#, todo el código ejecutable debe estar dentro de un método.

using System;

class Program
{
    static void Main()
    {
        
        Ejercicio1();
        Ejercicio2();
        Ejercicio3();
        Ejercicio4();
        Ejercicio5();
        Ejercicio6();
        Ejercicio7();
        Ejercicio8();
        Ejercicio9();
        Ejercicio10();
        Ejercicio11();
        Ejercicio12();
        Ejercicio13();
        Ejercicio14();
        Ejercicio15();
        Ejercicio16();
        Ejercicio17();
        Ejercicio18();
        Ejercicio19();
        Ejercicio20();
    }

     
     //1. Número positivo o negativo: Pedir un número y mostrar si es positivo, negativo o cero   
    static void Ejercicio1(){

        Console.WriteLine("Ingrese un numero: ");
        var numero= int.Parse(Console.ReadLine());
        
        if(numero>0){
            Console.WriteLine("El numero es positivo");
            }else{
                if(numero==0){
                    Console.WriteLine("El numero es cero");
                }else{
                    Console.WriteLine("El numero es negativo");
                }
            }
    }
    
//2. Comparación de tres números: Pedir tres números distintos y mostrar cuál es el mayor y cuál el menor.
    static void Ejercicio2(){
        Console.WriteLine("Ingrese un numero a: ");
        var a= int.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese un numero b: ");
        var b= int.Parse(Console.ReadLine());
        
        Console.WriteLine("Ingrese un numero c: ");
        var c= int.Parse(Console.ReadLine());
         if((a > b) && (a > c)){
             Console.WriteLine("el numero mayor es: A", a);
         }else{
             if((b>a) && (b>c)){
                Console.WriteLine("el numero mayor es: B", b);
             }else{
               Console.WriteLine("el numero mayor es: C", c);

             }
         }
    }
//3. Múltiplos de un número: Pedir dos números e indicar si el primero es múltiplo del segundo.
    static void Ejercicio3(){
        Console.WriteLine("Ingrese un numero A: ");
        var a= int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese un numero B: ");
        var b= int.Parse(Console.ReadLine());
        
        if(b%a==0){
            Console.WriteLine("B es múltiplo de A");
        }else{
            Console.WriteLine("B no es múltiplo de A");
        }
    }
//4. Descuento en tienda: Pedir el precio de un producto y aplicar un descuento del 10% si el precio es mayor a $1000.
     static void Ejercicio4(){
        Console.WriteLine("Ingrese precio: ");
        var precio= int.Parse(Console.ReadLine());
        
        if(precio>1000){
            int descuento_final = precio-((precio*10)/100);
            Console.WriteLine("Descuento aplicado: " +descuento_final );
        }else{
            Console.WriteLine("No aplica descuento");
        }
    }

//5. Conversión de tipo: Pedir un número decimal y convertirlo a entero (usando conversión explícita). Mostrar ambos valores y comentar la diferencia.
    
    static void Ejercicio5(){
        
    Console.WriteLine("Ingrese un numero decimal: ");
    double numeroDecimal = double.Parse(Console.ReadLine());

    int numeroEntero = (int)numeroDecimal; 

    Console.WriteLine($"Valor decimal ingresado: {numeroDecimal}");
    Console.WriteLine($"Valor entero convertido: {numeroEntero}");
    
    }
    
    //6. Clasificación por edad: Pedir la edad y mostrar si la persona es niño, adolescente, adulto o adulto mayor (usa if-else if-else).
       static void Ejercicio6(){
        Console.WriteLine("Ingrese la edad de la persona: ");
        int edad = int.Parse(Console.ReadLine());
    
        if (edad < 12){
            Console.WriteLine("Niño");
        }else if (edad < 18){
            Console.WriteLine("Adolescente");
        }else if (edad < 60){
            Console.WriteLine("Adulto");
        }else{
            Console.WriteLine("Adulto mayor");
        }
    }
    
    
//7. Número dentro de rango: Pedir un número y verificar si está dentro del rango 1–10 (inclusive)
    
        static void Ejercicio7(){
            Console.WriteLine("Ingrese un numero:");
                int numero = int.Parse(Console.ReadLine());
            
                if (numero >= 1 && numero <= 10){
                    Console.WriteLine("El numero estq dentro del rango 1–10.");
                }else{
                    Console.WriteLine("El numero esta fuera del rango");
                }
        }


        //8. Operador ternario: Pedir un número y mostrar "Par" o "Impar" usando el operador ternario
        static void Ejercicio8(){
                Console.WriteLine("Ingrese un numero: ");
                    int numero = int.Parse(Console.ReadLine());
                 string resultado = (numero % 2 == 0) ? "PAR" : "IMPAR";
                Console.WriteLine($"El numero es: {resultado}");
        }


    /*9.Cálculo de impuestos: Pedir un ingreso anual y calcular el impuesto: 
        < 10,000: 0% 
         10,000–50,000: 10%
         50,000: 20%
       Mostrar el monto de impuesto a pagar.*/

        static void Ejercicio9(){
            Console.WriteLine("Ingrese su ingreso anual: ");
            int ingreso = int.Parse(Console.ReadLine());

            if (ingreso < 10000){
                Console.WriteLine("No se agrega impuestos");
            }else if (ingreso <= 50000){
                int impuesto = (ingreso * 10) / 100;
                Console.WriteLine($"Impuesto del 10%: {impuesto}");
            }else{
                int impuesto = (ingreso * 20) / 100;
                Console.WriteLine($"Impuesto del 20%: {impuesto}");
            }
        }

        //10. Día de la semana con switch: Pedir un número del 1 al 7 y mostrar el día de la semana correspondiente.

        static void Ejercicio10(){
            Console.WriteLine("Ingrese un numero del 1 al 7: ");
            int numero = int.Parse(Console.ReadLine());
            switch(numero){
                case 1: 
                    Console.WriteLine("LUNES");
                    break;
                case 2:
                    Console.WriteLine("MARTES");
                    break;
                case 3:
                     Console.WriteLine("MIERCOLES");
                     break;
                case 4:
                    Console.WriteLine("JUEVES");
                    break;
                case 5:
                    Console.WriteLine("VIERNES");
                    break;
                case 6:
                    Console.WriteLine("SABADO");
                    break;
                case 7:
                    Console.WriteLine("DOMINGO");
                    break;
                default:
                    Console.WriteLine("Opción invalida.");
                    break;
            }

        }

    /*11. Menú con switch: Crear un menú con opciones (1. Sumar, 2. Restar, 3. Multiplicar, 4.Dividir). 
        Pedir dos números y ejecutar la
         operación elegida.*/
       static void Ejercicio11(){
                Console.WriteLine("Ingrese opción: 1) Sumar, 2) Restar, 3) Multiplicar, 4) Dividir");
                int opcion = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese el primer numero:");
                double num1 = double.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese el segundo numero:");
                double num2 = double.Parse(Console.ReadLine());

                switch (opcion){
                    case 1:
                        Console.WriteLine($"Resultado: {num1+num2}");
                        break;
                    case 2:
                        Console.WriteLine($"Resultado: {num1-num2}");
                        break;
                    case 3:
                        Console.WriteLine($"Resultado: {num1*num2}");
                        break;
                    case 4:
                        if (num2 != 0)
                            Console.WriteLine($"Resultado: {num1/num2}");
                        else
                            Console.WriteLine("No se puede dividir por cero");
                        break;
                    default:
                        Console.WriteLine("Opción invalida");
                        break;
                }
            }


  //12. Contador de pares: Pedir un número N y mostrar cuántos números pares hay entre 1 y N.
        static void Ejercicio12(){
            Console.WriteLine("Ingrese un numero N: ");
            int N = int.Parse(Console.ReadLine());

            int contador = 0;

            for (int i = 1; i <= N; i++){
                if (i % 2 == 0){
                    contador++;
                }
            }
            Console.WriteLine($"La cantidad de numeros pares entre 1 y {N} es: {contador}");
        }


 //13. Suma de números impares: Calcular la suma de los números impares del 1 al 100.
        static void Ejercicio13(){
            int suma = 0;
            for (int i = 1; i <= 100; i++){
                if (i % 2 != 0){
                    suma += i;
                }
            }
            Console.WriteLine($"La suma de los numeros impares del 1 al 100 es: {suma}");
        }

 //14. Contador de letras: Pedir una palabra y mostrar cuántas letras tiene.
        static void Ejercicio14(){
            Console.WriteLine("Ingrese una palabra:");
            string palabra = Console.ReadLine();

            int cantidadLetras = palabra.Length;

            Console.WriteLine($"La palabra {palabra} tiene {cantidadLetras} letras");
        }


//15. Tabla de multiplicar: Pedir un número y mostrar su tabla de multiplicar del 1 al 10.
        static void Ejercicio15(){
            Console.WriteLine("Ingrese un numero:");
            int numero = int.Parse(Console.ReadLine());

            Console.WriteLine($"Tabla de multiplicar de {numero}:");

            for (int i = 1; i <= 10; i++){
                Console.WriteLine($"{numero} x {i} = {numero * i}");
            }
        }

//16. Promedio de notas: Pedir 5 notas, calcular el promedio y mostrar si el estudiante aprueba (>=6) o no.
        static void Ejercicio16(){
            double suma = 0;

            for (int i = 1; i <= 5; i++){
                Console.WriteLine($"Ingrese la nota {i}:");
                double nota = double.Parse(Console.ReadLine());
                suma += nota;
            }

            double promedio = suma/5;

            Console.WriteLine($"Promedio: {promedio}");

            if (promedio >= 6){
                Console.WriteLine("APROBADO");
            }else{
                Console.WriteLine("DESAPROBADO");
            }
        }

/*17. Contador hasta que sea cero: Pedir números enteros hasta que el usuario ingrese 0.
Mostrar la cantidad de números introducidos.*/
        static void Ejercicio17(){
            int contador = 0;
            int numero;

            do{
                Console.WriteLine("Ingrese un numero entero, presione 0 para finalizar: ");
                numero = int.Parse(Console.ReadLine());

                if (numero!=0){
                    contador++;
                }

            } while (numero!=0);

            Console.WriteLine($"Cantidad de nros: {contador}");
        }


//18. Suma acumulada con condición: Pedir números y sumar hasta que la suma supere 100. 
//Mostrar cuántos números se ingresaron.
        static void Ejercicio18(){
            int suma=0;
            int contador =0;

            while (suma<=100){
                Console.WriteLine("Ingrese un numero:");
                int numero = int.Parse(Console.ReadLine());
                suma += numero;
                contador++;
            }

            Console.WriteLine($"Se ingresaron {contador} numeros hasta superar 100");
        }


//19. Contador de dígitos: Pedir un número entero y decir cuántos dígitos tiene.
        static void Ejercicio19(){
                Console.WriteLine("Ingrese un numero entero:");
                int numero = int.Parse(Console.ReadLine());

                int cantidadDigitos = numero.ToString().Length;

                Console.WriteLine($"La cabntidad de digitos es: {cantidadDigitos} ");
        }


//20. Contar vocales: Pedir una palabra y contar cuántas vocales tiene.

        static void Ejercicio20(){
            Console.WriteLine("Ingrese una palabra:'");
            string palabra = Console.ReadLine().ToLower();

            int contadorVocales = 0;

            foreach (char c in palabra){
                if ("aeiou".Contains(c)){
                    contadorVocales++;
                }
            }

            Console.WriteLine($"La cantidad de vocales es: {contadorVocales}");
        }

/*Ejercicio 21 - Extra - Opcional:
21. Mini cajero automático
Simular un cajero con un saldo inicial. Mostrar un menú con opciones:
● 1) Consultar saldo
● 2) Depositar
● 3) Retirar
● 4) Salir
Validar que no se retire más de lo que hay y que los montos sean positivos.*/


static void Ejercicio21(){
    double saldo = 1000; 

        Console.WriteLine("\nMENÚ CAJERO AUTOMÁTICO");
        Console.WriteLine("1) Consultar saldo");
        Console.WriteLine("2) Depositar");
        Console.WriteLine("3) Retirar");
        Console.WriteLine("4) Salir");
        Console.Write("Seleccione una opción: ");

        int opcion = int.Parse(Console.ReadLine());

        switch (opcion){
            case 1:
                Console.WriteLine($"Saldo actual: ${saldo}");
                break;

            case 2:
                Console.Write("Ingrese monto a depositar: ");
                double deposito = double.Parse(Console.ReadLine());
                if (deposito > 0){
                    saldo += deposito;
                    Console.WriteLine($"Depósito exitoso, Nuevo saldo: ${saldo}");
                }else{
                    Console.WriteLine("Error: El monto debe ser positivo.");
                }
                break;

            case 3:
                Console.Write("Ingrese monto a retirar: ");
                double retiro = double.Parse(Console.ReadLine());
                if (retiro > 0 && retiro <= saldo){
                    saldo -= retiro;
                    Console.WriteLine($"Retiro exitoso. Nuevo saldo: ${saldo}");
                }else if (retiro > saldo){
                    
                    Console.WriteLine("Error: Fondos insuficientes");
                }else{
                    Console.WriteLine("Error: El monto debe ser positivo");
                }
                break;

            case 4:
                Console.WriteLine("FIN");
                break;

            default:
                Console.WriteLine("Opción invalida");
                break;
        }

    } 
}
 

