type IRepositorioExterno =
 abstract member Conectar : string -> string -> string

type ConexionGithub() =
 interface IRepositorioExterno with
  member this.Conectar usuario repositorio =
   $"Conexión a repositorio {repositorio} establecida. {usuario}"

let rutaRepo = "https://github.com/noeleo25/"
let usuario = "noeleo25"
let conexGithub = new ConexionGithub()
let iconexGithub = conexGithub :> IRepositorioExterno
let c = iconexGithub.Conectar usuario rutaRepo
printfn $"Mensaje github {c}"