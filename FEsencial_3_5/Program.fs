open System
open System.Text.RegularExpressions

//failwith
//invalidArg
//nullArg
//invalidOp

//patron de variable
let verificarCorreo (correo:string) =
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
  raise (new InvalidOperationException($"El argumento correo es invalido {correo}"))

verificarCorreo "noemi"