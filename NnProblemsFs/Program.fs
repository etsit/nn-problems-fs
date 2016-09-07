open System
open P1Last.Tests
open P2LastButOne
open P5Reverse
open FsCheck

[<EntryPoint>]
let main argv = 
    runP1Tests()
    Console.ReadLine() |> ignore
    0 // return an integer exit code
