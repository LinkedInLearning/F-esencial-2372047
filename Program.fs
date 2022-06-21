// Learn more about F# at http://fsharp.org

open System
let imprimeDespedida() =
    let num = 1
    let msj = "Vuelve pronto"
    printfn "%s" msj

let restar x =
    let total =  x - 10
    total

//otra forma de definir funciones
let s x y = x + y + 10

//anotaciones de tipo
let sum (x: uint32) (y: uint32) = x + y + 10u

//anotaciones de tipo para valor de retorno
let suma x y : uint32 = x + y + 100u
    
[<EntryPoint>]
let main argv=
    let saludo = "Hola mundo F#!"
    imprimeDespedida
    let num = 5
    //anotacion de tipo
    //let num : float = 5.0
    let numero = 5 + 5
    printfn "%s" saludo
    0
