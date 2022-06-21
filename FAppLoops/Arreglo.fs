module Arreglo

let coordA = [| -0.5; 20.5; -40.0 |]

let coordB = 
    [|
        5.5
        -12.1
        49.9
    |]

let productos = [| "a"; "b"; "c" |]
let el = productos[0]

let pares = Array.init 10 (fun i -> i * 2)
//printfn "%A" pares

let vacioArr = Array.empty

//manejo de arreglos
let coordAB = Array.concat [ coordA; coordB ]

let cuadrados = [| for i in 1 .. 5 -> i*i|]
//printfn "%A" cuadrados

//printfn "%A" (Array.filter(fun el -> el % 2 = 0) cuadrados)

let rango = productos[0..2]
let reversaProd = Array.rev productos
let prodB = Array.append productos [| "d"; "e" |]
