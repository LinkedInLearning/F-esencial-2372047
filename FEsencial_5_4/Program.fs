type Curso(titulo: string, duracion: int, repo: string) =
 
 let mutable duracionT = duracion
 let mutable repositorio = ""
 let mutable vistas = 0

 let crearRepoAPI repo =
  printfn $"Fin {repo}"

 //solo lectura
 member this.Vistas = vistas

 //solo escritura
 member this.Repositorio with set (repo) = repositorio <- repo

 //lectura y escritura
 member val Titulo = titulo
 member this.Duracion
  with get() = duracionT
  and set (durac) = duracionT <- durac

 //métodos
 member this.AgregarVisualizacion() = vistas <- vistas+1
 member _.CrearRepositorio() =
  crearRepoAPI repo
 
let titulo = "F#"
let duracion = 3
let rutaRepo = "https://github.com/noeleo25"
let miCurso = Curso(titulo, duracion, rutaRepo)

type CursoGrabado(titulo, duracion, repo) =
 inherit Curso(titulo, duracion, repo)
 member this.Repositorio = repo
 member this.Software = "bandicam"

let miCursoGrabado = new CursoGrabado("mi curso grabado", 8, rutaRepo)
printfn $"mi curso grabado {miCursoGrabado.Titulo}, software {miCursoGrabado.Software}"


[<AbstractClass>]
type ACurso() =
 abstract member Agendar : unit -> unit

 abstract member Vistas : int
 abstract member Titulo : string

type ACursoEnVivo(titulo: string) =
 inherit ACurso()
 let mutable vistas = 0
 override this.Titulo = titulo
 override this.Vistas = vistas
 override this.Agendar() =
  printfn $"Agendar en plataforma en vivo"





