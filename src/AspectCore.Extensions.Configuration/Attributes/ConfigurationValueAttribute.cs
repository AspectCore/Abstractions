using System;

namespace AspectCore.Extensions.Configuration
{
    /// <summary>
    /// ����ֵ�󶨵����ð�����
    /// </summary>
    public class ConfigurationValueAttribute : ConfigurationMetadataAttribute
    {
        /// <summary>
        /// ��
        /// </summary>
        public override string Key { get; }

        /// <summary>
        /// ���ð�����
        /// </summary>
        public override ConfigurationBindType Type { get; } = ConfigurationBindType.Value;

        /// <summary>
        /// ���ý�
        /// </summary>
        public override string[] Sections { get; }

        /// <summary>
        /// ����ֵ�󶨵����ð�����
        /// </summary>
        /// <param name="key">��</param>
        /// <param name="sections">���ý�</param>
        public ConfigurationValueAttribute(string key, params string[] sections)
        {
            Key = key;
            Sections = sections;
        }
    }
}