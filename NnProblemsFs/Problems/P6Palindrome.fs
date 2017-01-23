module P6Palindrome

// ---
// Helpers

let init (list : 'a list) = List.take (list.Length-1) list

// ---
// Problem solutions

let isPalindromeReverse list =
  match list with
  | [] -> true
  | [x] -> true
  | _ ->
    let halfLength = list.Length / 2
    let firstHalf = List.take halfLength list
    // Avoid middle element, if odd length
    let secondHalf =
      let secondPart = List.skip halfLength list
      if secondPart.Length = halfLength
        then secondPart
      else
        List.skip 1 secondPart
    // Match if halves mirror
    firstHalf = List.rev secondHalf

let rec isPalindromeRec list =
  match list with
  | [] -> true
  | [x] -> true
  | _ ->
    // First = last element of list?
    match list.Head = List.last list with
    | true ->
      // Shrink list
      let butFirstLast = init list.Tail
      isPalindromeRec butFirstLast
    | false -> false

let isPalindrome = isPalindromeRec
