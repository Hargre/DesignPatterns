namespace Observer
{
    public class SubscriberObserver : IObserver
    {
        private PostSubject _post;

        public SubscriberObserver(PostSubject post)
        {
            _post = post;
        }

        public void Update()
        {
            var comments = _post.GetCommentsState();
            System.Console.WriteLine("New comment in {0}!", _post.PostName);
            foreach (var comment in comments)
            {
                System.Console.WriteLine(comment);
            }
        }
    }
}