using System;

class Program {
    static void Main() {
        Console.WriteLine("¡Bienvenido al sistema de evaluación!");
        Console.Write("Ingresa un número entero positivo: ");
        
        int n = Convert.ToInt32(Console.ReadLine());

        // 1. Evaluar si es positivo, negativo o cero
        if (n > 0) {
            Console.WriteLine("El número es: Positivo");
            
            // 2. Usar un ciclo for para la suma acumulada
            int suma = 0;
            for (int i = 1; i <= n; i++) {
                suma += i;
            }
            Console.WriteLine($"La suma acumulada desde 1 hasta {n} es: {suma}");
            
            // 3. Contar cuántos pares hay
            int pares = 0;
            for (int i = 1; i <= n; i++) {
                if (i % 2 == 0) pares++;
            }
            Console.WriteLine($"Cantidad de números pares entre 1 y {n}: {pares}");
            
        } else if (n < 0) {
            Console.WriteLine("El número es: Negativo");
        } else {
            Console.WriteLine("El número es exactamente Cero");
        }
    }
}