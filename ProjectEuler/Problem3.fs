module Problem3
open System

let primesUnder (max:int64) = 
    let mutable largest = 0L
    let isFactorOfMax (n:int64) =
        max % n = 0L
    for n in List.filter isFactorOfMax [1L .. max] do
        let factorialsOfN = 
            [   
                for i in 1L .. n do
                    if n % i = 0L then
                        yield i
                    else
                        ignore() 
            ]

        if (List.length factorialsOfN) = 2 then
            if n > largest then
                largest <- n
        else
//                List.length factorialsOfN |> printfn "Length: %d"
            ignore()

    largest

let  x = primesUnder 600851475143L
Console.Write(x)
ignore(Console.Read())