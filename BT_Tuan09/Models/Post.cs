using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BT_Tuan09.Models
{
    public class Post
    {
        private static int postId;
        private static string title;
        private static string image;
        private static string content;
        private static string typeTopic;
        private static int status;

        public static int PostId { get => postId; set => postId = value; }
        public static string Title { get => title; set => title = value; }
        public static string Image { get => image; set => image = value; }
        public static string Content { get => content; set => content = value; }
        public static string TypeTopic { get => typeTopic; set => typeTopic = value; }
        public static int Status { get => status; set => status = value; }

        public Post(int _id, string _title, string _image, string _content, string _typeTopic, int _status)
        {
            postId = _id;
            title = _title;
            image = _image;
            content = _content;
            typeTopic = _typeTopic;
            status = _status;
        }

        public static List<Post> searchPost(string title)
        {
        }

        public static void createPost()
        {

        }

        public static bool updatePost(Post post)
        {
        }

        public static bool deletePost(int postId)
        {
        }
    }
}
