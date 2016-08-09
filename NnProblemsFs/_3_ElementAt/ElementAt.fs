module ElementAt

let private errorMsg = "Element not found"

let rec elementAt_Rec (lst : 'a list) index =
    match lst with
    | _ when index <= 0      -> failwith errorMsg
    | []                     -> failwith errorMsg
    | (x::xs) when index = 1 -> x
    | (x::xs)                -> elementAt_Rec xs (index-1)

let elementAt_Item (lst : 'a list) index = List.item (index-1) lst

// Choosing impl
let elementAt = elementAt_Rec