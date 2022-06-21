open System
open Boleano.Operador
[<EntryPoint>]
let main argv =
    (* NUM *)
    let entero = 1500
    let d = decimal entero
    Console.WriteLine("d = {0} en decimal", d)

    let b = byte entero
    Console.WriteLine("b = {0} en byte", b)

    let c = char entero
    Console.WriteLine("c = {0} en char", c)

    printfn "El valor de opOr = %b" opOr
    let mibyte = 1uy
    let midecimal = 5.5m
    let milista = [ 0 .. 10 ]
    //operadores
    let multi = entero * 5

    (* CADENA *)
    let saludo = "Hola mundo F#"
    let ruta = @"C:\Noemi\Cursos" //cadena literal, ignora caracteres de escape
    let letra = 'N'
    //operadores
    let concat = saludo + " " +  " .."
    let subcad = concat.[0..9] //notacion de indexador para subcadenas
    printfn "%s" subcad
    0 // return an integer exit code
