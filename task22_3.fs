[<Fact>]
let ``проверка nth для последовательности`` () =
    let actual = Task22.nth n0 30000
    Assert.Equal(30000, actual)
