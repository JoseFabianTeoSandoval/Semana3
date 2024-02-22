{
    Console.WriteLine("Calcular el Mayor de Tres Números");
    Console.Write("Ingrese el primer número: ");
    int num1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Ingrese el segundo número: ");
    int num2 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Ingrese el tercer número: ");
    int num3 = Convert.ToInt32(Console.ReadLine());
    int mayor = num1;
    if (num2 > mayor)
    {
        mayor = num2;
    }
    if (num3 > mayor)
    {
        mayor = num3;
    }
    Console.WriteLine("El mayor de los tres números es: " + mayor);
}
{
    Console.WriteLine("Validar Edad para Ingresar a un Club");
    Console.Write("Ingrese su edad:");
    int edad = Convert.ToInt32(Console.ReadLine());
    if (edad >= 18)
    {
        Console.WriteLine("Bienvenido al club.");
    }
    else
    {
        Console.WriteLine("Lo sentimos, debes tener al menos 18 años para ingresar al club.");
    }

}
{
    Console.WriteLine("Calcular el Precio Final de un Producto");
    Console.Write("Ingrese el precio original del producto: ");
    double precio = Convert.ToDouble(Console.ReadLine());
    if (precio > 100)
    {
        double descuento = precio * 0.1;
        double precioF = precio - descuento;
        Console.WriteLine("El precio después del descuento del 10% es: " + precioF);
    }
    else
    {
        Console.WriteLine("El precio original es menor o igual a Q100, no aplica descuento.");
    }

}



