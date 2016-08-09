module Reverse

let rec reverse_Rec1 (lst : 'a list) =
    match lst with
    | x::xs -> reverse_Rec1 xs @ [x]
    | _     -> lst

let rec reverse_Rec2 (lst : 'a list) =
    let rec helper origLst revLst =
        match (origLst, revLst) with
        | x::xs, ys -> helper xs (x::ys)
        | [], ys    -> ys
    helper lst []

let reverse_Fold (lst : 'a list) = List.fold (fun xs x -> x::xs) [] lst

// Choosing impl
let reverse = reverse_Rec2