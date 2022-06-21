(*
match expresion with
| patron [ when condicion] -> expresion-resultado
| patron2 [ when condicion2] -> expresion-resultado
*)

open System
open System.Text.RegularExpressions

printfn "Elige una opc 1-saludo, 2-despedida"
let menu = Console.ReadLine()
let accion =
 match menu with
  | "1" -> printfn "Hola"
  | "2" -> printfn "Adios"
  | _ -> printfn "Opción inválida"

//patron or
let coord = (5, -2)
match coord with
 | (2,x) | (3,x) | (5,x) -> printfn "coincidencia"
 | (_,_) -> printfn "no hay coincidencia"

//patron and
match coord with
 | (5,0) & (_,-2) -> printfn "coincidencia"
 | (_,_) -> printfn "no hay coincidencia"

//patron de variable
let verificarCorreo correo =
 match correo with
  | c when Regex.Match(c,@".+@example.+").Success ->
   printfn "Correo es de example"
  | c when Regex.Match(c,@".+@microsoft.+").Success ->
   printfn "Correo es de microsoft"
  | c when Regex.Match(c,@".+@.+").Success ->
   printfn "Correo de proveedor no identificado"
  | _ ->
   printfn "Formato de correo incorrecto"

verificarCorreo "noemilmicrosoft.com"