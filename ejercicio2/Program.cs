int[,] notas = new int[3, 3];
int[] sumaFilas = new int[3];
int[] sumaColumnas = new int[3];

// Leer los datos del arreglo
Console.WriteLine("Digite los datos del arreglo: ");
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        notas[i, j] = Convert.ToInt32(Console.ReadLine());
    }
}

// Sumar las filas y columnas
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        sumaFilas[i] += notas[i, j];    // Sumar la fila
        sumaColumnas[j] += notas[i, j]; // Sumar la columna
    }
}

// Imprimir el arreglo
Console.WriteLine("Imprimiendo el arreglo:");
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        Console.Write(notas[i, j] + " ");
    }
    Console.WriteLine();
}

// Imprimir la suma de las filas
Console.WriteLine("\nSuma de las filas:");
for (int i = 0; i < 3; i++)
{
    Console.WriteLine($"Fila {i + 1}: {sumaFilas[i]}");
}

// Imprimir la suma de las columnas
Console.WriteLine("\nSuma de las columnas:");
for (int j = 0; j < 3; j++)
{
    Console.WriteLine($"Columna {j + 1}: {sumaColumnas[j]}");
}