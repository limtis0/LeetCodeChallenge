using SinglyLinkedList;

namespace LeetCodeChallenge;

[TestClass]
public class TestDeleteMIddleNode
{
    [TestMethod]
    public void Test1()
    {
        // Arrange
        int[] values = { 1, 3, 4, 7, 1, 2, 6 };
        ListNode head = new(values);

        int[] expectedValues = { 1, 3, 4, 1, 2, 6 };
        ListNode expected = new(expectedValues);

        // Act
        head = DeleteMiddleNode.DeleteMiddle(head);

        // Assert
        Assert.AreEqual(head, expected);
    }

    [TestMethod]
    public void Test2()
    {
        // Arrange
        int[] values = { 1, 2, 3, 4 };
        ListNode head = new(values);

        int[] expectedValues = { 1, 2, 4 };
        ListNode expected = new(expectedValues);

        // Act
        head = DeleteMiddleNode.DeleteMiddle(head);

        // Assert
        Assert.AreEqual(head, expected);
    }

    [TestMethod]
    public void Test3()
    {
        // Arrange
        int[] values = { 2, 1 };
        ListNode head = new(values);

        int[] expectedValues = { 2 };
        ListNode expected = new(expectedValues);

        // Act
        head = DeleteMiddleNode.DeleteMiddle(head);

        // Assert
        Assert.AreEqual(head, expected);
    }

    [TestMethod]
    public void Test4()
    {
        // Arrange
        int[] values = { 1 };
        ListNode head = new(values);

        ListNode? expected = null;

        // Act
        head = DeleteMiddleNode.DeleteMiddle(head);

        // Assert
        Assert.AreEqual(head, expected);
    }

    [TestMethod]
    public void Test5()
    {
        // Arrange
        int[] values = { 3, 1, 2 };
        ListNode head = new(values);

        int[] expectedValues = { 3, 2 };
        ListNode expected = new(expectedValues);

        // Act
        head = DeleteMiddleNode.DeleteMiddle(head);

        // Assert
        Assert.AreEqual(head, expected);
    }
}
