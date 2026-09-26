// 43.3
let try_find key m = 
 let rec find_in_list = function
  | [] -> None
  | (head_key, value) :: tail when head_key = key -> Some (value)
  | head :: tail -> find_in_list tail
 find_in_list (Map.toList m)


