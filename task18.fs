// 47.4.1
let f n = 
 let mutable mul = 1
 List.iter (fun x -> mul <- mul * x) [1..n]
 mul

// 47.4.2
let fibo n = 
 if n = 0 then 0
 else
  let x1 = ref 0
  let x2 = ref 1
  let x = ref 1
  let i = ref 0
  while ! i < n - 1 do
    x := ! x2
    x2 := ! x1 + ! x2
    x1 := ! x
    i := ! i + 1
  ! x2


