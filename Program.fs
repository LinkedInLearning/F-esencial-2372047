// Learn more about F# at http://fsharp.org

open System
let imprimeDespedida() =
    let num = 1
    let msj = "Vuelve pronto"
    printfn "%s" msj

let restar x =
    let total =  x - 10
    total

let suma x y = x + y + 10
    
[<EntryPoint>]
let main argv=
    let saludo = "Hola mundo F#!"
    imprimeDespedida
//    let miTotal = suma 10 20 //no mutable
    let mutable miTotal = suma 10 20
    printfn "%i" miTotal
    miTotal = 50
    printfn "%i" miTotal
    0
