using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BT_Tuan09.Models
{
    public class Comment
    {
		private int commentID;
		private int memberID;
		private string content;
		private DateTime commentDate;
		private int postID;
		private int status;

        public int CommentID { get => commentID; set => commentID = value; }
        public int MemberID { get => memberID; set => memberID = value; }
        public string Content { get => content; set => content = value; }
        public DateTime CommentDate { get => commentDate; set => commentDate = value; }
        public int PostID { get => postID; set => postID = value; }
        public int Status { get => status; set => status = value; }

        public Comment(int _comentID, int _memberID, string _content, DateTime _commentDate, int _postID, int _status)
		{
			_comentID = CommentID;
			_memberID = MemberID;
			_content = Content;
			_commentDate = CommentDate;
			_postID = PostID;
			_status = Status;

		}

        public Comment(int commentID)
        {
            this.commentID = commentID;
        }

        public bool createComment()
		{

		}
		public bool updateComment(Comment cmt)
		{

		}
		public bool deleteComment(int id)
		{

		}
	}
}
