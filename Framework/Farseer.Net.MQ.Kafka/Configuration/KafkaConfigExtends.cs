﻿using System.Collections.Generic;
using FS.MQ.Kafka.Configuration;

// ReSharper disable once CheckNamespace
namespace FS.Configuration
{
    /// <summary>
    /// Kafka配置
    /// </summary>
    public static class KafkaConfigExtends
    {
        /// <summary>
        /// 获取配置文件
        /// </summary>
        public static KafkaConfig KafkaConfig(this IConfigResolver resolver) => resolver.Get<KafkaConfig>() ?? new KafkaConfig { Items = new List<KafkaItemConfig>() };
    }
}
