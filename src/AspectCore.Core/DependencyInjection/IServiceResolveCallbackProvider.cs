using System.Collections.Generic;

namespace AspectCore.DependencyInjection
{
    /// <summary>
    /// �����ṩһ�����ص�����
    /// </summary>
    internal interface IServiceResolveCallbackProvider
    {
        /// <summary>
        /// �ṩһ�����ص�����
        /// </summary>
        IServiceResolveCallback[] ServiceResolveCallbacks { get; }
    }
}