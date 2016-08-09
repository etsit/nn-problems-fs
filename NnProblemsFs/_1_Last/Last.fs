module Last

let private errorMsg = "Empty list does not have a last element"

let rec last_Rec lst =
    match lst with
    | [a]   -> a
    | b::bs -> last_Rec bs
    | []    -> failwith errorMsg

let last_Index (lst : 'a list) =
    if lst.IsEmpty
    then failwith errorMsg
    else List.item (lst.Length-1) lst

let last_Reverse (lst : 'a list) =
    if lst.IsEmpty
    then failwith errorMsg
    else (List.rev lst).Head

// Choosing 'last' implementation
let last = last_Index
