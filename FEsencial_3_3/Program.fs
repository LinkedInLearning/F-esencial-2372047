(*
let rec funcion param1 param2 =
 cuerpo
 *)


open System 
let rec fact n =
 if n < 1 then 1
 else n * fact (n-1)

let usuarioDato = Console.ReadLine()
let num = usuarioDato |> int
printfn $"El factorial de {num} = {fact num}"

let rec factB = function
 | n when n < 1 -> 1
 | n -> n * fact (n-1)

printfn $"El factorial de {num} = {factB num}"
