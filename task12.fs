// 34.1
let rec upto n = 
 let rec inter = function
  | (1, lst) -> 1 :: lst
  | (n, lst) -> inter (n-1, n :: lst)
 inter (n, [])
 
// 34.2
let rec dnto n =
 let rec inter = function
  | (n, len, lst) when n=len  -> n :: lst
  | (n, len, lst) -> inter (n+1, len, n :: lst)
 inter (1, n, [])
 
// 34.3
let rec evenn n = 
 let rec inter = function
  | (0, lst) -> 0 :: lst
  | (n, lst) -> inter (n-1, n*2 :: lst)
 inter (n-1, [])
 

