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

        const int firstListActualLength = 0;
        const int secondListActualLength = 5;
        
        Assert.AreEqual(firstListActualLength, firstList.Length);
        Assert.AreEqual(secondListActualLength, secondList.Length);
    }

    [TestMethod]
    public void TestListAppendMethod()
    {
        CustomList<char> emptyList = new CustomList<char>();
        CustomList<char> secondList = CreateTestList();

        const string emptyListExpectedString = "a";
        const string secondListExpectedString = "a b c d e a";
        
        emptyList.Append('a');
        secondList.Append('a');

        string emptyListString = emptyList.ToString();
        string secondListString = secondList.ToString();
        
        Assert.AreEqual(emptyListExpectedString, emptyListString);
        Assert.AreEqual(secondListExpectedString, secondListString);
    }

    [TestMethod]
    public void TestListInsertMethod()
    {
        CustomList<char> emptyList = new CustomList<char>();
        CustomList<char> secondList = CreateTestList();
        CustomList<char> thirdList = CreateTestList();
        
        secondList.Insert('a', 3);
        thirdList.Insert('a', 5);

        const string expectedSecondListString = "a b c a d e";
        const string expectedThirdListString = "a b c d e a";

        string secondListString = secondList.ToString();
        string thirdListString = thirdList.ToString();

        Assert.ThrowsException<ArgumentOutOfRangeException>((() => emptyList.Insert('a', 1)));
        Assert.AreEqual(expectedSecondListString, secondListString);
        Assert.AreEqual(expectedThirdListString, thirdListString);
    }

    [TestMethod]
    public void TestListDeleteMethod()
    {
        CustomList<char> emptyList = new CustomList<char>();
        CustomList<char> secondList = CreateTestList();
        
        const string expectedSecondListString = "a c d e";
        
        secondList.Delete(1);

        string secondListString = secondList.ToString();
        
        Assert.ThrowsException<ArgumentOutOfRangeException>((() => emptyList.Delete(0)));
        Assert.AreEqual(expectedSecondListString, secondListString);
    }

    [TestMethod]
    public void TestListDeleteAllMethod()
    {
        CustomList<char> emptyList = new CustomList<char>();
        CustomList<char> secondList = CreateTestList();
        CustomList<char> thirdList = CreateTestListWithSameChars();
        CustomList<char> fourthList = CreateTestList();

        const string expectedEmptyListString = "";
        const string expectedSecondListString = "a c d e";
        const string expectedThirdListString = "a a a";
        const string expectedFourthListString = "a b c d e";
        
        emptyList.DeleteAll('b');
        secondList.DeleteAll('b');
        thirdList.DeleteAll('b');
        fourthList.DeleteAll('h');

        string emptyListString = emptyList.ToString();
        string secondListString = secondList.ToString();
        string thirdListString = thirdList.ToString();
        string fourthListString = fourthList.ToString();

        Assert.AreEqual(expectedEmptyListString, emptyListString);
        Assert.AreEqual(expectedSecondListString, secondListString);
        Assert.AreEqual(expectedThirdListString, thirdListString);
        Assert.AreEqual(expectedFourthListString, fourthListString);
    }

    [TestMethod]
    public void TestListGetMethod()
    {
        CustomList<char> emptyList = new CustomList<char>();
        CustomList<char> secondList = CreateTestList();

        const char expectedSecondListItem = 'd';
        char secondListItem = secondList.Get(3);

        Assert.ThrowsException<ArgumentOutOfRangeException>(() => emptyList.Get(0));
        Assert.AreEqual(expectedSecondListItem, secondListItem);
    }
}