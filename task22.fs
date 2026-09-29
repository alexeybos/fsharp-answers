
type 'a cell = Nil | Cons of 'a * Lazy<'a cell>
 
let hd (s : 'a cell) : 'a =
  match s with
    Nil -> failwith "hd"
  | Cons (x, _) -> x
 
let tl (s : 'a cell) : Lazy<'a cell> =
  match s with
    Nil -> failwith "tl"
  | Cons (_, g) -> g
 
 
// 51.3
let rec nth (s : 'a cell) (n : int) : 'a =
 let rec inner (head : 'a) (tail : Lazy<'a cell>) i = 
  match (head, tail.Value, i) with
  | (h, _, i) when i = n -> h
  | (_, t, i) -> inner (hd t) (tl t) (i+1)
 inner (hd s) (tl s) 0


