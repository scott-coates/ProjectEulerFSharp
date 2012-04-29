// Learn more about F# at http://fsharp.net

open System
let rec GetMultiples n =
    if n < 1000 then
        let x = if n % 3 = 0 || n % 5 = 0 then n else 0
        x + GetMultiples (n + 1)
    else 0

let x = GetMultiples 1
Console.Write(x)

ignore(Console.Read())