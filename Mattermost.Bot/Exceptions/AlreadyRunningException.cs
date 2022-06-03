using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mattermost.Bot.Exceptions
{
    public class AlreadyRunningException: Exception
    {
        public AlreadyRunningException(): base("Mattermost bot already running.") {}
    }
}