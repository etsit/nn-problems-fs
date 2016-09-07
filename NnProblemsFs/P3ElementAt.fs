module P3ElementAt

let private errorMsg = "Element not found"

let rec elementAtRec (lst : 'a list) index =
    match lst with
    | _ when index <= 0      -> failwith errorMsg
    | []                     -> failwith errorMsg
    | (x::xs) when index = 1 -> x
    | (x::xs)                -> elementAtRec xs (index-1)

let elementAtItem (lst : 'a list) index = lst.[index-1]

// Choosing impl
let elementAt = elementAtRec