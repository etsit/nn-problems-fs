module Problems

open P6Palindrome

[<EntryPoint>]
let main argv =
    List.ofArray argv
    |> fun xs ->
      printfn "List: %A" xs
      xs
    |> isPalindrome
    |> printfn "Is palindrome? %A"
    0
