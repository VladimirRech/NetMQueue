using System;
using System.Collections.Generic;
using System.Linq;
using System.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace NetMQueue.Classic.Queue
{
    // Getting started documentation: https://blog.jsinh.in/introduction-to-microsoft-message-queue-msmq/#.XS0gvxXPzDc
    public class BaseQueue
    {
        string _queueName;
        object _queueObject;

        public BaseQueue(string queueName)
        {
            _queueName = queueName;
        }

        public void Enqueue(object queueObject)
        {
            _queueObject = queueObject;
            MessageQueue mqueue = new MessageQueue(_queueName);
            mqueue.Send(_queueObject);
        }

        public object Dequeue()
        {
            return _queueObject;
        }
    }
}
