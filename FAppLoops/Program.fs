open Arreglo

(* for-in *)
for prod in productos do
   printfn $"Producto {prod}"

let cuadradosReversa =
    [| for i in 10 .. -1 .. 1 -> i * i |]

(* for-to *)
for i = 1 to 10 do
   printfn $"{i}"

(* while-do *)
let min = 10
let mutable i = 0
while (cuadrados[i] < min) do
   printfn $"{cuadrados[i]} < {min}"
   i <- i+1