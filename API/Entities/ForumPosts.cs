using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Entities
{
    public class ForumPosts
    {
        public int Id { get; set; }
        public string postMessage {get; set;}
        public string User {get; set;}
    }
}