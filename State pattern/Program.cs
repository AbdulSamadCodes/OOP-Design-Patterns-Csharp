//The State Pattern is a behavioral design pattern that allows an object to change its behavior when its internal state changes.

class Program
{
  public static void Main(string[] args)
  {
    Canvas canvas = new Canvas();
    canvas.setCurrentTool(new Brush());
    canvas.mouseDown();
    canvas.mouseUp();

    canvas.setCurrentTool(new Selection());
    canvas.mouseDown();
    canvas.mouseUp();
  }
}


