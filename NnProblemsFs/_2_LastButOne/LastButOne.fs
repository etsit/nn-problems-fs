module LastButOne
open Last

let rec lastButOne (lst : 'a list) =
    match lst with
    | [x; y] -> x
    | x::xs  -> lastButOne xs
    | []     -> failwith "A list with less than two elements does not have a second to last element"