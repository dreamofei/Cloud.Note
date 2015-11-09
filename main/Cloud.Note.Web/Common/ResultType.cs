using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Cloud.Note.Web.Common
{
    public enum ResultType
    {
        //报错
        Error=0,
        //请求成功，但没得到期望的数据。如：无查询结果
        Failure=1,
        //成功，并返回期望结果
        Success=2
    }
}