(*
match expresion with
| patron [ when condicion] -> expresion-resultado
| patron2 [ when condicion2] -> expresion-resultado
*)
open System
printfn "Elige una opc 1-saludo, 2-despedida"
let menu = Console.ReadLine()
let accion =
 match menu with
  | "1" -> printfn "Hola"
  | "2" -> printfn "Adios"
  | _ -> printfn "Opción inválida"