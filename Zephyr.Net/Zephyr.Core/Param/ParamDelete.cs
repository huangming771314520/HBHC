﻿/*************************************************************************
 * 文件名称 ：ParamDelete.cs                          
 * 描述说明 ：删除参数构建
 * 
 * 
 * 创建信息 : create by shiruizhi@qq.com on 2013 (施睿智)
 * 修订信息 : 
**************************************************************************/

using System;

namespace Zephyr.Core
{
    public class ParamDelete
    {
        protected ParamDeleteData data;

        public ParamDelete From(string sql)
        {
            data.From = sql;
            return this;
        }


        public ParamDelete AndWhere(string column, object value, Func<WhereData, string> cp = null, params object[] extend)
        {

            data.Where.Add(new ParamWhere() { Data = new WhereData() { AndOr = "and", Column = column, Value = value, Extend = extend }, Compare = cp ?? Cp.Equal });
            return this;
        }

        public ParamDelete OrWhere(string column, object value, Func<WhereData, string> cp = null, params object[] extend)
        {
            data.Where.Add(new ParamWhere() { Data = new WhereData() { AndOr = "or", Column = column, Value = value, Extend = extend }, Compare = cp ?? Cp.Equal });
            return this;
        }
  
        public ParamDelete()
        {
            data = new ParamDeleteData();
        }

        public static ParamDelete Instance()
        {
            return new ParamDelete();
        }

        public ParamDeleteData GetData()
        {
            return data;
        }
     }
}
