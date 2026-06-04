Console.WriteLine("CALCULADORA V2");

Console.Write("Ingrese un numero: ");
string numeroText = Console.ReadLine();

if (!double.TryParse(numeroText, out double numero))
{
    Console.WriteLine("Debe ingresar un número válido.");
    return;
}

Console.WriteLine("Valor absoluto: " + Math.Abs(numero)); //math.abs es para valor abs

Console.WriteLine("Cuadrado: " + Math.Pow(numero, 2)); //mat.pow eleva al cuadrado

Console.WriteLine("Raíz cuadrada: " + Math.Sqrt(numero));// math.sqrt es para la raiz

Console.WriteLine("Seno: " + Math.Sin(numero)); //seno

Console.WriteLine("Coseno: " + Math.Cos(numero));//coseno

Console.WriteLine("Parte entera: " + Math.Truncate(numero));
//pido los 2 num
Console.Write("Ingrese el primer número: ");
string num1Texto = Console.ReadLine();

Console.Write("Ingrese el segundo número: ");
string num2Texto = Console.ReadLine();

if (!double.TryParse(num1Texto, out double num1) ||
    !double.TryParse(num2Texto, out double num2))
{
    Console.WriteLine("Debe ingresar números válidos.");
    return;
}

Console.WriteLine("Máximo: " + Math.Max(num1, num2)); //maximo

Console.WriteLine("Mínimo: " + Math.Min(num1, num2));//minimo














































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
