using System;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            PostSubject post = new PostSubject("Post");
            post.Attach(new SubscriberObserver(post));
            post.AddComment("Comment 1");
            post.AddComment("Comment 2");
            post.Detach(0);
            post.AddComment("Comment 3 (No subscribers!)");            
        }
    }
}
