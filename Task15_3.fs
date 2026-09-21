[<Fact>]
let ``list_filter with x>0 for [-1;2;3;5;-9] return [2;3;5]`` () =
  let filter_fun x = x > 0
  let actual = list_filter filter_fun [-1;2;3;5;-9]
  Assert.Equal<int list>([2;3;5], actual)

[<Fact>]
let ``list_filter with x>0 for [2;3;5] return [2;3;5]`` () =
  let filter_fun x = x > 0
  let actual = list_filter filter_fun [2;3;5]
  Assert.Equal<int list>([2;3;5], actual)

[<Fact>]
let ``sum with predicat x % 2 = 0 for [-1;2;3;5;-8] returns -6`` () =
    let prd x = x % 2 = 0
    let actual = sum (prd, [-1;2;3;5;-8])
    Assert.Equal(-6, actual)

[<Fact>]
let ``revrev (fold) [[1;2];[3;4;5];[6;7]] дает [[7; 6]; [5; 4; 3]; [2; 1]]`` () =
   let actual = revrev [[1;2];[3;4;5];[6;7]]
   let actual_a = actual.[0]
   let actual_b = actual.[1]
   let actual_c = actual.[2]
   Assert.Equal<int list>([7; 6], actual_a)
   Assert.Equal<int list>([5; 4; 3], actual_b)
   Assert.Equal<int list>([2; 1], actual_c)