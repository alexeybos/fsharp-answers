[<Fact>]
let ``try_find should find value (exists in Map)`` () =
   let mapa = Map.ofList [(128,"oksana"); (32,"oleg"); (5, "bingo")]
   let actual = try_find 5 mapa
   Assert.Equal("bingo", Option.get(actual))

[<Fact>]
let ``try_find should not find value (not exists in Map)`` () =
   let mapa = Map.ofList [(128,"oksana"); (32,"oleg"); (5, "bingo")]
   let actual = try_find 55 mapa
   Assert.Equal(None, actual)


