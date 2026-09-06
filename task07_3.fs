[<Fact>]
let ``vat 20 11.0 должно быть 13.2`` () =
    let actual = vat 20 11.0
    Assert.Equal(13.2, actual)

[<Fact>]
let ``unvat для 20 (vat 20 11.0) должно быть 11.0`` () =
    let actual = unvat 20 (vat 20 11.0)
    Assert.Equal(11.0, actual)

[<Fact>]
let ``min для ftst должно быть 22`` () =
    let ftst = fun x -> x - 22
    let actual = min ftst
    Assert.Equal(22, actual)