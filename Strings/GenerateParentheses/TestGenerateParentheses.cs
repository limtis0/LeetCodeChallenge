namespace LeetCodeChallenge;

[TestClass]
public class TestGenerateParentheses
{
    [TestMethod]
    [DataRow(1, "()")]
    [DataRow(3, "((()))", "(()())", "(())()", "()(())", "()()()")]
    public void Tests(int n, params string[] expected)
    {
        // Act
        var actual = GenerateParentheses.GenerateParenthesis(n);

        CollectionAssert.AreEquivalent(expected, actual.ToList());
    }
}
