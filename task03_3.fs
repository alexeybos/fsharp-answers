module Tests

open Xunit

[<Fact>]
let ``нварь должен содержать 31 день``() =
    let actual = days_in_month 1
    Assert.Equal(31, actual)

[<Fact>]
let ``Февраль должен содержать 28 дней`` () =
    let actual = days_in_month 2
    Assert.Equal(28, actual)

[<Fact>]
let ``Апрель должен содержать 30 дней`` () =
    let actual = days_in_month 4
    Assert.Equal(30, actual)

[<Fact>]
let ``Несуществующий месяц должен возвращать 0`` () =
    let actual = days_in_month 15
    Assert.Equal(0, actual)
