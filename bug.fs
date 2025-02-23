let mutable x = 10

let addOne x = x + 1

let y = addOne x

printfn "%d %d" x y //This will print 10 11, not 11 11 as some might expect