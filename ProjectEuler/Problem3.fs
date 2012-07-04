module Problem3
open System

let primesUnder (max:int64) = 
    let isFactorOfMax (n:int64) =
        max % n = 0L
    

    let rec loopThroughNumbers n =
        if isFactorOfMax n then
                n
        else loopThroughNumbers (n - 1L)

    let starting = int64(Math.Floor(Math.Sqrt(float(max))))
//    let starting = int64(Math.Floor( float(max) /  2.0))


    loopThroughNumbers starting

let  x = primesUnder 600851475143L
Console.Write(x)
ignore(Console.Read())