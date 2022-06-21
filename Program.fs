open System

[<EntryPoint>]
let main argv =
    (* BOOL *)
    let v = true
    let f = false
    //operadores
    let opAnd = v && f 
    let opOr = v || f

    (* NUM *)
    let entero = 1500
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
