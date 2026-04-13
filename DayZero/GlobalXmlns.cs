// <copyright file="GlobalXmlns.cs" company="Behr, Michael">
// Copyright Behr, Michael.
// All rights reserved.
// Use of this code is subject to the terms of our license.
// See license.txt file in the project root for full license information.
// </copyright>

// The sample from David Ortinau's blog post on simpler XAML in .NET MAUI 10:
//https://devblogs.microsoft.com/dotnet/simpler-xaml-in-dotnet-maui-10/?hide_banner=true

using XmlnsDefinitionAttribute = Microsoft.Maui.Controls.XmlnsDefinitionAttribute;
using XmlnsPrefixAttribute = Microsoft.Maui.Controls.XmlnsPrefixAttribute;

[assembly: XmlnsPrefix("http://schemas.microsoft.com/dotnet/maui/global", "global")]

[assembly: XmlnsDefinition(
    "http://schemas.microsoft.com/dotnet/maui/global",
    "DayZero.Model")]

[assembly: XmlnsDefinition(
    "http://schemas.microsoft.com/dotnet/maui/global",
    "DayZero.Resources")]
[assembly: XmlnsDefinition(
    "http://schemas.microsoft.com/dotnet/maui/global",
    "DayZero.Resources.Strings")]
[assembly: XmlnsDefinition(
    "http://schemas.microsoft.com/dotnet/maui/global",
    "DayZero.Resources.Generated")]
[assembly: XmlnsDefinition(
    "http://schemas.microsoft.com/dotnet/maui/global",
    "DayZero.View")]
[assembly: XmlnsDefinition(
    "http://schemas.microsoft.com/dotnet/maui/global",
    "DayZero.ViewModel")]
[assembly: XmlnsDefinition(
    "http://schemas.microsoft.com/dotnet/maui/global",
    "LibraryTen.Controls",
    AssemblyName = "LibraryTen")]

[assembly: XmlnsDefinition(
    "http://schemas.microsoft.com/dotnet/maui/global",
    "LibraryTen.Converter",
    AssemblyName = "LibraryTen")]

[assembly: XmlnsDefinition(
    "http://schemas.microsoft.com/dotnet/maui/global",
    "LibraryTen.MarkupExtensions", AssemblyName = "LibraryTen")]

[assembly: XmlnsDefinition(
    "http://schemas.microsoft.com/dotnet/maui/global",
    "http://schemas.microsoft.com/dotnet/2022/maui/toolkit")]