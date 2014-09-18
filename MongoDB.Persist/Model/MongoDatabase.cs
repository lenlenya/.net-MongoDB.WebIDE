﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MongoDB.Model
{
    /// <summary>
    /// 数据库信息
    /// </summary>
    public class MongoDatabase
    {
        /// <summary>
        /// 唯一值
        /// </summary>
        public Guid ID { get; set; }
        /// <summary>
        /// 数据库名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 总容量
        /// </summary>
        public long Size { get; set; }
        /// <summary>
        /// 全信息
        /// </summary>
        public string FullInfo { get { return string.Format("数据库：{0} | 总容量：{1}", Name, Size); } }
    }
}