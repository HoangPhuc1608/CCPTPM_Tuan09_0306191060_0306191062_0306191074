using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BT_Tuan09.Models
{
    public class Member
    {
		private int id;
		private string userName;
		private string passWord;
		private DateTime dateOfBirth;
		private string email;
		private string gender;
		private int typeAccount;

		public Member(int _id, string _username, string _pass, DateTime _dateofbirth, string _email, string _gender)
		{
			_id = id;
			_username = userName;
			_pass = passWord;
			_dateofbirth = dateOfBirth;
			_email = email;
			_gender = gender;
		}

		public bool login(string username, string pass)
		{

		}
		public bool register()
		{

		}
		public bool updateAccount()
		{

		}
		public bool changePassword(string oldPass, string newPass)
		{

		}
		public bool blockAccount(int memID)
		{

		}
	}
}
