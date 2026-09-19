[<Fact>]
let ``sum для четных чисел списка равно 6`` () =
   let actual = sum (is_even, [1 .. 5])
   Assert.Equal(6, actual)

[<Fact>]
let ``count для элемента 5 в списке [1;3;5;5;7] равно 2`` () =
   let actual = count ([1;3;5;5;7], 5)
   Assert.Equal(2, actual)

[<Fact>]
let ``insert 4 в слабовосходящий список [1;3;5;8] дает [1;3;4;5;8]`` () =
   let actual = insert ([1;3;5;8], 4)
   Assert.Equal<int list>([1;3;4;5;8], actual)

[<Fact>]
let ``insert 0 в слабовосходящий список [0;0;1;1;1;2;3] дает [0; 0; 0; 1; 1; 1; 2; 3]`` () =
   let actual = insert ([0;0;1;1;1;2;3], 0)
   Assert.Equal<int list>([0; 0; 0; 1; 1; 1; 2; 3], actual)

[<Fact>]
let ``intersect ([1;3;5;8], [4]) дает []`` () =
   let actual = intersect ([1;3;5;8], [4])
   Assert.Equal<int list>([], actual)

[<Fact>]
let ``intersect ([1;3;3;3;5;8], [3;3;5;6]) дает [3;3;5]`` () =
   let actual = intersect ([1;3;3;3;5;8], [3;3;5;6])
   Assert.Equal<int list>([3;3;5], actual)

[<Fact>]
let ``plus ([1;3;5;8], [4]) дает [1;3;4;5;8]`` () =
   let actual = plus ([1;3;5;8], [4])
   Assert.Equal<int list>([1;3;4;5;8], actual)

[<Fact>]
let ``minus ([1;3;3;5;8], [3;5;6]) дает [1;3;8]`` () =
   let actual = minus ([1;3;3;5;8], [3;5;6])
   Assert.Equal<int list>([1;3;8], actual)

[<Fact>]
let ``smallest [7;12;5;8] дает 5`` () =
   let actual = Option.get (smallest [7;12;5;8])
   Assert.Equal(5, actual)

[<Fact>]
let ``delete (3, [1 .. 5]) дает [1;2;4;5]`` () =
   let actual = delete (3, [1 .. 5])
   Assert.Equal<int list>([1;2;4;5], actual)

[<Fact>]
let ``sort [7;12;5;8] дает [5;7;8;12]`` () =
   let actual = sort [7;12;5;8]
   Assert.Equal<int list>([5;7;8;12], actual)

[<Fact>]
let ``revrev [[1;2];[3;4;5];[6;7]] дает [[7; 6]; [5; 4; 3]; [2; 1]]`` () =
   let actual = revrev [[1;2];[3;4;5];[6;7]]
   let actual_a = actual.[0]
   let actual_b = actual.[1]
   let actual_c = actual.[2]
   Assert.Equal<int list>([7; 6], actual_a)
   Assert.Equal<int list>([5; 4; 3], actual_b)
   Assert.Equal<int list>([2; 1], actual_c)