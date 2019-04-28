using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AspNetMVCDemo.Controllers
{
    public class MessagesController : ApiController
    {
        List<string> messages = new List<string>() { "First", "Second", "Third" };

        public List<String> Get()
        {
            return messages;
        }

        public string Get(int id)
        {
            if (id < messages.Count)
                return messages[id];
            else
                throw new HttpResponseException(HttpStatusCode.NotFound);
        }

    }
}
