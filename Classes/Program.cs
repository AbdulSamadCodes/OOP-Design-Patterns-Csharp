using System;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
class Program
{   //Making a basic class user
    class User
    {
        //Fields
        public string username;
        public int age;
        
        //Making a constructor
        public User(string username , int age)
        {
          this.username = username;
          this.age = age;
        }
    }

   public static void Main(string [] args)
   {
      //Making a instance of the class
      User samad = new User("Abdul Samad" , 20);
      Console.WriteLine(samad.username);
      Console.WriteLine(samad.age);

   }
}
