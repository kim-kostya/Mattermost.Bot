using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mattermost.Bot.Exceptions
{
    public class NotFoundException: Exception
    {
        public NotFoundException(string name): base($"{name} not found.") {}
    }
}