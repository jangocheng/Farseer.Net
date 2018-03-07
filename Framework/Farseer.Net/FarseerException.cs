﻿using System;
using System.Runtime.Serialization;

namespace Farseer.Net
{
    /// <summary>
    /// 系统异常基类
    /// </summary>
    [Serializable]
    public class FarseerException : System.Exception
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        public FarseerException() { }
#if !CORE
		/// <summary>
		/// 构造函数
		/// </summary>
		public FarseerException(SerializationInfo serializationInfo, StreamingContext context) : base(serializationInfo, context) { }
#endif
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="message">异常消息</param>
        public FarseerException(string message) : base(message) { }

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="message">异常消息</param>
        /// <param name="innerException">异常堆栈</param>
        public FarseerException(string message, Exception innerException) : base(message, innerException) { }

        /// <summary>
        /// 实体化FarseerException
        /// </summary>
        public static FarseerException Instance(string message) => new FarseerException(message);
    }
}