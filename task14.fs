// 40.1
let rec sum (p, xs) = 
  let rec compute = function
   | [] -> 0
   | head :: tail when p head -> head + compute tail
   | head :: tail -> compute tail
  compute xs
  
// 40.2.1
let rec count (xs, n) = 
 match xs with
  | [] -> 0
  | head :: tail when head > n -> 0
  | head :: tail when head = n -> 1 + count(tail, n)
  | head :: tail -> count(tail, n)
  
// 40.2.2
let rec insert (xs, n) = 
 let rec spl = function
  | (h, []) -> h @ [n]
  | (h, [x]) when x >= n -> h @ [n] @ [x]
  | (h, [x]) when x < n -> h @ [x] @ [n]
  | (h, head :: (head2 :: _ as tail)) when head <= n && head2 >= n -> h @ [head] @ [n] @ tail
  | (h, head :: tail) -> spl (h @ [head], tail)
 spl ([], xs)

// 40.2.3
let rec intersect (xs1, xs2) = 
 let rec slide = function
  | ([], _, r) | (_, [], r) -> List.rev r
  | (head1 :: tail1,head2 :: tail2,r) when head1 = head2 -> slide (tail1, tail2, head1 :: r)
  | (head1 :: tail1,head2 :: tail2,r) when head1 < head2 -> slide (tail1, head2 :: tail2, r)
  | (head1 :: tail1,head2 :: tail2,r) when head1 > head2 -> slide (head1 :: tail1, tail2, r)
 slide (xs1, xs2, [])

// 40.2.4
let rec plus (xs1, xs2) = 
 let rec slide = function
  | ([], [], r) -> List.rev r
  | ([], l, r) | (l, [], r) -> List.rev r @ l
  | (head1 :: tail1,head2 :: tail2,r) when head1 <= head2 -> slide (tail1, head2 :: tail2, head1 :: r)
  | (head1 :: tail1,head2 :: tail2,r) when head1 > head2 -> slide (head1 :: tail1, tail2, head2 :: r)
 slide (xs1, xs2, [])

// 40.2.5
let rec minus (xs1, xs2) = 
 let rec slide = function
  | ([], _, r) -> List.rev r
  | (l, [], r) -> List.rev r @ l
  | (head1 :: tail1,head2 :: tail2,r) when head1 = head2 -> slide (tail1, tail2, r)
  | (head1 :: tail1,head2 :: tail2,r) when head1 < head2 -> slide (tail1, head2 :: tail2, head1 :: r)
  | (head1 :: tail1,head2 :: tail2,r) when head1 > head2 -> slide (head1 :: tail1, tail2, r)
 slide (xs1, xs2, [])

// 40.3.1
let rec smallest xs = 
 let rec min = function
  | ([], m) -> m
  | (head :: tail, m) when head < m -> min (tail, head)
  | (head :: tail, m) -> min (tail, m)
 match xs with
   | [] -> None
   | [head] -> Some(head)
   | head :: tail -> Some(min (tail, head))

// 40.3.2
let rec delete (n, xs) = 
 let rec slide = function
  | ([], r) -> r
  | ([head], r) when head = n -> r
  | ([head], r) -> List.rev (head :: r)
  | (head :: tail, r) when head = n -> List.rev (r) @ tail
  | (head :: tail, r) -> slide (tail, head :: r)
 slide (xs, [])
 
// 40.3.3
let rec sort xs = 
 let apply_min m l r = (delete (m, l), m :: r)
 let rec proc = function
  | ([], r) -> List.rev r
  | ([head], r) -> List.rev (head :: r)
  | (l, r) -> proc (apply_min (Option.get (smallest l)) l r)
 proc (apply_min (Option.get (smallest xs)) xs [])
 
// 40.4
let rec revrev xs =  
 let rec rev_inner = function
  | head :: tail -> (rev_inner tail) @ [head]
  | [] -> []
 match xs with
  | head :: tail -> (revrev tail) @ [rev_inner head]
  | [] -> []
 

