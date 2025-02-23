let mutable x = 10

let addOne x = 
    x <- x + 1
    x

let y = addOne x

printfn "%d %d" x y //This will print 11 11