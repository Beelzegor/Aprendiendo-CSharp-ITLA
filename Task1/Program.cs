class MiprimertareadeCSharp
{
    static void Main()
    {
        // 1.	Declarar variable de los diferentes tipos, asignarles valor e imprimir el valor. 
        int numero = 96;
        string texto = "Hola Mundo";
        double decimalLargo = 121.3456;
        char letra = 'K';
        bool esVerdadero = true;

        Console.WriteLine("Número: " + numero);
        Console.WriteLine("Texto: " + texto);
        Console.WriteLine("Double: " + decimalLargo);
        Console.WriteLine("Letra: " + letra);
        Console.WriteLine("Booleano: " + esVerdadero);

        // 2. Declarar una constante en C#
        const double PI = 3.14159;
        Console.WriteLine("Valor de la constante PI: " + PI);
        // Una constante se declara con "const", al convertir una variable en constante no puede ser modificada.

        // 3. Declarar un entero, incrementarlo, decrementarlo y hacer operaciones
        int contador = 7;
        contador++; 
        Console.WriteLine("Incrementado ++: " + contador);
        contador--;
        Console.WriteLine("Decrementado --: " + contador);
        contador = contador * 2;
        Console.WriteLine("Multiplicado por 2: " + contador);

        // 4. Declarar un float y un byte
        float numeroFloat = 10152466.25f;
        // byte resultado = (byte)(5 + numeroFlotante);
        byte resultado = (byte)(5 + (int)numeroFloat);
        Console.WriteLine("Float: " + numeroFloat);
        Console.WriteLine("Byte: " + resultado);

        /* 
         * 5. Comentario de varias líneas:
         * Este comentario posee varias lineas
         * puede ser utilizado para explicaciones mas detalladas y tal
         * al igual que un comentario normal pues este no se ejecuta en el codigo
         */

        // Este es un comentario de una sola linea, a continuación se imprime la fecha y hora del sistema
        Console.WriteLine("Fecha y hora actual: " + DateTime.Now);
    }
}
