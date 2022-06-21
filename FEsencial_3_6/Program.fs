open System
open System.Text.RegularExpressions

exception MiExcep of string

let verificarCorreo (correo:string) =
 try
  if correo.Length > 5 then
   match correo with
    | c when Regex.Match(c,@".+@example.+").Success ->
     printfn "Correo es de example"
    | c when Regex.Match(c,@".+@microsoft.+").Success ->
     printfn "Correo es de microsoft"
    | c when Regex.Match(c,@".+@.+").Success ->
     printfn "Correo de proveedor no identificado"
    | _ ->
     printfn "Formato de correo incorrecto"
  //else invalidArg $"correo invalido" $"El argumento correo es invalido {correo}"
  else
   //raise (new InvalidOperationException($"El argumento correo es invalido {correo}"))
   raise (MiExcep(correo))
 finally
  
  printfn $"Configurar nuevamente dirección de correo interno"

verificarCorreo "noemi"

//try-with
let divide x y = 
 try
  (x+1) / (y)
 with
  | :? DivideByZeroException as ex ->
   printfn "%s" ex.Message
  | :? AggregateException as ex ->
   printfn "%s" ex.Message
 