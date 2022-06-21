open System

(*
fun lista-parametros -> expresion
*)

let mult x y = x * y
let multB = fun x y -> x * y

let pares = Array.init 10 (fun i -> i*2)

let miLista = [ -2.8; 3.5; -5.0]
let miListaInv = List.map (fun v -> -(v)) miLista
