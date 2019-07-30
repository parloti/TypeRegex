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

## .NET Regular Expression Element Support

### Character Escapes
[DOC](https://docs.microsoft.com/en-us/dotnet/standard/base-types/character-escapes-in-regular-expressions)

|Character or sequence|Description|TypeRegex|
|-----------------|-----------------|-----------------|  
|`\a`|Alarm character, `\u0007`.|`Pattern.Alarm()`, `Escapes.Alarm`|
|`\a`|Bell character, `\u0007`.|`Pattern.Bell()`, `Escapes.Bell`|
|`\b`|Backspace, `\u0008`.|`Pattern.Backspace()`, `Escapes.Backspace`|  
|`\t`|Tab, `\u0009`.|`Pattern.Tab()`, `Escapes.Tab`|
|`\r`|Carriage return, `\u000D`.|`Pattern.CarriageReturn()`, `Escapes.CarriageReturn`|
|`\v`|Vertical tab, `\u000B`.|`Pattern.VerticalTab()`, `Escapes.VerticalTab`|
|`\f`|Form feed, `\u000C`.|`Pattern.FormFeed()`, `Escapes.FormFeed`|
|`\n`|New line, `\u000A`.|`Pattern.NewLine()`, `Escapes.NewLine`|
|`\e`|Escape, `\u001B`.|`Pattern.Escape()`, `Escapes.Escape`|
|*`\r?\n`*|*Zero or one occurrence of a carriage return followed by a new line, `\u000D?\u000A`.*|*`Pattern.NewLine(true)`, `Escapes.WindowsNewLine`*|
||||
|`\` *nnn*|ASCII character with octal code.|`Pattern.Octal(string octalNumber)`|
|`\x` *nn*|ASCII character with hexadecimal code.|`Pattern.Hexadecimal(string hexadecimalNumber)`|
|`\c` *X*|ASCII control character.|`Pattern.ASCIIControl(string controlCharacter)`|
|`\u` *nnnn*|UTF-16 code unit with hexadecimal value.|`Pattern.Unicode(string hexadecimal)`|
|`\`|Escapes the followed character.|`Pattern.Literal(char character)`|

### Character classes
*Coming soon*

### Anchors
*Coming soon*

### Grouping Constructs
*Coming soon*

### Quantifiers
*Coming soon*

### Backreference Constructs
*Coming soon*

### Alternation Constructs
*Coming soon*

## Contributing
Pull requests are welcome. For major changes, please open an issue first to discuss what you would like to change.

Please make sure to update tests as appropriate.

## License
[MIT](https://choosealicense.com/licenses/mit/)
