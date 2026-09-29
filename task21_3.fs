[<Fact>]
let ``проверка последовательности факториалов для реализации fac_seq n`` () =
    let actual_a = Seq.nth 0 Task21.fac_seq
    let actual_b = Seq.nth 1 Task21.fac_seq
    let actual_c = Seq.nth 5 Task21.fac_seq
    Assert.Equal(1, actual_a)
    Assert.Equal(1, actual_b)
    Assert.Equal(120, actual_c)

[<Fact>]
let ``проверка последовательности плюс-минус для реализации seq_seq n`` () =
    let actual_a = Seq.nth 0 Task21.seq_seq
    let actual_b = Seq.nth 1 Task21.seq_seq
    let actual_c = Seq.nth 2 Task21.seq_seq
    let actual_d = Seq.nth 5 Task21.seq_seq
    Assert.Equal(0, actual_a)
    Assert.Equal(-1, actual_b)
    Assert.Equal(1, actual_c)
    Assert.Equal(-3, actual_d)