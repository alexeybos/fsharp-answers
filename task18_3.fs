[<Fact>]
let ``10-е число Фибоначчи должно быть 55 (императивная реализация)`` () =
    let actual = fibo 10
    Assert.Equal(55, actual)

[<Fact>]
let ``0-е число Фибоначчи должно быть 0`` () =
    let actual = fibo 0
    Assert.Equal(0, actual)

[<Fact>]
let ``1-е число Фибоначчи должно быть 1`` () =
    let actual = fibo 1
    Assert.Equal(1, actual)

[<Fact>]
let ``факториал 0 должно быть 1`` () =
    let actual = f 0
    Assert.Equal(1, actual)

[<Fact>]
let ``факториал 1 должно быть 1`` () =
    let actual = f 1
    Assert.Equal(1, actual)

[<Fact>]
let ``факториал 5 должно быть 120`` () =
    let actual = f 5
    Assert.Equal(120, actual)