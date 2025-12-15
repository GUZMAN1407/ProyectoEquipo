using System;
using System.Collections.Generic;

// Clase que representa una calculadora con funcionalidades básicas y registro de operaciones
public class Calculadora
{
    // Propiedad que almacena el historial de operaciones realizadas
    // Es privada para modificación interna pero pública para lectura
    public List<string> Historial { get; private set; }

    // Constructor de la clase: inicializa la calculadora
    public Calculadora()
    {
        // Crea una nueva lista vacía para almacenar el historial de operaciones
        Historial = new List<string>();
    }

    // Método para sumar dos números
    public double Sumar(double a, double b)
    {
        // Realiza la operación matemática de suma
        double r = a + b;

        // Registra la operación en el historial con formato legible
        Historial.Add($"{a} + {b} = {r}");

        // Retorna el resultado de la suma
        return r;
    }

    // Método para restar dos números
    public double Restar(double a, double b)
    {
        // Realiza la operación matemática de resta
        double r = a - b;

        // Registra la operación en el historial con formato legible
        Historial.Add($"{a} - {b} = {r}");

        // Retorna el resultado de la resta
        return r;
    }

    // Método para multiplicar dos números
    public double Multiplicar(double a, double b)
    {
        // Realiza la operación matemática de multiplicación
        double r = a * b;

        // Registra la operación en el historial con formato legible
        Historial.Add($"{a} * {b} = {r}");

        // Retorna el resultado de la multiplicación
        return r;
    }

    // Método para dividir dos números
    public double Dividir(double a, double b)
    {
        // IMPORTANTE: Este método no maneja la división por cero
        // Si b = 0, se lanzará una excepción DivideByZeroException

        // Realiza la operación matemática de división
        double r = a / b;

        // Registra la operación en el historial con formato legible
        Historial.Add($"{a} / {b} = {r}");

        // Retorna el resultado de la división
        return r;
    }
}
