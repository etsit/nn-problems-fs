module P1Last

let private errorMsg = "Empty list does not have a last element"

let rec lastRec lst =
    match lst with
    | [a]   -> a
    | b::bs -> lastRec bs
    | []    -> failwith errorMsg

let lastIndex (lst : 'a list) =
    if lst.IsEmpty
    then failwith errorMsg
    else lst.[lst.Length-1]

let lastReverse (lst : 'a list) =
    if lst.IsEmpty
    then failwith errorMsg
    else (List.rev lst).Head

// Choosing 'last' implementation
let last = lastIndex

