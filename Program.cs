//----------------- PUNTO 4 ----------------//

// 1. Ingresar una cadena de texto
Console.Write("Ingrese una cadena de texto: ");
string cadena = Console.ReadLine() ?? "";


// 2. Obtener la longitud de la cadena
Console.WriteLine("\n--- LONGITUD DE LA CADENA ---");
Console.WriteLine($"La longitud de la cadena es: {cadena.Length}");


// 3. Concatenar con una segunda cadena
Console.WriteLine("\n--- CONCATENACIÓN ---");

Console.Write("Ingrese una segunda cadena: ");
string cadena2 = Console.ReadLine() ?? "";

string concatenada = cadena + " " + cadena2;

Console.WriteLine($"Cadena concatenada: {concatenada}");


// 4. Extraer una subcadena
Console.WriteLine("\n--- SUBCADENA ---");

Console.Write("Ingrese la posición inicial: ");

if (!int.TryParse(Console.ReadLine(), out int inicio))
{
    Console.WriteLine("Posición inválida.");
    return;
}

Console.Write("Ingrese la cantidad de caracteres: ");

if (!int.TryParse(Console.ReadLine(), out int cantidad))
{
    Console.WriteLine("Cantidad inválida.");
    return;
}

if (inicio >= 0 && inicio + cantidad <= cadena.Length)
{
    string subcadena = cadena.Substring(inicio, cantidad);
    Console.WriteLine($"Subcadena obtenida: {subcadena}");
}
else
{
    Console.WriteLine("Rango inválido.");
}


// 5. Recorrer la cadena utilizando foreach
Console.WriteLine("\n--- RECORRER CADENA CON FOREACH ---");

foreach (char caracter in cadena)
{
    Console.WriteLine(caracter);
}


// 6. Buscar una palabra dentro de la cadena
Console.WriteLine("\n--- BUSCAR PALABRA ---");

Console.Write("Ingrese la palabra a buscar: ");
string palabra = Console.ReadLine() ?? "";

if (cadena.Contains(palabra))
{
    Console.WriteLine("La palabra existe en la cadena.");
    Console.WriteLine($"Posición encontrada: {cadena.IndexOf(palabra)}");
}
else
{
    Console.WriteLine("La palabra no fue encontrada.");
}


// 7. Convertir la cadena a mayúsculas y minúsculas
Console.WriteLine("\n--- MAYÚSCULAS Y MINÚSCULAS ---");

Console.WriteLine($"Mayúsculas: {cadena.ToUpper()}");
Console.WriteLine($"Minúsculas: {cadena.ToLower()}");


// 8. Separar una cadena utilizando Split()
Console.WriteLine("\n--- SPLIT ---");

Console.Write("Ingrese palabras separadas por coma (,): ");
string textoSplit = Console.ReadLine() ?? "";

string[] partes = textoSplit.Split(',');

Console.WriteLine("\nElementos encontrados:");

foreach (string parte in partes)
{
    Console.WriteLine(parte.Trim());
}


// 9. Mostrar el resultado de una operación en texto utilizando ToString()
Console.WriteLine("\n--- OPERACIÓN EN TEXTO ---");

Console.Write("Ingrese el primer número: ");

if (!double.TryParse(Console.ReadLine(), out double num1))
{
    Console.WriteLine("Número inválido.");
    return;
}

Console.Write("Ingrese el segundo número: ");

if (!double.TryParse(Console.ReadLine(), out double num2))
{
    Console.WriteLine("Número inválido.");
    return;
}

double suma = num1 + num2;

Console.WriteLine(
    "La suma de " +
    num1.ToString() +
    " y de " +
    num2.ToString() +
    " es igual a: " +
    suma.ToString()
);


// 10. Resolver una ecuación simple ingresada como cadena
Console.WriteLine("\n--- RESOLVER ECUACIÓN ---");

Console.Write("Ingrese una operación (ejemplo: 582+2): ");
string operacion = Console.ReadLine() ?? "";

string[] numeros = operacion.Split('+');

if (numeros.Length == 2)
{
    if (int.TryParse(numeros[0], out int numero1) &&
        int.TryParse(numeros[1], out int numero2))
    {
        int resultado = numero1 + numero2;

        Console.WriteLine($"Resultado: {resultado}");
    }
    else
    {
        Console.WriteLine("Los valores ingresados no son válidos.");
    }
}
else
{
    Console.WriteLine("Operación inválida.");
}



//----------------- PUNTO 2 y 3 ----------------//
// Console.WriteLine("CALCULADORA V1");

