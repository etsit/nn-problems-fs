module P4ElementCount

let rec elementCountHeadR (lst : 'a list) =
    match lst with
    | x::xs -> 1 + elementCountHeadR xs
    | []    -> 0

let elementCountTailR (lst : 'a list) =
    let rec tailR lst' count =
        match lst' with
        | x::xs -> tailR xs count + 1 
        | []    -> count
    tailR lst 0

let elementCount = elementCountTailR

