using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace macdoc
{
    public class User
    {


        string name;
        string lastName;
        string id;
        string role;
        string phoneNumber;
        string passWord;



        public User(string name,string lastName , string phone)
        {
            this.name = name;
            this.lastName = lastName;
            this.phoneNumber = phone;
        
        }

        public string Name
        { get { return name; } set {  name = value; } }
        public string LastName { get { return lastName; } set {  lastName = value; } }
        public string Id { get { return id; } set {  id = value; } }
        public string Role { get { return role; } set {  role = value; } }
        public string PhoneNumber { get {  return phoneNumber; } set {  phoneNumber = value; } }
        public string PassWord { get {  return passWord; } set {  passWord = value; } }




    }
}
