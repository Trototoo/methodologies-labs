using Lab2;

namespace Tests;

[TestClass]
public class UnitTest1
{

    private CustomList<char> CreateTestList()
    {
        CustomList<char> list = new CustomList<char>();
        list.Append('a');
        list.Append('b');
        list.Append('c');
        list.Append('d');
        list.Append('e');
        return list;
    }
    
    private CustomList<char> CreateTestListWithSameChars()
    {
        CustomList<char> list = new CustomList<char>();
        list.Append('a');
        list.Append('a');
        list.Append('a');
        list.Append('b');
        list.Append('b');
        return list;
    }
    
    [TestMethod]
    public void TestListLength()
    {
        CustomList<char> firstList = new CustomList<char>();
        CustomList<char> secondList = CreateTestList();

        int firstListActualLength = 0;
        int secondListActualLength = 5;
        
        Assert.AreEqual(firstListActualLength, firstList.Length);
        Assert.AreEqual(secondListActualLength, secondList.Length);
    }
}