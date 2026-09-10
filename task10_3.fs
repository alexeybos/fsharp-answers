[<Fact>]
let ``10:36 PM .>. 10:36 AM должно быть true`` () =
    let fdate = { hours = 10; minutes = 36; f = "PM" }
    let sdate = { hours = 10; minutes = 36; f = "AM" }
    let actual = fdate .>. sdate
    Assert.True(actual)

[<Fact>]
let ``10:36 AM .>. 10:36 PM должно быть false`` () =
    let fdate = { hours = 10; minutes = 36; f = "PM" }
    let sdate = { hours = 10; minutes = 36; f = "AM" }
    let actual = sdate .>. fdate
    Assert.False(actual)

[<Fact>]
let ``10:36 AM .>. 10:36 AM должно быть false`` () =
    let fdate = { hours = 10; minutes = 36; f = "AM" }
    let sdate = { hours = 10; minutes = 36; f = "AM" }
    let actual = sdate .>. fdate
    Assert.False(actual)

[<Fact>]
let ``10:37 AM .>. 10:36 AM должно быть true`` () =
    let fdate = { hours = 10; minutes = 37; f = "AM" }
    let sdate = { hours = 10; minutes = 36; f = "AM" }
    let actual = fdate .>. sdate
    Assert.True(actual)

[<Fact>]
let ``2:37 AM .>. 10:36 AM должно быть false`` () =
    let fdate = { hours = 2; minutes = 37; f = "AM" }
    let sdate = { hours = 10; minutes = 36; f = "AM" }
    let actual = fdate .>. sdate
    Assert.False(actual)

[<Fact>]
let ``9:20 AM .>. 5:36 AM должно быть true`` () =
    let fdate = { hours = 9; minutes = 20; f = "AM" }
    let sdate = { hours = 5; minutes = 36; f = "AM" }
    let actual = fdate .>. sdate
    Assert.True(actual)
