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

		public Comment(int _comentID, int _memberID, string _content, DateTime _commentDate, int _postID, int _status)
		{
			_comentID = commentID;
			_memberID = memberID;
			_content = content;
			_commentDate = commentDate;
			_postID = postID;
			_status = status;

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
