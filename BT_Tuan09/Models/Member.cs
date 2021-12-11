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

        public int Id { get => id; set => id = value; }
        public string UserName { get => userName; set => userName = value; }
        public string PassWord { get => passWord; set => passWord = value; }
        public DateTime DateOfBirth { get => dateOfBirth; set => dateOfBirth = value; }
        public string Email { get => email; set => email = value; }
        public string Gender { get => gender; set => gender = value; }
        public int TypeAccount { get => typeAccount; set => typeAccount = value; }

        public Member(int _id, string _username, string _pass, DateTime _dateofbirth, string _email, string _gender)
		{
			_id = Id;
			_username = UserName;
			_pass = PassWord;
			_dateofbirth = DateOfBirth;
			_email = Email;
			_gender = Gender;
		}

		public bool login(string username, string pass)
		{

		}
		public bool register(string userName, string passWord, DateTime dateOfBirth, string email, string gender, int typeAccount)
		{

		}
		public bool updateAccount(Member mem)
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
