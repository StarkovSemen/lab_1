open System
(*
open System
let create count =
    
    let rec reverseNumber n list1 =
        if n = 0 then list1
        else reverseNumber (n / 10) (list1 * 10 + n % 10)
        
    let rec readList n list1 =
        if n = 0 then
            List.rev list1
        else
            printf "Введите натуральное число: "
            let a = int (Console.ReadLine())
            let reversed = reverseNumber a 0
            readList (n - 1) (reversed :: list1)

    readList count []

[<EntryPoint>]
let main argv =
    printf "Сколько элементов вы хотите ввести? "
    let count = int (Console.ReadLine())
    let list = create count
    printfn "Список с перевернутыми числами: %A" list
    0
   *)
    
(*let rec count n =
    if n = 0 then 
        0
    else
        let digit = n % 10         
        let rest = n / 10          
        
        if digit % 2 = 0 then
            1 + count rest
        else
            count rest

[<EntryPoint>]
let main argv =
    printf "Введите натуральное число: "
    let number = int (Console.ReadLine())

    let result =
        if number = 0 then 1    
        else count number

    printfn "Количество чётных цифр: %d" result
    0
    *)
