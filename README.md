Issue:

When using `encoding="Unicode"` the written log file cannot be opened properly in some editors if it contains non-English Unicode characters such as Japanese characters. It works fine in Notepad or SublimeText but not Notepad++ or VSCode.
Given that Notepad++ and VSCode are commonly used editors, there must be a way of writing the file in such a way that those editors can interpret the encoding correctly.

For an example of a file being produced by this solution, please see [here](https://github.com/bergmeister/NLog_Unicode_Issue/blob/master/log.txt)