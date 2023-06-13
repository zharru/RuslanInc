using DividedNumber;

namespace UtilTests;

public class DividedNumberNamesTests
{
    [Fact]
    public void DividedNumberNamesBuzzFizz15Check()
    {
        var numberLimit = 15;
        var numberNames = new Dictionary<int, string>
        {
            { 3, "Fizz" },
            { 5, "Buzz" },
        };
        var outputExpected = new List<string>
        {
            "1",
            "2",
            "Fizz",
            "4",
            "Buzz",
            "Fizz",
            "7",
            "8",
            "Fizz",
            "Buzz",
            "11",
            "Fizz",
            "13",
            "14",
            "Fizz Buzz"
        };
        var outputResult = new List<string>();
        var dividedNumberNames = new DividedNumberNames();

        dividedNumberNames.WriteDividedNumberNames(numberLimit, numberNames, outputResult.Add);

        Assert.Equal(outputExpected, outputResult);
    }



    [Fact]
    public void DividedNumberNamesInvalidInputCheck()
    {
        var numberLimit = 1;
        var invalidNumberLimit1 = 0;
        var invalidNumberLimit2 = -1;
        var numberNames = new Dictionary<int, string>
        {
            { 1, "Valid" }
        };
        var invalidNumberNames1 = new Dictionary<int, string>
        {
            { 0, "Fizz" }
        };
        var invalidNumberNames2 = new Dictionary<int, string>
        {
            { -1, "Fizz" }
        };
        var invalidNumberNames3 = new Dictionary<int, string>
        {
            { 2, string.Empty }
        };
        var invalidNumberNames4 = new Dictionary<int, string>
        {
            { 3, " " }
        };
        var invalidNumberNames5 = new Dictionary<int, string>
        {
            { 4, null }
        };
        var dividedNumberNames = new DividedNumberNames();

        Assert.Throws<ArgumentException>(() => dividedNumberNames.WriteDividedNumberNames(invalidNumberLimit1, numberNames, (resultLine) => { }));
        Assert.Throws<ArgumentException>(() => dividedNumberNames.WriteDividedNumberNames(invalidNumberLimit2, numberNames, (resultLine) => { }));
        Assert.Throws<ArgumentException>(() => dividedNumberNames.WriteDividedNumberNames(numberLimit, invalidNumberNames1, (resultLine) => { }));
        Assert.Throws<ArgumentException>(() => dividedNumberNames.WriteDividedNumberNames(numberLimit, invalidNumberNames2, (resultLine) => { }));
        Assert.Throws<ArgumentException>(() => dividedNumberNames.WriteDividedNumberNames(numberLimit, invalidNumberNames3, (resultLine) => { }));
        Assert.Throws<ArgumentException>(() => dividedNumberNames.WriteDividedNumberNames(numberLimit, invalidNumberNames4, (resultLine) => { }));
        Assert.Throws<ArgumentException>(() => dividedNumberNames.WriteDividedNumberNames(numberLimit, invalidNumberNames5, (resultLine) => { }));
    }
}
