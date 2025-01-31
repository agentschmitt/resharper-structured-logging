﻿using NUnit.Framework;

namespace ReSharper.Structured.Logging.Tests.Analyzer
{
    public class TemplateFormatAnalyzerTests : MessageTemplateAnalyzerTestBase
    {
        protected override string SubPath => "TemplateFormat";

        [Test] public void TestNlogValidNamedPropertyFluentApi() => DoNamedTest2();

        [Test] public void TestSerilogInvalidNamedProperty() => DoNamedTest2();

        [Test] public void TestSerilogInvalidPositionProperty() => DoNamedTest2();

        [Test] public void TestSerilogTemplateWithEscapedSymbols() => DoNamedTest2();

        [Test] public void TestSerilogValidNamedProperty() => DoNamedTest2();

        [Test] public void TestSerilogValidPositionProperty() => DoNamedTest2();
    }
}
