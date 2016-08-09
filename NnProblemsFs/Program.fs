open System
open Last
open LastButOne
open Reverse

[<EntryPoint>]
let main argv = 
    printfn "%A" <| reverse_Rec2 []
    Console.ReadLine() |> ignore
    0 // return an integer exit code
