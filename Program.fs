open System

//Tupla curso
//let curso = ("F#", 3.2, "Noemi Leon", 5000) 

//Definicion Record: When each label is on a separate line, the semicolon is optional.
type Curso =
    {
        Titulo: string
        Duracion: float
        Instructor: string
        Vistas: int
    }

//Record como struct usa atributo [<Struct>]

//Crear Record
let cursoA =
    {
        Titulo = "F#"
        Duracion = 2.5
        Instructor = "Noemi L"
        Vistas = 8000
    }

//Acceder a datos del record
printfn "El curso %s tiene %i Vistas" cursoA.Titulo cursoA.Vistas 

//Modificar dato del record
let nCurso = { cursoA with Vistas = 8001}
printfn "El curso %s tiene %i Vistas" nCurso.Titulo nCurso.Vistas

//Records en otros records
type Pago =
    {
        Id : string
        Fecha : DateTime
        ModoPago : int
        Tajeta : Tarjeta 
    } 
and Tarjeta =
    {
        Banco : int
        Nombre: string
        //record anonimo: permite crear un record sin definir un tipo
        Direccion: {| Ciudad: string; CP: int; Pais: string |}
        //otros datos: numero, etc
    }

//definir Pago con tarjeta
let rec miPago =
    {
        Id = "xxx-1"
        Fecha = DateTime.Now
        ModoPago = 2 
        Tajeta = 
            {
                Banco = 5
                Nombre = "Madison LL"
                Direccion = {| Ciudad="Vancouver"; CP = 557; Pais = "Canadá" |}
            }
    }






