using System;
using System.Collections.Generic;

public class Calculadora
{
    public List<string> Historial { get; private set; }

    public Calculadora()
    {
        Historial = new List<string>();
    }

    public double Sumar(double a, double b)
    {
        double r = a + b;
        Historial.Add($"{a} + {b} = {r}");
        return r;
    }

    public double Restar(double a, double b)
    {
        double r = a - b;
        Historial.Add($"{a} - {b} = {r}");
        return r;
    }

    public double Multiplicar(double a, double b)
    {
        double r = a * b;
        Historial.Add($"{a} * {b} = {r}");
        return r;
    }

    public double Dividir(double a, double b)
    {
        double r = a / b;
        Historial.Add($"{a} / {b} = {r}");
        return r;
    }
}
