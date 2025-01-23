using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class PushNotificationService : INotificationService
    {
        public string SendNotification(string recipient, string message)
        {
            return $"{message} >>> Already sent to {recipient} as Push";
        }
    }
}
