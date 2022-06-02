using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mattermost.Bot.Exceptions
{
    public class FeatureDisabledException: Exception
    {
        public FeatureDisabledException(): base("Feature is disabled.") {}
    }
}