// 23.4.1
let (.+.) x y = 
 let (a,b,c) = x
 let (d,e,f) = y
 let cuprum = c + f
 let silver = b + e + int(cuprum / 12)
 let gold = a + d + int(silver / 20)
 (gold, silver % 20, cuprum % 12)

let (.-.) x y = 
 let (a,b,c) = x
 let (d,e,f) = y
 let cuprum1 = (a * 20 + b) * 12 + c
 let cuprum2 = (d * 20 + e) * 12 + f
 let cuprum = cuprum1 - cuprum2
 let silver = int(cuprum / 12)
 let gold = int(silver / 20)
 (gold, silver % 20, cuprum % 12)
 
// 23.4.2
let (.+) x y = 
 let (a, b) = x
 let (c, d) = y
 a + c, b + d

let (.-) x y = 
 let (c, d) = y
 x .+ (-c,-d)

let (.*) x y = 
 let (a, b) = x
 let (c, d) = y
 a*c - b*d, b*c + a*d

let (./) x y = 
 let (a: float, b: float) = y
 x .* (a/(a**2.0+b**2.0),-b/(a**2.0+b**2.0))


