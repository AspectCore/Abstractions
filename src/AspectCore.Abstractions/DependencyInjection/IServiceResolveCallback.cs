using System;
using AspectCore.DynamicProxy;

namespace AspectCore.DependencyInjection
{
    [NonAspect, NonCallback]
    public interface IServiceResolveCallback
    {
        /// <summary>
        /// �ṩʵ���ķ���������ͷ�������������ʹ���ڷ�����ִ����ػص������߼�
        /// </summary>
        /// <param name="resolver">IServiceResolver</param>
        /// <param name="instance">ʵ��</param>
        /// <param name="service">ʵ���ķ�����������</param>
        /// <returns>�ص������Ľ��</returns>
        object Invoke(IServiceResolver resolver, object instance, ServiceDefinition service);
    }

    /// <summary>
    /// ��ע�����Դ���ִ�лص�����
    /// </summary>
    public sealed class NonCallback : Attribute
    {
    }
}