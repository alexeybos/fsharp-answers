[<Fact>]
let ``6 число Фибоначчи для старта с 0 1 должно быть 8`` () =
    let actual = fibo1 6 1 0
    Assert.Equal(8, actual)

[<Fact>]
let ``6 число Фибоначчи для старта с 3 5 должно быть 55`` () =
    let actual = fibo1 6 5 3
    Assert.Equal(55, actual)

[<Fact>]
let ``fibo2 1-е число Фибоначчи должно быть 1`` () =
    let actual = fibo2 1 id 
    Assert.Equal(1, actual)

[<Fact>]
let ``fibo2 0-е число Фибоначчи должно быть 0`` () =
    let actual = fibo2 0 id 
    Assert.Equal(0, actual)

[<Fact>]
let ``fibo2 10-е число Фибоначчи должно быть 55`` () =
    let actual = fibo2 10 id 
    Assert.Equal(55, actual)

[<Fact>]
let ``регресс big_list (для 5 массив [1; 1; 1; 1; 1])`` () =
    let actual = bigList 5 id
    Assert.Equal<int list>([1; 1; 1; 1; 1], actual)

