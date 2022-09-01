// See https://aka.ms/new-console-template for more informatiou
using ActividadPatronesDeDiseño.Stores;

Principal Principal = new Secundaria();

var GamaAlta= Principal.BuildCalzadoGamaAlta(1, true);

var GamaBaja = Principal.BuildCalzadoGamaBaja(2);

Console.WriteLine(GamaAlta.ToString(), GamaBaja);








