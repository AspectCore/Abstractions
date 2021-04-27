using System;

namespace AspectCore.DynamicProxy
{
    /// <summary>
    /// �����쳣��װ���ӿ�
    /// </summary>
    public interface IAspectExceptionWrapper
    {
        /// <summary>
        /// ��װ�쳣����
        /// </summary>
        /// <param name="aspectContext">����������</param>
        /// <param name="exception">�쳣����</param>
        /// <returns>��װ����쳣����</returns>
        Exception Wrap(AspectContext aspectContext, Exception exception);
    }
}