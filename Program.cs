Console.WriteLine("Ingrese un numero");//comando para escribir 
string numeroText = Console.ReadLine();//el console.readline es el printf con scanf y lo guardo en una variable string por lo general 

if(int.TryParse(numeroText, out int numero)) //el tryparse compara si el texto es un numero y lo guardo en una variable entero
{
    if(numero > 9)
    {
        char[] caracteres = numeroText.ToCharArray();//con el tocharArray Creo los caracteres que ingrese o tengo en una variable y lo guardo en un arreglo

        Array.Reverse(caracteres);//el array.reverse invierte el arreglo

        string invertido = new string(caracteres); //preparo la estancia con new que tengo entendido es parecido a reservar memoria

        Console.WriteLine("Numero invertidoo: " + invertido);
    }
    else
    {
        Console.WriteLine("El numero debe ser mayor que 0");
    }
}
else
{
    Console.WriteLine("Error, ingrese un numero valido");
}
