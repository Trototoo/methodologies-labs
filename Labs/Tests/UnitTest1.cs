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
    public void TestMethod1()
    {
    }
}