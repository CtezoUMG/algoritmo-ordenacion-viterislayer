using System;

const int CANTIDAD_ELEMENTOS = 10000;
Algoritmo ordenador = new Algoritmo();

// 1. Generar datos (Semilla 42 para que todos tengan el mismo desorden)
int[] datos = ordenador.GenerarNumeros(CANTIDAD_ELEMENTOS);

Console.WriteLine($"--- Auditoría de Algoritmos .NET 10 ---");
Console.WriteLine($"Procesando: {CANTIDAD_ELEMENTOS:N0} números.");

// 2. El alumno implementa esto en la clase Algoritmo


// 2. El alumno implementa esto en la clase Algoritmo
public void BubbleSort(int[] datos)
{
    // Implementación del ordenamiento por selección
    int n = datos.Length;
    
    // Recorrer todo el array
    for (int i = 0; i < n - 1; i++)
    {
        // Encontrar el elemento mínimo en el array no ordenado
        int indiceMinimo = i;
        for (int j = i + 1; j < n; j++)
        {
            if (datos[j] < datos[indiceMinimo])
            {
                indiceMinimo = j;
            }
        }
        
        // Intercambiar el elemento mínimo encontrado con el primer elemento
        if (indiceMinimo != i)
        {
            int temp = datos[i];
            datos[i] = datos[indiceMinimo];
            datos[indiceMinimo] = temp;
        }
    }
}
