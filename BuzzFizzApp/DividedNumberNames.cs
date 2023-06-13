using System.Text;

namespace DividedNumber;

public class DividedNumberNames
{
    public void WriteDividedNumberNames(int limit, Dictionary<int, string> numberNames, Action<string> wrileResultLine)
    {
        var limitInvalid = limit < 1;
        var numberNamesInvalid =
            numberNames == null ||
            numberNames.Count == 0 ||
            numberNames.Any(name => name.Key < 1 || string.IsNullOrWhiteSpace(name.Value));

        if (limitInvalid)
        {
            throw new ArgumentException("Limit param should be greater then 0", nameof(limit));
        }

        if (numberNamesInvalid)
        {
            throw new ArgumentException("NumberNames param should have keys greater then 0 and values not null, empty or whitespace", nameof(numberNames));
        }

        for (var i = 1; i <= limit; i++)
        {
            var nameResults = new StringBuilder();
            var numberResults = numberNames.Where(name => i % name.Key == 0);

            if (numberResults.Count() == 0)
            {
                nameResults.Append(i);
            }
            else
            {
                numberResults
                    .ToList()
                    .ForEach(numberResult =>
                        {
                            nameResults.Append(numberResult.Value + " ");
                        }
                    );
            }

            wrileResultLine(nameResults.ToString().Trim());
        }
    }
}

