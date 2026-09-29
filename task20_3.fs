[<Fact>]
let ``проверка последовательности четных ПОЛОЖИТЕЛЬНЫХ чисел`` () =
    let actual_a = Seq.nth 0 even_seq
    let actual_b = Seq.nth 1 even_seq
    let actual_c = Seq.nth 2 even_seq
    Assert.Equal(2, actual_a)
    Assert.Equal(4, actual_b)
    Assert.Equal(6, actual_c)

[<Fact>]
let ``проверка последовательности факториалов`` () =
    let actual_a = Seq.nth 0 fac_seq
    let actual_b = Seq.nth 1 fac_seq
    let actual_c = Seq.nth 5 fac_seq
    Assert.Equal(1, actual_a)
    Assert.Equal(1, actual_b)
    Assert.Equal(120, actual_c)

[<Fact>]
let ``проверка последовательности плюс-минус`` () =
    let actual_a = Seq.nth 0 seq_seq
    let actual_b = Seq.nth 1 seq_seq
    let actual_c = Seq.nth 2 seq_seq
    let actual_d = Seq.nth 5 seq_seq
    Assert.Equal(0, actual_a)
    Assert.Equal(-1, actual_b)
    Assert.Equal(1, actual_c)
    Assert.Equal(-3, actual_d)