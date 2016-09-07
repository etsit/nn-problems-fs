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


// =====
module Tests =
    
    open FsCheck
    open System

    // -- Trying FsCheck: Tests of non-empty lists

    // Not working, runtime error due to generic types
    let runTest gen test =
        gen
        |> Arb.fromGen
        |> Prop.forAll <| test

    // Working version, but defeats purpose of passing any generator and test
    let runTestNonGeneric (gen: Gen<int list>) (test: int list -> bool) =
        gen
        |> Arb.fromGen
        |> Prop.forAll <| test

    let ``List is non-empty`` =
        let gen = Gen.nonEmptyListOf Arb.from<int>.Generator
        let test (lst: int list) = (not << List.isEmpty) lst
        runTest (gen: Gen<int list>) (test: int list -> bool)

//    let ``List is non-empty`` =
//        Gen.nonEmptyListOf Arb.from<int>.Generator
//        |> Arb.fromGen
//        |> Prop.forAll <| (not << List.isEmpty)

//    let ``list contains last element`` =
//        let gen = gen {
//            let! nonEmptyList = Gen.nonEmptyListOf Arb.from<int>.Generator 
//            let! positiveInt = Arb.from<int>.Generator |> Gen.filter ((<) 0)
//            return nonEmptyList, positiveInt
//        }
//        let test (lst: int list, elem: int) = List.contains elem lst
//        runTest gen test

//    let runTest2 arg1 arg2 test =
//        runTest (Gen.map2 (fun a b -> a,b) arg1 arg2) test
//    let ``list contains last element`` =
//        let nonEmptyList = Gen.nonEmptyListOf Arb.from<int>.Generator 
//        let positiveInt = Arb.from<int>.Generator |> Gen.filter ((<) 0)
//        let test (lst: int list, elem: int) = List.contains elem lst
//        runTest2 nonEmptyList positiveInt test

//    // Disambiguate
//    type IntType = int
//    let listArb : Arbitrary<int list> = Arb.Default.FsList() |> Arb.filter (fun xs -> not << List.isEmpty <| xs)
//    let listArb = {new Arbitrary<int>() with
//        override this.Generator =
//            Gen.choose(0, IntType.MaxValue) }

    // Used to access parent class generated from this module.
    // That "module class" is passed to FsCheck for exposing all
    // test artifacts of this module, see
    // https://fscheck.github.io/FsCheck/RunningTests.html
    type Marker = class end
    let runP1Tests() =
        Arb.registerByType typeof<Marker>.DeclaringType |> ignore
        Check.VerboseAll typeof<Marker>.DeclaringType
