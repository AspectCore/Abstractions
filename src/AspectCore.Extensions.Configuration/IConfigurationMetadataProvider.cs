namespace AspectCore.Extensions.Configuration
{
    /// <summary>
    /// �ṩ���ð󶨵�Ԫ������Ϣ
    /// </summary>
    public interface IConfigurationMetadataProvider
    {
        /// <summary>
        /// �󶨵����ý�
        /// </summary>
        string[] Sections { get; }
        
        /// <summary>
        /// ����ֵ���͵İ󶨿���
        /// </summary>
        string Key { get; }
        
        /// <summary>
        /// ���ð�����
        /// </summary>
        ConfigurationBindType Type { get; }
    }
}