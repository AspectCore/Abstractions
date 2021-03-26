namespace AspectCore.DependencyInjection
{
    /// <summary>
    /// ��ȡ�����Զ����������ע��
    /// </summary>
    public class PropertyInjectorCallback : IServiceResolveCallback
    {
        /// <summary>
        /// ��ȡ�����Զ����������ע��
        /// </summary>
        /// <param name="resolver">�������</param>
        /// <param name="instance">������Ķ���</param>
        /// <param name="service">��������</param>
        /// <returns></returns>
        public object Invoke(IServiceResolver resolver, object instance, ServiceDefinition service)
        {
            if (instance == null || !service.RequiredPropertyInjection())
            {
                return instance;
            }
            var injectorFactory = resolver.Resolve<IPropertyInjectorFactory>();
            var injector = injectorFactory.Create(instance.GetType());
            injector.Invoke(instance);
            return instance;
        }
    }
}