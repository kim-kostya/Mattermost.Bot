namespace Mattermost.Bot {
    public class Handlers {
        #region Post Handlers
        public delegate void PostHandler(Post post);

        public delegate void PostEditedHandler(Post post, User editor);

        public delegate void PostRemovedHandler(Post post, User remover);
        #endregion
    }
}