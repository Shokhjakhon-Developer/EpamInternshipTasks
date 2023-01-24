using NUnit.Framework;
using Unit_Tests.Character_counter;

namespace Unit_Tests.Character_Counter_Tests;

[TestFixture, Parallelizable(ParallelScope.Self)]
public class CharacterCounterTest
{
    private CharacterCounter? _characterCounter;

    [SetUp]
    public void SetUp() => _characterCounter = new CharacterCounter();

    [TestCase(null, ExpectedResult = -1)]
    [TestCase("", ExpectedResult = -1)]
    [TestCase("Abby", ExpectedResult = 1)]
    [TestCase("Abby and Dean went to kindergarten.", ExpectedResult = 3)]
    public int TestNonIdenticalConsecutiveLetters(string str)
    {
        _characterCounter!.ChangeArgument(str);
        var result = _characterCounter!.ConsecutiveNonIdenticalLetter();
        return result;
    }


    [TestCase("Abby", ExpectedResult = 2)]
    [TestCase("Abby and Dean went to kindergarten.", ExpectedResult = 6)]
    [TestCase("Grammar", ExpectedResult = 1)]
    [TestCase("Book", ExpectedResult = 1)]
    public int TestIdenticalConsecutiveLetters(string str)
    {
        _characterCounter!.ChangeArgument(str);
        var result = _characterCounter!.ConsecutiveIdenticalLetter();
        return result;
    }

    [TestCase("12589", ExpectedResult = 2)]
    [TestCase("1598369457", ExpectedResult = 1)]
    [TestCase("9574126534", ExpectedResult = 2)]
    [TestCase("122957789", ExpectedResult = 3)]
    public int TestIdenticalConsecutiveDigits(string str)
    {
        _characterCounter!.ChangeArgument(str);
        var result = _characterCounter!.ConsecutiveNonIdenticalLetter();
        return result;
    }
}