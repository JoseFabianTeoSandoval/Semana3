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
    Console.WriteLine("\nValidar Edad para Ingresar a un Club");
    Console.Write("Ingrese su edad:");
    int edad = Convert.ToInt32(Console.ReadLine());
    if (edad >= 18)
    {
        Console.WriteLine("Bienvenido al club.");
    }
    else
    {
        Console.WriteLine("Debes tener al menos 18 años para ingresar al club.");
    }

}
{
    Console.WriteLine("\nCalcular el Precio Final de un Producto");
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
{
    Console.WriteLine("\nValidar Usuario y Contraseña");
    Console.Write("Ingrese su nombre de usuario: ");
    string usuario = Console.ReadLine();
    Console.Write("Ingrese su contraseña: ");
    string contraseña = Console.ReadLine();
    if (usuario == "jteos1" && contraseña == "23f27j25k")
    {
        Console.WriteLine("Acceso concedido. Bienbenido.");
    }
    else
    {
        Console.WriteLine("Acceso denegado. Usuario o Contraseña incorrecto.");
    }
}
{
    Console.WriteLine("\nDeterminar si un Numero es Par o Impar");
    Console.Write("Ingrese un numero:");
    int num4 = Convert.ToInt32(Console.ReadLine());
    if (num4 % 2 == 0)
    {
        Console.WriteLine("El numero es par.");
    }
    else
    {
        Console.WriteLine("El numero es impar.");
    }
}
{
    Console.WriteLine("\nMostrar un Mensaje de Aprobacion o Rechazo de Prestamo");
    Console.Write("Ingrese el monto del prestamo: ");
    double monto = Convert.ToDouble(Console.ReadLine());
    Console.Write("Ingrese su edad: ");
    int edad = Convert.ToInt32(Console.ReadLine());
    if (monto < 5000 || edad > 60)
    {
        Console.WriteLine("Prestamo aprobado.");
    }
    else
    {
        Console.WriteLine("Prestamo rechazado.");
    }
}
{
    Console.WriteLine("\nCalcular el Area de una Figura Geometrica");
    Console.Write("Ingrese la Figura (triangulo, cuadrado o circulo):");
    string Figura = Console.ReadLine();
    double area = 0;
    if (Figura.ToLower() == "triangulo")
    {
        Console.Write("Ingrese la base del triangulo:");
        double baseT = Convert.ToDouble(Console.ReadLine());
        Console.Write("Ingrese la altura del triangulo:");
        double alturaT = Convert.ToDouble(Console.ReadLine());
        area = 0.5 * baseT * alturaT;
    }
    else if (Figura.ToLower() == "cuadrado")
    {
        Console.Write("Ingrese el lado del cuadrado:");
        double ladoC = Convert.ToDouble(Console.ReadLine());
        area = ladoC * ladoC;
    }
    else if (Figura.ToLower() == "circulo")
    {
        Console.Write("Ingrese el radio del circulo:");
        double radioC = Convert.ToDouble(Console.ReadLine());
        area = Math.PI * radioC * radioC;
    }
    else
    {
        Console.WriteLine("Figura no reconocida.");
    }

    Console.WriteLine("El area de la figura es: " + area);
}
{
    Console.WriteLine("\nConvertir un Numero de Letra a Numero");
    Console.Write("Ingrese un numero del 1 al 5 en letra:");
    string numL = Console.ReadLine().ToLower();
    int num5;
    switch (numL)
    {
        case "uno":
            num5 = 1;
            break;
        case "dos":
            num5 = 2;
            break;
        case "tres":
            num5 = 3;
            break;
        case "cuatro":
            num5 = 4;
            break;
        case "cinco":
            num5 = 5;
            break;
        default:
            Console.WriteLine("Numero no reconocido.");
            return;
    }
    Console.WriteLine("El numero en digito es: " + num5);
}
{
    Console.WriteLine("\nMostrar el Dia de la Semana a partir de un Numero");
    Console.Write("Ingrese un numero del 1 al 7: ");
    int num6 = Convert.ToInt32(Console.ReadLine());
    string dia;
    switch (num6)
    {
        case 1:
            dia = "Lunes";
            break;
        case 2:
            dia = "Martes";
            break;
        case 3:
            dia = "Miércoles";
            break;
        case 4:
            dia = "Jueves";
            break;
        case 5:
            dia = "Viernes";
            break;
        case 6:
            dia = "Sábado";
            break;
        case 7:
            dia = "Domingo";
            break;
        default:
            Console.WriteLine("Numero no valido.");
            return;
    }
    Console.WriteLine("El dia de la semana es: " + dia);
}
{
    Console.WriteLine("\nCalcular el Importe a Pagar por un Servicio");
    Console.Write("Ingrese el tipo de servicio (lavado de auto, cambio de aceite, revision mecanica):");
    string servicio = Console.ReadLine().ToLower();
    double importe;
    switch (servicio)
    {
        case "lavado de auto":
            importe = 20;
            break;
        case "cambio de aceite":
            importe = 50;
            break;
        case "revision mecanica":
            importe = 100;
            break;
        default:
            Console.WriteLine("Servicio no reconocido.");
            return;
    }
    Console.WriteLine($"El importe a pagar por {servicio} es: {importe}");
}
{
    Console.WriteLine("\nMostrar un Mensaje de Bienvenida en Diferentes Idiomas");
    Console.Write("Ingrese el idioma de su preferencia (español, ingles, frances):");
    string idioma = Console.ReadLine().ToLower();
    string mensaje;
    switch (idioma)
    {
        case "español":
            mensaje = "¡Bienvenido!";
            break;
        case "ingles":
            mensaje = "Welcome!";
            break;
        case "frances":
            mensaje = "Bienvenue!";
            break;
        default:
            Console.WriteLine("Idioma no reconocido.");
            return;
    }
    Console.WriteLine($"Mensaje en {idioma}: {mensaje}");
}
{
    Console.WriteLine("\nEvaluar la Calificacion de un Examen");
    Console.Write("Ingrese la calificacion del examen:");
    int calificacion = Convert.ToInt32(Console.ReadLine());
    string desempeño;
    switch (calificacion)
    {
        case >= 90 and <= 100:
            desempeño = "Sobresaliente.";
            break;
        case >= 80 and <= 89:
            desempeño = "Notable.";
            break;
        case >= 70 and <= 79:
            desempeño = "Promedio.";
            break;
        case >= 62 and <= 69:
            desempeño = "Aprovado.";
            break;
        case 61:
            desempeño = "Aprovado con la nota minima.";
            break;
        case >= 0 and <= 60:
            desempeño = "Reprovado.";
            break;
        default:
            Console.WriteLine("Error. Calificacion no valida.");
            return;
    }
    Console.WriteLine($"Desempeño en el examen: {desempeño}");
}






