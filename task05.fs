// 16.1
let notDivisible (n,m) = m % n = 0

let rec search_factors = function
 | (n,m) when n >= m -> true
 | (n,m) when m % n = 0 -> false
 | (n,m) -> search_factors (n+2,m)

// 16.2
let  prime n = 
 match n with
 | n when n <= 1 -> false
 | n when n = 2 -> true
 | n when n % 2 = 0 -> false
 | n -> search_factors (3,n)


