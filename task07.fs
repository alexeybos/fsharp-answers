module Task07

// 20.3.1
let vat n x = (x + x * float(n) / 100.0)

// 20.3.2
let unvat n x = x / (1.0 + float(n) / 100.0) 

let rec search_min = function
 | (f,n) when f(n) = 0 -> n
 | (f,n) -> search_min(f,n+1)

// 20.3.3
let rec min f = search_min (f,1)