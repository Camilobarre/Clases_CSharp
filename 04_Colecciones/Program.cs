﻿﻿using System.Collections;
// -*********************************************************-

Console.WriteLine("ArrayList");

// Crear un ArrayList con elementos iniciales
ArrayList nombres = new() { "Juan", "Ana", "Pedro" };

// Acceder al número de elementos 
Console.WriteLine($"Numero de elementos: {nombres.Count}");

// Acceder a un elemento
Console.WriteLine($"Primer elemento: {nombres[0]}");
Console.WriteLine($"Ultimo elemento: {nombres[nombres.Count - 1]}");
Console.WriteLine($"Ultimo elemento usando ^ (operador índice): {nombres[^1]}");

// Añadir un elemento al final .Add(Object item)
nombres.Add("Luis");
Console.WriteLine($"Nuevo numero de elementos: {nombres.Count}");

// Insertar un elemento en el índice especificado .Insert(Int32 index, Object item)
nombres.Insert(1, "Maria");
Console.WriteLine($"Nuevo numero de elementos: {nombres.Count}");

// Remover un elemento en el índice especificado .RemoveAt(Int32 index)
nombres.RemoveAt(1);
Console.WriteLine($"Nuevo numero de elementos: {nombres.Count}");

// Determinar si un elemento existe .Contains(Object item)
bool anaExiste = nombres.Contains("Ana");
Console.WriteLine($"El elemento 'Ana' existe: {anaExiste}");

// Obtener el índice de un elemento .IndexOf(Object item)
int indicePedro = nombres.IndexOf("Pedro"); // -> -1 si no se encuentra
Console.WriteLine($"El elemento 'Pedro' se encuentra en el índice {indicePedro}");

Console.WriteLine();
Console.WriteLine();
// -*********************-

// -*********************************************************-

// -*********************************************************-

Console.WriteLine("List");

List<string> nombresLista = new() { "Juan", "Ana", "Pedro" };
var juan=nombresLista[0];
var pedro=nombresLista.Find(nombre =>nombre.ToLower().Equals("Pedro"));
Console.WriteLine($"pedro: {pedro}");

List<string> mayusculaNombresLista = nombresLista.Select(nombre => nombre.ToUpper()).ToList();

mayusculaNombresLista.ForEach(nombre => Console.WriteLine(nombre));


Console.WriteLine();
Console.WriteLine();

// -*********************************************************-

// -*********************************************************-

Console.WriteLine("Array");

int[] numeros = { 1, 2, 3, 4, 5 };

var nuevosNumeros = numeros.Append(6);

int[,] array2D = new int[2,4];
for (int i = 0; i < array2D.GetLength(0); i++) {
    var number = array2D[1,0];
    Console.WriteLine($"number: {number}");
}

// -*********************************************************-

Console.WriteLine("#######################");

// -*********************************************************-

// EJERCICIOS

// Calculadora de Promedio de Calificaciones
Console.WriteLine("Ingresa tus calificaciones separas por coma (,):");
var calificacionesSTR = Console.ReadLine();

List<string> listaCalificaciones = calificacionesSTR.Split(',', ' ');

foreach (var calStr in listaCalificaciones)
{
    Console.WriteLine($"calStr: {calStr}");
}