using System.Diagnostics;
using System.Linq;
using Castle.DynamicProxy;
using log4net;

namespace IoCSample09_Interception
{
    public class LoggingInterceptor : IInterceptor
    {
        private readonly ILog m_Log;

        public LoggingInterceptor(ILog log)
        {
            m_Log = log;
        }

        public void Intercept(IInvocation invocation)
        {
            var stopwatch = Stopwatch.StartNew();
            invocation.Proceed();
            stopwatch.Stop();

            m_Log.Debug(string.Format("Calling method {0} with parameters {1} took {2} ms", 
                invocation.Method.Name, 
                string.Join(", ", invocation.Arguments.Select(a => (a ?? "").ToString()).ToArray()),
                stopwatch.ElapsedMilliseconds));

        }
    }
}