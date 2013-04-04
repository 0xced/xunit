using System.Collections.Generic;
using Xunit.Abstractions;

namespace Xunit.Sdk
{
    public interface IXunitTestCase : ITestCase
    {
        IEnumerable<object> Arguments { get; }

        bool Run(IMessageSink messageSink);
    }
}