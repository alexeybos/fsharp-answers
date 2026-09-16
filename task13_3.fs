[<Fact>]
let ``rmodd [1 .. 7] должно быть [2; 4; 6]`` () =
    let actual = rmodd [1 .. 7]
    Assert.Equal<int list>([2; 4; 6], actual)

[<Fact>]
let ``del_even [1 .. 7] должно быть [1; 3; 5; 7]`` () = 
    let actual = del_even [1 .. 7]
    Assert.Equal<int list>([1; 3; 5; 7], actual)

[<Fact>]
let ``multiplicity 3 [1;5;3;6;3;7;3] должно быть 3`` () =
    let actual = multiplicity 3 [1;5;3;6;3;7;3]
    Assert.Equal(3, actual)

[<Fact>]
let ``split [1 .. 7] должно быть ([1; 3; 5; 7], [2; 4; 6])`` () =
    let actual = split [1 .. 7]
    Assert.Equal(([1; 3; 5; 7], [2; 4; 6]), actual)

[<Fact>]
let ``split [1 .. 6] должно быть ([1; 3; 5], [2; 4; 6])`` () =
    let actual = split [1 .. 6]
    Assert.Equal(([1; 3; 5], [2; 4; 6]), actual)

[<Fact>]
let ``zip ([1;2;3], [11;12;13]) должно быть [(1,11); (2,12); (3,13)]`` () =
    let actual = zip ([1;2;3], [11;12;13])
    let [actual_a; actual_b; actual_c] = actual
    Assert.Equal((1,11), actual_a)
    Assert.Equal((2,12), actual_b)
    Assert.Equal((3,13), actual_c)

[<Fact>]
let ``zip ([1;2;3;4], [11;12;13]) должно быть выброшено исключение`` () =
    Assert.Throws<System.Exception>(fun () -> 
        zip ([1;2;3;4], [11;12;13]) |> ignore
    )

