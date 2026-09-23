// 42.3
let rec allSubsets n k = 
 let rec with_list = function
  | (_, 0) -> set [ set []]
  | ([], _) -> set []
  | (head :: tail, i) -> 
             let from_head = Set.map (fun link -> Set.add head link) (with_list (tail, i - 1))
             let no_head = with_list (tail, i)
             Set.union from_head no_head
 with_list ([1 .. n], k)


