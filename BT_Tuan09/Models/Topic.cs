using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BT_Tuan09.Models
{
    public class Topic
    {
        private int idTopic;
        private string nameTopic;
        private string typeTopic;

        public int IdTopic { get => idTopic; set => idTopic = value; }
        public string NameTopic { get => nameTopic; set => nameTopic = value; }
        public string TypeTopic { get => typeTopic; set => typeTopic = value; }

        public Topic(int idTopic, string nameTopic, string typeTopic)
        {
            this.IdTopic = idTopic;
            this.NameTopic = nameTopic;
            this.TypeTopic = typeTopic;
        }

        public static List<Topic> searchTopic(string nameTopic)
        {
        }

        public static bool createTopic()
        {

        }

        public static bool updateTopic(Topic topic)
        {
        }

        public static bool deleteTopic(int topicId)
        {
        }
    }
}
