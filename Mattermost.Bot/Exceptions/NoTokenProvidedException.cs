namespace Mattermost.Bot.Exceptions
{
    public class NoTokenProvidedException: NullReferenceException
    {
        public NoTokenProvidedException(): base("No token provided") {}
    }
}