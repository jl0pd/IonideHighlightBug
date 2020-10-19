let ex1 =
    [1 .. 0]
    |> Seq.ofList
    |> ignore

    Seq.ofList [1 .. 0] |> ignore

let ex2 =
    let square x = x * x
    Seq.map
        square
        [1 .. 0]
    |> ignore

    Seq.map square [1 .. 0] |> ignore

let ex3 =
    String.concat
            ""
            [ "" ]
    |> ignore

    String.concat "" [ "" ] |> ignore

    // these 2 breaks all highlightning until you comment them
    // String
    //     .concat ""
    //           [ "" ]
    // |> ignore

    // String.
    //     concat ""
    //           [ "" ]
    // |> ignore

type Point = { X : int; Y : int }

let ex4 =
    let p = { X = 3; Y = 4 }
    // X should be cyan
    p.X |> ignore
    ignore p.X

let ex5 =
    let d = 4.0
    d.ToString() |> ignore
    (4.0).ToString() |> ignore
    4.0 |> string |> ignore
    4.0 |> fun x -> x.ToString() |> ignore


[<EntryPoint>]
let main argv =
    0
