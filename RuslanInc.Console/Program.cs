using DividedNumber;

var dividedNumberNames = new DividedNumberNames();
var numberLimit = 15;
var numberNames = new Dictionary<int, string>
{
    { 3, "Fizz" },
    { 5, "Buzz" },
};

dividedNumberNames.WriteDividedNumberNames(numberLimit, numberNames, Console.WriteLine);