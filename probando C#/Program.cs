using System;

//Definir una variable numerica, asignarle un valor y sumarle 5.
int numero = 7; //creo una variable y le asigno n valor.

Console.WriteLine($"el numero asignado es: {numero} y si le sumo 5 seria:  {numero + 5}");


//Definir dos variables de cadena y asignarles un valor y concatenarlas.
string primerPalabra = "hola";
string segundaPalabra = "¿como estas?";

Console.WriteLine($"la primer palabra es: {primerPalabra}");
Console.WriteLine($"la segunda palabra es: {segundaPalabra}");
Console.WriteLine($"Si concatenamos la primera y segunda palabra seria: {primerPalabra + " " + segundaPalabra}");

/*
Definir una variable numérica. Asignarle un valor entre 1 y 10.
Mostrar a que grupo pertenece:
    - grupo 1 del 1 al 3.
    - grupo 1 del 4 al 6.
    - grupo 1 del 7 al 10.
*/

var segundoNumero = 10;
//evaluar si dos numeros son iguales
if(numero == segundoNumero){
    Console.WriteLine($"son los mismos numeros {numero}");
}else{

}

switch(numero){
    case int var when(numero > 1 && numero <=3):
    Console.WriteLine($"el numero: {numero}pertenece al primer grupo de 1 a 3");
    break;
    case int var when(numero > 3 && numero <= 6):
    Console.WriteLine($"el numero: {numero} pertenece al segundo grupo de 3 a 6");
    break;
    default:
    Console.WriteLine($"el numero: {numero} pertenece al tercer grupo de 7 a 10");
    break;
}

int contador = 0, acumulador = 0;
while(contador <= 10){
    acumulador = acumulador + contador;
    contador++;
}
Console.WriteLine(acumulador);


/*Generar un array con 10 números, recorrerlo e ir multiplicando 
todos los elementos, finalmente obtener el producto total.*/

int[] miLista = new int[5]{1,2,3,4,5};




          
