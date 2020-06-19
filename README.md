# RevStackCore.LogParser


IIS W3C typed log file reader/parser

# Nuget Installation

``` bash
Install-Package RevStackCore.LogParser
```

# Usage

```cs
string filePath="/path/to/file";
using (TextReader reader = File.OpenText(filePath))
{
    var w3cLogModel = new W3CReader(textReader).Read();
}
```














