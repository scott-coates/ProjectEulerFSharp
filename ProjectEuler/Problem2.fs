module Problem2

open System

let ReturnIfEven x =
    if x % 2 = 0 then 
        x
    else
        0

let max = 4000000
let rec Fibonacci x y =
    if y <= max then
        let plus = x+y
        (ReturnIfEven plus) + Fibonacci y plus 
     else
        0      

let t = (Fibonacci 1 2) + 2
Console.Write(t)

ignore(Console.Read())