using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetMQueue.Model
{
    public class MSolicitation
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime DateTimeStart { get; set; }
        public DateTime DateTimeEnd { get; set; }
        public string MeetingTopics { get; set; }
        public int NumberOfPeople { get; set; }
        public string OwnerName { get; set; }
        public string OwnerEmail { get; set; }
    }
}
