// 49.5.1
let even_seq = Seq.initInfinite (fun i -> i*2)

let factorial n =
    let rec f x a =
        if x <= 1 then a
        else f (x - 1) (a * x)
    f n 1

// 49.5.2
let fac_seq = Seq.initInfinite factorial

let plus_minus = function
 | 0 -> 0
 | n when n % 2 = 0 -> int (n / 2)
 | n -> - (int ((n + 1) / 2))
 
// 49.5.3
let seq_seq = Seq.initInfinite plus_minus


