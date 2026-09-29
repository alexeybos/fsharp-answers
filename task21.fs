
let factorial n =
    let rec f x a =
        if x <= 1 then a
        else f (x - 1) (a * x)
    f n 1

// 50.2.1
let fac_seq n = seq {
    for i in 0..n do
        yield factorial i
}

// 50.2.2
let seq_seq n = seq {
    for i in 0..n do
        yield (if i % 2 = 0 then i/2 else (-1) * (i + 1)/2)
}


