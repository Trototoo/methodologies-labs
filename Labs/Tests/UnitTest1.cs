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

    [TestMethod]
    public void TestListAppendMethod()
    {
        CustomList<char> emptyList = new CustomList<char>();
        CustomList<char> secondList = CreateTestList();

        string emptyListExpectedString = "a";
        string secondListExpectedString = "a b c d e a";
        
        emptyList.Append('a');
        secondList.Append('a');

        string emptyListString = emptyList.ToString();
        string secondListString = secondList.ToString();
        
        Assert.AreEqual(emptyListExpectedString, emptyListString);
        Assert.AreEqual(secondListExpectedString, secondListString);
    }
}