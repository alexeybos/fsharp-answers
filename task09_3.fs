[<Fact>]
let ``(.+.) для (1,2,3) и (4,5,6) должно быть (5,7,9)`` () =
    let actual = (1,2,3) .+. (4,5,6)
    Assert.Equal((5,7,9), actual)

[<Fact>]
let ``(.+.) для (10,23,38) и (4,5,6) должно быть (15,11,8)`` () =
    let actual = (10,23,38) .+. (4,5,6)
    Assert.Equal((15,11,8), actual)

[<Fact>]
let ``(.-.) для (1,2,3) и (4,5,6) должно быть (-3,-3,-3)`` () =
    let actual = (1,2,3) .-. (4,5,6)
    Assert.Equal((-3,-3,-3), actual)

[<Fact>]
let ``(.-.) для (10,23,38) и (4,5,6) должно быть (7,0,8)`` () =
    let actual = (10,23,38) .-. (4,5,6)
    Assert.Equal((7,0,8), actual)    

[<Fact>]
let ``(.+) для (10,23) и (4,5) должно быть (14,28)`` () =
    let actual = (10,23) .+ (4,5)
    Assert.Equal((14,28), actual)

[<Fact>]
let ``(.-) для (10,23) и (4,5) должно быть (6,18)`` () =
    let actual = (10,23) .- (4,5)
    Assert.Equal((6,18), actual)    

[<Fact>]
let ``(.*) для (10,8) и (4,5) должно быть (0.0,82.0)`` () =
    let actual = (10.0,8.0) .* (4.0,5.0)
    Assert.Equal((0.0,82.0), actual)

[<Fact>]
let ``(./) для (2,3) и (1,2) должно быть (1.6,-0.2)`` () =
    let actual = (2.0,3.0) ./ (1.0,2.0)
    let actual_a, actual_b = actual
    Assert.Equal(1.6, actual_a, 5)
    Assert.Equal(-0.2, actual_b, 5)