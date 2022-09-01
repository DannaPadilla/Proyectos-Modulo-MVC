// See https://aka.ms/new-console-template for more information
using ActInterfaces.Accesorios;
using ActInterfaces.Outfits;

Console.WriteLine("Hello, World!");

//Crear Accesorios

IAccesorios accesorio = new Aretes();
 

Outfit outfit = new Outfit(accesorio);