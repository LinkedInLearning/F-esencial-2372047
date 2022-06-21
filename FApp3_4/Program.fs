open Lista
open System

let cantidadCds = ciudades.Length

let esVaciaCds = ciudades.IsEmpty

printfn "Ingresa una ciudad"

let cd = Console.ReadLine()

let existeCd cd cds = List.exists (fun el -> el = cd) cds
let existe = existeCd cd ciudades
printfn $"{existe}"


let cdsOrd = List.sort(ciudades)
printfn "%A" ciudades
printfn "%A" cdsOrd

let itemsOrd = List.sortBy(fun el -> abs el) items
printfn "%A" itemsOrd