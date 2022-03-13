
using System;
using Tarea2;

Console.Clear();
System.Console.WriteLine(@"Ejercicios:
1.-Ejercicio 1
2.-Ejercicio 2");
switch (Console.ReadLine())
{
    case "1":
        ControlPeliculas control1 = new ControlPeliculas();
        control1.inicializarValores();
        control1.mostrarMenuPprincipal();
        break;
    case "2":
        ControlProductos control2 = new ControlProductos();
        control2.inicializarValores();
        control2.mostrarMenuPprincipal();
        break;
    default:
        break;
}
