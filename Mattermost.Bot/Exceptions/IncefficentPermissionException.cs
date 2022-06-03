using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mattermost.Bot.Exceptions
{
    public class IncefficentPermissionException: Exception
    {
        public IncefficentPermissionException(): base("Incefficent permission") {}
    }
}