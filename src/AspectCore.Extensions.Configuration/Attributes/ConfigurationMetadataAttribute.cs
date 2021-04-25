using System;
using System.Linq;

namespace AspectCore.Extensions.Configuration
{
    /// <summary>
    /// ����Ԫ������Ϣ����
    /// </summary>
    public abstract class ConfigurationMetadataAttribute : Attribute, IConfigurationMetadataProvider
    {
        /// <summary>
        /// ���ý�
        /// </summary>
        public abstract string[] Sections { get; }

        /// <summary>
        /// ��
        /// </summary>
        public abstract string Key { get; }

        /// <summary>
        /// ���ð�����
        /// </summary>
        public abstract ConfigurationBindType Type { get; }

        /// <summary>
        /// ��ȡ�ַ�����ʾ�����ý�
        /// </summary>
        /// <returns>�ַ�����ʾ�����ý�</returns>
        public string GetSection()
        {
            if (Sections == null || Sections.Length == 0)
            {
                return null;
            }

            if (Sections.Length ==1)
            {
                return Sections[0];
            }

            return Sections.Aggregate((x, y) => x + ":" + y);
        }
    }
}