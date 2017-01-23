module Problems

open P6Palindrome
open System

[<EntryPoint>]
let main argv =
    List.ofArray argv
    |> fun xs ->
      printfn "List: %A" xs
      xs
    |> isPalindrome
    |> printfn "Is palindrome? %A"
    Console.ReadLine() |> ignore
    0
