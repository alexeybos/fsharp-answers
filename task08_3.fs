[<Fact>]
let ``carry для add должно быть 12`` () =
    let add (x, y) = x + y
    let actual = curry add 10 2
    Assert.Equal(12, actual)

[<Fact>]
let ``uncarry для add должно быть 12`` () =
    let add x y = x + y
    let actual = uncurry add (10, 2)
    Assert.Equal(12, actual)