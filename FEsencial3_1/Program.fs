open System

(* if condicion then
	//bloque 
//else
    //bloque *)

Console.WriteLine("Ingresa tu nombre")
let nombre = System.Console.ReadLine()
let caract = nombre.Length

if caract < 5 then
    printfn "Nombre corto"
else
    printfn "Nombre largo"

let tipoNombre c =
    if c < 5 then "Nombre corto"
    elif c = 5 then "Nombre mediano"
    else "Nombre largo"

printfn $"{nombre} es {tipoNombre caract}"
