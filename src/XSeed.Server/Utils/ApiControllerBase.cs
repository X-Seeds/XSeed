using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace XSeed.Server.Utils
{
    public class ApiControllerBase : ControllerBase
    {
        /// <summary>
        /// 获取用户ID
        /// </summary>
        public long UserId
        {
            get
            {
                var claim = HttpContext.User.Claims.SingleOrDefault(p => p.Type == ClaimTypes.PrimarySid);
                return claim?.Value.ToLong() ?? 0;
            }
        }

        // <summary>
        /// 获取用户名
        /// </summary>
        public string Username
        {
            get
            {
                var claim = HttpContext.User.Claims.SingleOrDefault(p => p.Type == ClaimTypes.Name);
                return claim?.Value ?? "";
            }
        }

        /// <summary>
        /// 获取访问者的IP地址
        /// </summary>
        public string IpAddress
        {
            get
            {
                return HttpContext.Connection.RemoteIpAddress.ToString();
            }
        }
    }
}
