// Learn more about F# at http://fsharp.org

open System

module Tupla =
    //tipos mixtos
    let ejmTupla = ("elemento 1", "el 2", 2, 5.0 )

    //tupla de expresiones
    let tuplaExp = (5+5, "hola "+ "mundo", 8*4)

    //titulo, duracion, instructor, vistas
    let curso = ("F#", 3.2, "Noemi Leon", 5000)
    let titulo, duracion, instructor, vistas = curso
    printfn "El titulo del curso es %s" titulo
    //ignorar elementos con _
    let _, _, inst, vist = curso
    printfn "Instructor %s, vistas %i" inst vist

    //funcion que retorna una tupla
    let divVals x y = 
        let resultado = x/y
        let residuo = x%y
        (resultado, residuo)

    let divResultado, divResiduo = divVals 5 2
    printfn "Resultado = %i, Residuo = %i" divResultado divResiduo