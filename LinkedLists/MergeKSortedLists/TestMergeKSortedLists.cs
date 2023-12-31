using SinglyLinkedList;

namespace LeetCodeChallenge;

[TestClass]
public class TestMergeKSortedLists
{
    [TestMethod]
    public void TestGeneral()
    {
        // Arrange
        ListNode[] lists =
        {
            new(new int[] { 1, 4, 5 }),
            new(new int[] { 1, 3, 4 }),
            new(new int[] { 2, 6 })
        };

        ListNode expected = new(new int[] { 1, 1, 2, 3, 4, 4, 5, 6 });

        // Act
        ListNode actual = MergeKSortedLists.MergeKLists(lists);

        // Assert
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void TestEmpty()
    {
        // Arrange
        ListNode[] lists = Array.Empty<ListNode>();

        // Act
        ListNode actual = MergeKSortedLists.MergeKLists(lists);

        // Assert
        Assert.IsNull(actual);
    }

    [TestMethod]
    public void TestNone()
    {
        // Arrange
        ListNode?[] lists = { null };

        // Act
        ListNode actual = MergeKSortedLists.MergeKLists(lists!);

        // Assert
        Assert.IsNull(actual);
    }
}
