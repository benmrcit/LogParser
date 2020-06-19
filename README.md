# RevStackCore.LogParser
[![Build status](https://ci.appveyor.com/api/projects/status/upm5vapvhc80hjbt?svg=true)](https://ci.appveyor.com/project/tachyon1337/logparser)

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














