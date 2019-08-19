# TypeRegex

Typified help in building regular expressions pattern.

**Typified C# Regular Expressions Pattern.**

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
[Official Documentation](https://docs.microsoft.com/en-us/dotnet/standard/base-types/character-escapes-in-regular-expressions)

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
[Official Documentation](https://docs.microsoft.com/en-us/dotnet/standard/base-types/character-classes-in-regular-expressions)

|Syntax|Description|TypeRegex|
|-----------------|-----------------|-----------------|  
|`[character_group]`|[Positive character group.](https://docs.microsoft.com/en-us/dotnet/standard/base-types/character-classes-in-regular-expressions#positive-character-group--)|`Pattern.AnyIn(string set, bool escape = true)`<br>`new PositiveCharacterGroup(string set, bool escape = true)`|
|`[character_group]`||`Pattern.AnyIn(params char[] set)`<br>`new PositiveCharacterGroup(params char[] set)`|
|`[firstCharacter-lastCharacter]`||`Pattern.Range(char first, char last, bool caseSensitive = true)`<br>`new PositiveCharacterGroup(char first, char last, bool caseSensitive = true)`|
|`[firstCharacter-lastCharacter]`||`Pattern.Range(uint first, uint last)`<br>`new PositiveCharacterGroup(uint first, uint last)`|
|`[^character_group]`|[Negative character group.](https://docs.microsoft.com/en-us/dotnet/standard/base-types/character-classes-in-regular-expressions#negative-character-group-)|`Pattern.AnyNotIn(string set, bool escape = true)`<br>`new NegativeCharacterGroup(string set, bool escape = true)`|
|`[^character_group]`||`Pattern.AnyNotIn(params char[] set)`<br>`new NegativeCharacterGroup(params char[] set)`|
|`[^firstCharacter-lastCharacter]`||`Pattern.NotInRange(char first, char last, bool caseSensitive = true)`<br>`new NegativeCharacterGroup(char first, char last, bool caseSensitive = true)`|
|`[^firstCharacter-lastCharacter]`||`Pattern.NotInRange(uint first, uint last)`<br>`new NegativeCharacterGroup(uint first, uint last)`|
|`.`|[Any character](https://docs.microsoft.com/en-us/dotnet/standard/base-types/character-classes-in-regular-expressions#any-character-)|`Pattern.Any()`<br>`new PositiveCharacterGroup()`|
|`\p{name}`|[Unicode Category](https://docs.microsoft.com/en-us/dotnet/standard/base-types/character-classes-in-regular-expressions#unicode-category-or-unicode-block-p)|`Pattern.Add(UnicodeGroup{PositiveUnicodeCategory}.ToString())`<br>`Pattern.UnicodeGroup(UnicodeGroup{PositiveUnicodeCategory} group)`|
|`\p{name}`|[Unicode Block](https://docs.microsoft.com/en-us/dotnet/standard/base-types/character-classes-in-regular-expressions#unicode-category-or-unicode-block-p)|`Pattern.Add(UnicodeGroup{PositiveUnicodeBlock}.ToString())`<br>`Pattern.UnicodeGroup(UnicodeGroup{PositiveUnicodeBlock} group)`|
|`\P{name}`|[Negative Unicode Category](https://docs.microsoft.com/en-us/dotnet/standard/base-types/character-classes-in-regular-expressions#negative-unicode-category-or-unicode-block-p)|`Pattern.Add(UnicodeGroup{NegativeUnicodeCategory}.ToString())`<br>`Pattern.UnicodeGroup(UnicodeGroup{NegativeUnicodeCategory} group)`|
|`\P{name}`|[Negative Unicode Block](https://docs.microsoft.com/en-us/dotnet/standard/base-types/character-classes-in-regular-expressions#unicode-category-or-unicode-block-p)|`Pattern.Add(UnicodeGroup{NegativeUnicodeBlock}.ToString())`<br>`Pattern.UnicodeGroup(UnicodeGroup{NegativeUnicodeBlock} group)`|
|`\w`|[Word character](https://docs.microsoft.com/en-us/dotnet/standard/base-types/character-classes-in-regular-expressions#word-character-w)|`Pattern.Word(MatchingBehavior matchingBehavior = MatchingBehavior.Default)`<br>`Pattern.ECMAScriptWord()`<br>`Pattern.UnicodeWord()`|
|`\W`|[Non-word character](https://docs.microsoft.com/en-us/dotnet/standard/base-types/character-classes-in-regular-expressions#non-word-character-w)|`Pattern.NonWord(MatchingBehavior matchingBehavior = MatchingBehavior.Default)`<br>`Pattern.ECMAScriptNonWord()`<br>`Pattern.UnicodeNonWord()`|
|`\s`|[Whitespace character](https://docs.microsoft.com/en-us/dotnet/standard/base-types/character-classes-in-regular-expressions#whitespace-character-s)|`Pattern.WhiteSpace(MatchingBehavior matchingBehavior = MatchingBehavior.Default)`<br>`Pattern.ECMAScriptWhiteSpace()`<br>`Pattern.UnicodeWhiteSpace()`|
|`\S`|[Non-whitespace character](https://docs.microsoft.com/en-us/dotnet/standard/base-types/character-classes-in-regular-expressions#non-whitespace-character-s)|`Pattern.NonWhiteSpace(MatchingBehavior matchingBehavior = MatchingBehavior.Default)`<br>`Pattern.ECMAScriptNonWhiteSpace()`<br>`Pattern.UnicodeNonWhiteSpace()`|
|`\d`|[Decimal digit character](https://docs.microsoft.com/en-us/dotnet/standard/base-types/character-classes-in-regular-expressions#decimal-digit-character-d)|`Pattern.Digit(MatchingBehavior matchingBehavior = MatchingBehavior.Default)`<br>`Pattern.ECMAScriptDigit()`<br>`Pattern.UnicodeDigit()`|
|`\D`|[Non-digit character](https://docs.microsoft.com/en-us/dotnet/standard/base-types/character-classes-in-regular-expressions#non-digit-character-d)|`Pattern.NonDigit(MatchingBehavior matchingBehavior = MatchingBehavior.Default)`<br>`Pattern.ECMAScriptNonDigit()`<br>`Pattern.UnicodeNonDigit()`|
|`[base_group - [excluded_group]]`|[Character class subtraction](https://docs.microsoft.com/en-us/dotnet/standard/base-types/character-classes-in-regular-expressions#character-class-subtraction-base_group---excluded_group)|`Pattern.Subtraction(ISubtractable baseGroup, CharacterGroup excludedGroup)`|

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
