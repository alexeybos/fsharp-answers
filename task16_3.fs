[<Fact>]
let ``allSubsets 4 3 return set [set [1; 2; 3]; set [1; 2; 4]; set [1; 3; 4]; set [2; 3; 4]]`` () =
   let actual = allSubsets 4 3
   let expected = set [set [1; 2; 3]; set [1; 2; 4]; set [1; 3; 4]; set [2; 3; 4]]
   Assert.Empty(Set.difference actual expected)

[<Fact>]
let ``allSubsets 4 0 return set [set []]`` () =
   let actual = allSubsets 4 0
   let expected = set [set []]
   Assert.Empty(Set.difference actual expected)