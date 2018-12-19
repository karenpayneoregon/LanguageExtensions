# TechNet December 2018 article: C# extension methods
## Introduction

This article will discuss the fundamentals to extend existing types without creating new derived type, recompiling, or otherwise modifying the original type. [Extension methods](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/extension-methods) are a special kind of static method, but they are called as if they were instance methods on the extended type. 

For client code written in C#, F# and Visual Basic, there is no apparent difference between calling an extension method and the methods that are defined in a type. The primary language will be C# but extension methods as mention prior will work in other languages and can be written in one language and used in another language.

[Article location](https://social.technet.microsoft.com/wiki/contents/articles/52264.extension-methods-c.aspx).

### Important

- Ensure SQL-Server is installed and running
- Change the data connection in the project [BaseLibrary.BaseSqlServerConnections](https://github.com/karenpayneoregon/LanguageExtensions/blob/master/BaseLibrary/BaseSqlServerConnections.cs).
- Before running example projects you must first run the data scripts under the Solution items folder.
- Install SandCastle or unload the document project
