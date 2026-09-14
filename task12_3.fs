[<Fact>]
let ``upto 5 должно быть [1; 2; 3; 4; 5]`` () =
    let actual = upto 5
    Assert.Equal<int list>([1; 2; 3; 4; 5], actual)

[<Fact>]
let ``dnto 5 должно быть [5; 4; 3; 2; 1]`` () =
    let actual = dnto 5
    Assert.Equal<int list>([5; 4; 3; 2; 1], actual)

[<Fact>]
let ``evenn 5 должно быть [0; 2; 4; 6; 8]`` () =
    let actual = evenn 5
    Assert.Equal<int list> ([0; 2; 4; 6; 8], actual)