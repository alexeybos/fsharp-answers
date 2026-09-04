[<Fact>]
let ``pow "abc" 3 должно быть "abcabcabc"`` () =
    let actual = pow ("abc", 3)
    Assert.Equal("abcabcabc", actual)

[<Fact>]
let ``pow "abc" 0 должно быть ""`` () =
    let actual = pow ("abc", 0)
    Assert.Equal("", actual)

[<Fact>]
let ``pow "abc" 1 должно быть "abc"`` () =
    let actual = pow ("abc", 1)
    Assert.Equal("abc", actual)

[<Fact>]
let ``isIthChar "123" 1 '2' должно быть true`` () =
    let actual = isIthChar ("123", 1, '2')
    Assert.True(actual)

[<Fact>]
let ``isIthChar "123" 1 '1' должно быть false`` () =
    let actual = isIthChar ("123", 1, '1')
    Assert.False(actual)

[<Fact>]
let ``isIthChar "123" 1 '4' должно быть false`` () =
    let actual = isIthChar ("123", 1, '4')
    Assert.False(actual)

[<Fact>]
let ``isIthChar "123" -1 '2' должно быть false`` () =
    let actual = isIthChar ("123", -1, '2')
    Assert.False(actual)

[<Fact>]
let ``occFromIth "11232" 1 '2' должно быть 2`` () =
    let actual = occFromIth ("11232", 1, '2')
    Assert.Equal(2, actual)

[<Fact>]
let ``occFromIth "11232" 1 '1' должно быть 1`` () =
    let actual = occFromIth ("11232", 1, '1')
    Assert.Equal(1, actual)

[<Fact>]
let ``occFromIth "11232" 1 '5' должно быть 0`` () =
    let actual = occFromIth ("11232", 1, '5')
    Assert.Equal(0, actual)