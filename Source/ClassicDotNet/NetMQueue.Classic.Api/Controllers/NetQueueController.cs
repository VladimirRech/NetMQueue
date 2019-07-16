using NetMQueue.Classic.Queue;
using NetMQueue.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace NetMQueue.Classic.Api.Controllers
{
    public class NetQueueController : ApiController
    {
        [HttpPost]
        [Route("enqueue")]
        public string Enqueue(MSolicitation mSolicitation)
        {
            BaseQueue baseQueue = new BaseQueue(".\\QueueTest");
            baseQueue.Enqueue(mSolicitation);
            return "OK";
        }
    }
}
