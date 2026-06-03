bool continuar = true;

while (continuar)
{
    Console.WriteLine("=== CALCULADORA ===");
    Console.WriteLine("1 - Sumar");
    Console.WriteLine("2 - Restar");
    Console.WriteLine("3 - Multiplicar");
    Console.WriteLine("4 - Dividir");

    Console.Write("Seleccione una opción: ");

    string opcionText = Console.ReadLine();

    if(!int.TryParse(opcionText, out int opción))
    {
        Console.WriteLine("Debe Ingresar un numero valido");
        continue;//sirve para volver al inicio del while direcamente
    }

    Console.WriteLine("Ingrese EL Primer Numero: ");
    string num1Text = Console.ReadLine();

    Console.WriteLine("Ingrese El Segundo Numero: ");
    string num2Text = Console.ReadLine();

    if (!double.TryParse(num1Text, out double num1) || !double.TryParse(num2Text, out double num2)) //el double se usa por si ingresa 1.0 o numero con decimal
    {
        Console.WriteLine("Debe ingresar números válidos.");
        continue;
    }

    switch (opción)
    {
        case 1:
        Console.WriteLine($"Resultado: {num1 + num2}");// el $ me permite escribir y realizar operaciones
        break;

    case 2:
        Console.WriteLine($"Resultado: {num1 - num2}");
        break;

    case 3:
        Console.WriteLine($"Resultado: {num1 * num2}");
        break;

    case 4:
        Console.WriteLine($"Resultado: {num1 / num2}");
        break;

    default:
        Console.WriteLine("Opción inválida.");
        break;
    }
    Console.Write("¿Desea realizar otro cálculo? (s/n): ");
    string respuesta = Console.ReadLine();

    if(respuesta.ToLower() != "s") //tolower convierte en minuscula los caracteres
    {
        continuar = false;
    }
}





















//----------------- PUNTO 1 INVERTIR NUMERO ----------------//


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
