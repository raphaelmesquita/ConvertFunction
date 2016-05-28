// Learn more about F# at http://fsharp.org
// See the 'F# Tutorial' project for more help.
type A = 
    { a : string }
    static member convert x = 1

type B = 
    { b : string }
    static member convert x = 1.

let inline convert (x : ^T) : ^U = (^T : (static member convert : ^T -> ^U) (x))

[<EntryPoint>]
let main argv = 
    let oi = convert { b = "a" }
    printfn "%A" argv
    0 // return an integer exit code
