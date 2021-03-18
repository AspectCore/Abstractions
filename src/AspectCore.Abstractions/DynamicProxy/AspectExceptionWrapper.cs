using System;
using AspectCore.Configuration;

namespace AspectCore.DynamicProxy
{
    /// <summary>
    /// �����쳣��װ��
    /// </summary>
    [NonAspect]
    public class AspectExceptionWrapper : IAspectExceptionWrapper
    {
        private readonly IAspectConfiguration _configuration;

        /// <summary>
        /// ���������쳣��װ��
        /// </summary>
        /// <param name="configuration">��������</param>
        public AspectExceptionWrapper(IAspectConfiguration configuration)
        {
            _configuration = configuration;
        }

        /// <summary>
        /// ��װ�쳣����
        /// </summary>
        /// <param name="aspectContext">����������</param>
        /// <param name="exception">�쳣����</param>
        /// <returns>��װ����쳣����</returns>
        public Exception Wrap(AspectContext aspectContext, Exception exception)
        {
            if (!_configuration.ThrowAspectException)
            {
                return exception;
            }

            if (exception is AspectInvocationException aspectInvocationException)
            {
                return aspectInvocationException;
            }

            return new AspectInvocationException(aspectContext, exception);
        }
    }
}