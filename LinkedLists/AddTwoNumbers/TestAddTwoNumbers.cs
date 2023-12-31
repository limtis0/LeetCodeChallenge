using SinglyLinkedList;

namespace LeetCodeChallenge;

[TestClass]
public class TestAddTwoNumbers
{
    [TestMethod]
    public void Test1()
    {
        // Arrange
        int[] values1 = { 2, 4, 3 };
        int[] values2 = { 5, 6, 4 };

        ListNode l1 = new(values1);
        ListNode l2 = new(values2);

        int[] expectedValues = { 7, 0, 8 };
        ListNode expected = new(expectedValues);

        // Act
        ListNode actual = AddTwoNumbers.Solution(l1, l2);

        // Assert
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void Test2()
    {
        // Arrange
        int[] values1 = { 0 };
        int[] values2 = { 0 };

        ListNode l1 = new(values1);
        ListNode l2 = new(values2);

        int[] expectedValues = { 0 };
        ListNode expected = new(expectedValues);

        // Act
        ListNode actual = AddTwoNumbers.Solution(l1, l2);

        // Assert
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void Test3()
    {
        // Arrange
        int[] values1 = { 9, 9, 9, 9, 9, 9, 9 };
        int[] values2 = { 9, 9, 9, 9 };

        ListNode l1 = new(values1);
        ListNode l2 = new(values2);

        int[] expectedValues = { 8, 9, 9, 9, 0, 0, 0, 1 };
        ListNode expected = new(expectedValues);

        // Act
        ListNode actual = AddTwoNumbers.Solution(l1, l2);

        // Assert
        Assert.AreEqual(expected, actual);
    }
}
