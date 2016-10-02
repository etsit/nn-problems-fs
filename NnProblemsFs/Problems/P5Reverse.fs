module P5Reverse

let rec reverseRec1 (lst : 'a list) =
    match lst with
    | x::xs -> reverseRec1 xs @ [x]
    | []    -> []

let reverseRec2 (lst : 'a list) =
    let rec helper origLst revLst =
        match (origLst, revLst) with
        | x::xs, ys -> helper xs (x::ys)
        | [], ys    -> ys
    helper lst []

let reverseFold (lst : 'a list) = List.fold (fun xs x -> x::xs) [] lst

// Choosing impl
let reverse = reverseRec1