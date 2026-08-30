[<Fact>]
let ``10-е число Фибоначчи должно быть 55`` () =
    let actual = fibo 10
    Assert.Equal(55, actual)

[<Fact>]
let ``Сумма чисел от 0 до 10 должна быть 55`` () =
    let actual = sum 10
    Assert.Equal(55, actual)

[<Fact>]
let ``Сумма чисел для 2, 2 должна быть 9`` () =
    let actual = sum2 (2, 2)
    Assert.Equal(9, actual)