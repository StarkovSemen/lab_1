open System
(*
let create count =
    let rec readList n list2 =
        if n <= 0 then 
            list2
        else
            printf "Введите элемент: "
            let a = int (Console.ReadLine())
            readList (n - 1) (a :: list2)

    let list = readList count []
    list

[<EntryPoint>]
let main argv =
    printf "Сколько элементов вы хотите ввести? "
    let count = int (Console.ReadLine())

    let list = create count

    printfn "Перевернутый список: %A" list

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