
using Ejersicios;

Automovil auto = new Automovil(12345, "Toyota", "Supra", 120, 698000);
Automovil auto1 = new Automovil(32275, "Nissan", "Supra", 42000, 62300);
Automovil auto2 = new Automovil(21345, "Wolswaguen", "Supra", 14100,40000);
Automovil auto3 = new Automovil(42445, "Chevy", "Supra", 42000, 11000);
Automovil auto4 = new Automovil(62345, "Kia", "Supra", 1000, 111000);

Concesionaria concesionaria = new Concesionaria(5);
concesionaria.AgregarAutomovil(auto);
concesionaria.AgregarAutomovil(auto1);
concesionaria.AgregarAutomovil(auto2);
concesionaria.AgregarAutomovil(auto3);
concesionaria.MostrarAutos();
Console.WriteLine("----------------------------------------------------");
concesionaria.EliminarAuto(auto1);
concesionaria.MostrarAutos();
Console.WriteLine("----------------------------------------------------");
concesionaria.VaciarConcesionara();
concesionaria.MostrarAutos();


