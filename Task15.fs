// 41.4.1
let list_filter f xs = List.foldBack (fun head tail -> if f head then head::tail else tail) xs []

// 41.4.2
let sum (p, xs) = List.fold (fun x y -> if p x && p y then x + y elif p x then x elif p y then y else 0) 0 xs

// 41.4.3
let revrev x = List.fold (fun head tail -> List.fold (fun head tail -> tail::head) [] tail::head) [] x


