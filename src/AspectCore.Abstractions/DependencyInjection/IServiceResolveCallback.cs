using System;
using AspectCore.DynamicProxy;

namespace AspectCore.DependencyInjection
{
    /// <summary>
    /// ��������ص��ӿ�
    /// </summary>
    [NonAspect, NonCallback]
    public interface IServiceResolveCallback
    {
        /// <summary>
        /// �ṩinstanceʵ���ķ���������ͷ�������������ʹ���ڷ�����ִ����ػص������߼�
        /// </summary>
        /// <param name="resolver">instanceʵ���ķ��������</param>
        /// <param name="instance">ʵ��</param>
        /// <param name="service">instanceʵ���ķ�����������</param>
        /// <returns>�ص����������Ľ������</returns>
        object Invoke(IServiceResolver resolver, object instance, ServiceDefinition service);
    }

    /// <summary>
    /// ��ע�����Դ���ִ�лص�����
    /// </summary>
    public sealed class NonCallback : Attribute
    {
    }
}