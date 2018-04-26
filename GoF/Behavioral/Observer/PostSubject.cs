using System.Collections.Generic;

namespace Observer
{
    public class PostSubject : Subject
    {
        public string PostName { get; private set; }
        public List<string> Comments { get; set; }

        public PostSubject(string name) : base()
        {
            PostName = name;
            Comments = new List<string>();
        }

        public void AddComment(string comment)
        {
            Comments.Add(comment);
            Notify();
        }

        public List<string> GetCommentsState()
        {
            return Comments;
        }
    }
}