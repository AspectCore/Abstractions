using System.Collections.Generic;

namespace AspectCore.DependencyInjection
{
    /// <summary>
    /// ��������ص����ܵ��ṩ�߽ӿ�
    /// </summary>
    internal interface IServiceResolveCallbackProvider
    {
        /// <summary>
        /// �ṩһ�����ص�����
        /// </summary>
        IServiceResolveCallback[] ServiceResolveCallbacks { get; }
    }
}