// Console.Write("Ingrese un numero: ");
// string numeroText = Console.ReadLine();


// bool continuar = true;

// while (continuar)
// {
//     Console.WriteLine("=== CALCULADORA ===");
//     Console.WriteLine("1 - Sumar");
//     Console.WriteLine("2 - Restar");
//     Console.WriteLine("3 - Multiplicar");
//     Console.WriteLine("4 - Dividir");

//     Console.Write("Seleccione una opción: ");

//     string opcionText = Console.ReadLine();

//     if(!int.TryParse(opcionText, out int opción))
//     {
//         Console.WriteLine("Debe Ingresar un numero valido");
//         continue;//sirve para volver al inicio del while direcamente
//     }

//     Console.WriteLine("Ingrese EL Primer Numero: ");
//     string num1Text = Console.ReadLine();

//     Console.WriteLine("Ingrese El Segundo Numero: ");
//     string num2Text = Console.ReadLine();

//     if (!double.TryParse(num1Text, out double num1) || !double.TryParse(num2Text, out double num2)) //el double se usa por si ingresa 1.0 o numero con decimal
//     {
//         Console.WriteLine("Debe ingresar números válidos.");
//         continue;
//     }

//     switch (opción)
//     {
//         case 1:
//         Console.WriteLine($"Resultado: {num1 + num2}");// el $ me permite escribir y realizar operaciones
//         break;

//     case 2:
//         Console.WriteLine($"Resultado: {num1 - num2}");
//         break;

//     case 3:
//         Console.WriteLine($"Resultado: {num1 * num2}");
//         break;

//     case 4:
//         Console.WriteLine($"Resultado: {num1 / num2}");
//         break;

//     default:
//         Console.WriteLine("Opción inválida.");
//         break;
//     }
//     Console.Write("¿Desea realizar otro cálculo? (s/n): ");
//     string respuesta = Console.ReadLine();

//     if(respuesta.ToLower() != "s") //tolower convierte en minuscula los caracteres
//     {
//         continuar = false;
//     }
// }

// Console.WriteLine("CALCULADORA V2");

// Console.Write("Ingrese un numero: "); 
// string numeroT = Console.ReadLine(); 
// if (!double.TryParse(numeroT, out double numero)) 
// {
//      Console.WriteLine("Debe ingresar un número válido."); 
//     return; 
// } 
// Console.WriteLine("Valor absoluto: " + Math.Abs(numero)); //math.abs es para valor abs 
// Console.WriteLine("Cuadrado: " + Math.Pow(numero, 2)); //mat.pow eleva al cuadrado 
// Console.WriteLine("Raíz cuadrada: " + Math.Sqrt(numero));// math.sqrt es para la raiz 
// Console.WriteLine("Seno: " + Math.Sin(numero)); //seno 
// Console.WriteLine("Coseno: " + Math.Cos(numero));//coseno 
// Console.WriteLine("Parte entera: " + Math.Truncate(numero)); //pido los 2 num 
// Console.Write("Ingrese el primer número: "); 
// string num1Texto = Console.ReadLine();
// Console.Write("Ingrese el segundo número: "); 
// string num2Texto = Console.ReadLine(); 
// if (!double.TryParse(num1Texto, out double numero1) || !double.TryParse(num2Texto, out double numero2)) 
// { 
//     Console.WriteLine("Debe ingresar números válidos."); 
//     return; 
// } Console.WriteLine("Máximo: " + Math.Max(numero1, numero2)); //maximo Console.WriteLine("Mínimo: " + Math.Min(numero1, numero2));//minimo

// //----------------- PUNTO 1 INVERTIR NUMERO ----------------//


// Console.WriteLine("Ingrese un numero");//comando para escribir 
// string numeroText = Console.ReadLine();//el console.readline es el printf con scanf y lo guardo en una variable string por lo general 

// if(int.TryParse(numeroText, out int numero)) //el tryparse compara si el texto es un numero y lo guardo en una variable entero
// {
//     if(numero > 9)
//     {
//         char[] caracteres = numeroText.ToCharArray();//con el tocharArray Creo los caracteres que ingrese o tengo en una variable y lo guardo en un arreglo

//         Array.Reverse(caracteres);//el array.reverse invierte el arreglo

//         string invertido = new string(caracteres); //preparo la estancia con new que tengo entendido es parecido a reservar memoria

//         Console.WriteLine("Numero invertidoo: " + invertido);
//     }
//     else
//     {
//         Console.WriteLine("El numero debe ser mayor que 0");
//     }
// }
// else
// {
//     Console.WriteLine("Error, ingrese un numero valido");
// }
