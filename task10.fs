
type TimeOfDay = { hours: int; minutes: int; f: string }

let (.>.) x y = 
 if x.f <> y.f then x.f > y.f
 else x > y
 
 
 