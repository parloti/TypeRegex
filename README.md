# TypeRegex

Typified help in building regular expressions pattern.

**Typified C Regular Expressions Pattern.**

TypeRegex is a CSharp library that helps to construct regular expressions patterns reducing typos and other common mistakes.


## Installation

Use the package manager [NuGet](https://www.nuget.org/packages/TypeRegex/) to install **TypeRegex**.

```
Install-Package TypeRegex
```

## Usage

```CSharp
using TypeRegex;

public class Program
{
  public static void Main()
  {
    var pattern = new Pattern()
                    .AtStartOfStringOnly()
                    .Any()
                    .NewLine(true)
                    .AtEndOfStringOnly();
    
    Console.Write(pattern);

    // The example displays the following output:
    //    "\A[\u0000-\uFFFF]\u000D?\u000A\z"
  }
};
```

## Contributing
Pull requests are welcome. For major changes, please open an issue first to discuss what you would like to change.

Please make sure to update tests as appropriate.

## License
[MIT](https://choosealicense.com/licenses/mit/)
