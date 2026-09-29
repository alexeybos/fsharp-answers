
let factorial n =
    let rec f x a =
        if x <= 1 then a
        else f (x - 1) (a * x)
    f n 1

// 50.2.1
let fac_seq = seq {
    let mutable i = 0
    while true do
        yield factorial i
        i <- i + 1
}

// 50.2.2
let seq_seq = seq {
    let mutable i = 0
    while true do
        yield (if i % 2 = 0 then i/2 else (-1) * (i + 1)/2)
        i <- i + 1
}


