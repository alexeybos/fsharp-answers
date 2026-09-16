// 39.1
let rec rmodd = function
 | [] -> []
 | [n] -> []
 | head :: (head2 :: tail) -> head2 :: rmodd tail
 
// 39.2
let rec del_even = function
  | [] -> []
  | head :: tail when head % 2 = 0 -> del_even tail
  | head :: tail -> head ::  del_even tail

// 39.3
let rec multiplicity x xs = 
  let rec iter = function
    | [] -> 0
    | head :: tail when head = x -> 1 + iter tail
    | head :: tail -> iter tail
  iter xs
    
// 39.4
let rec split n = 
 let rec trans = function
  | (e,o,[]) -> (e,o)
  | (e,o,head :: (head2 :: tail)) -> trans (e @ [head], o @ [head2], tail)
  | (e,o,head :: tail) -> (e @ [head],o)
 trans ([],[],n)
 
// 39.5
let rec zip = function
  | ([],[]) -> []
  | ([], head :: tail) | (head :: tail, []) -> failwith "not equal length"
  | (head :: tail, head2 :: tail2) -> (head, head2) :: zip (tail, tail2)


