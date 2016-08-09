module ElementCount

let rec elementCount (lst : 'a list) =
    match lst with
    | x::xs -> 1 + elementCount xs
    | []    -> 0

