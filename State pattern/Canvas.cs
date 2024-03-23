class Canvas
{
  private Tool? currentTool;

  public void setCurrentTool(Tool currentTool)
  {
    this.currentTool = currentTool;
  }

  public void mouseUp()
  {
    currentTool?.mouseUp();
  }
  public void mouseDown()
  {
    currentTool?.mouseDown();
  }   
}