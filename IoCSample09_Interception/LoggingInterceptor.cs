using System.Diagnostics;
using System.Linq;
using Castle.DynamicProxy;
using log4net;

namespace IoCSample09_Interception
{
    public class LoggingInterceptor : IInterceptor
    {
        private readonly ILog _log;

        public LoggingInterceptor(ILog log)
        {
            _log = log;
        }

        public void Intercept(IInvocation invocation)
        {
            var stopwatch = Stopwatch.StartNew();

            invocation.Proceed();

            stopwatch.Stop();

            _log.DebugFormat("{0} ( {1} ) took {2} ms", 
                invocation.Method.Name, 
                string.Join(", ", invocation.Arguments.Select(a => (a ?? "").ToString()).ToArray()),
                stopwatch.ElapsedMilliseconds);

        }
    }
}