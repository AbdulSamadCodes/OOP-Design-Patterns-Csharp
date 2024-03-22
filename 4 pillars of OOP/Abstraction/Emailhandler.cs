//Abstraction is the process of hiding unnecessarry details from the user and simplifying the implementation details for user.

//For example,user wants to sigin to our app by sending his email.He will only call signIn method and rest of the details will be hidden from him
class Emailhandler
{
  public void signIn()
  {
    connect();
    fetchingData();
    Console.WriteLine("You are signed in");
  }

  private void connect()
  {
    Console.WriteLine("Connnecting email");
  } 

  private  void fetchingData()
  {
    Console.WriteLine("Fetching data from database");
  } 

  public static void Main(string[] args)
  {
    Emailhandler userEmail = new Emailhandler();
    userEmail.signIn();         
  }
}