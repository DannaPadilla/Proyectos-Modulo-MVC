// See https://aka.ms/new-console-template for more information
using Actividad6.Entities;
using Actividad6.Stores;

Console.WriteLine("Hello, World!");
IStore<Product> store = new Store<Product>();
store.Register(new Product());
