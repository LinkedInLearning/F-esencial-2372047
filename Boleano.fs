namespace Boleano

module Valor =
 let v = true
 let f = false

open Valor
module Operador =
 let opAnd = v && f
 let opOr = v || f
