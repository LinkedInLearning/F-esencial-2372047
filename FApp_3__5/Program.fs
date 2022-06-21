//Union
type TipoCurso =
 | Generico
 | Idioma of guion: string * audio: bool
 | Programacion of guion: string * repositorio: string


//Record
type Curso = {
 Titulo: string
 Duracion: float
 Instructor: string
 Vistas: int
 Tipo: TipoCurso
}

let cursoA = {
 Titulo = "F#"
 Duracion = 3.2
 Instructor = "Noemi L"
 Vistas = 5000
 Tipo = Generico
}

let guion = "https://archivosCurso/guion"
let repo = "https://github.com/noeleo25/curso-ml-net"

let cursoB = {
 Titulo = "ML con .NET"
 Duracion = 5.5
 Instructor = "Noemi L"
 Vistas = 8000
 Tipo = Programacion(guion = guion, repositorio = repo)
}