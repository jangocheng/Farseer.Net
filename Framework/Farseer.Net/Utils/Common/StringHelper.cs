﻿// ********************************************
// 作者：何达贤（steden） QQ：11042427
// 时间：2017-08-17 11:02
// ********************************************

using System;
using System.Collections.Generic;

namespace FS.Utils.Common
{
    public class StringHelper
    {
        /// <summary>
        ///     将字符串转换成List型
        /// </summary>
        /// <param name="str">要转换的字符串</param>
        /// <param name="splitString">分隔符为NullOrEmpty时，则直接拆份为Char</param>
        /// <param name="defValue">默认值(单项转换失败时，默认值为NullOrEmpty时，则不添加，否则替换为默认值)</param>
        /// <typeparam name="T">基本类型</typeparam>
        public static List<T> ToList<T>(string str, T defValue = default(T), string splitString = ",")
        {
            if (string.IsNullOrWhiteSpace(str)) { return new List<T>(); }
            var returnType = typeof(T);
            var returnTypeCode = Type.GetTypeCode(returnType);
            string[] strArray;
            //判断是否带分隔符，如果没有。则直接拆份单个Char
            if (string.IsNullOrWhiteSpace(splitString))
            {
                strArray = new string[str.Length];
                for (var i = 0; i < str.Length; i++) { strArray[i] = str.Substring(i, 1); }
            }
            else
            {
                strArray = splitString.Length == 1 ? str.Split(splitString[0]) : str.Split(new[] { splitString }, StringSplitOptions.None);
            }
            var lst = new List<T>(strArray.Length);
            foreach (var item in strArray)
            {
                var val = ConvertHelper.ConvertSimple(item, item, returnType, returnTypeCode);
                lst.Add(val == null ? defValue : (T)val);
            }
            return lst;
        }

        /// <summary>
        ///     比较两者是否相等，不考虑大小写,两边空格
        /// </summary>
        /// <param name="str">对比一</param>
        /// <param name="str2">对比二</param>
        /// <returns></returns>
        public static bool IsEquals(string str, string str2)
        {
            if (str == str2) { return true; }
            if (str == null || str2 == null) { return false; }
            if (str.Trim().Length != str2.Trim().Length) { return false; }
            return String.Compare(str.Trim(), str2.Trim(), StringComparison.OrdinalIgnoreCase) == 0;
        }
    }
}