[<Fact>]
let ``5 является делителем 10`` () =
    let actual = notDivisible (5, 10)
    Assert.True(actual)

[<Fact>]
let ``5 не является делителем 9`` () =
    let actual = notDivisible (5, 9)
    Assert.False(actual)

[<Fact>]
let ``11 простое число`` () =
    let actual = prime 11
    Assert.True(actual)

[<Fact>]
let ``12 не простое число`` () =
    let actual = prime 12
    Assert.False(actual)

[<Fact>]
let ``1 не простое число`` () =
    let actual = prime 1
    Assert.False(actual)

[<Fact>]
let ``2 простое число`` () =
    let actual = prime 2
    Assert.True(actual)