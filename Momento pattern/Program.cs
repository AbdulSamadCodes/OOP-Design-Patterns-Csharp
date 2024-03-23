using System.Collections;
using System.Collections.Generic;

//Memento is a behavioral design pattern that lets you save and restore the previous state of an object without revealing the details of its implementation.

//Suppose we are making a text editor and we want to add undo feature in it.

class Editor
{
  private string content = "";
  public void SetContent(string content)
  {
    this.content = content;
  }
  public string GetContent()
  {
    return this.content;
  }

  public EditorState createState()
  {
    return new EditorState(this.content);
  }
  public void restore(EditorState state)
  {
    this.content = state.GetContent();
  }
}

class EditorState
{
  private string content;

  public EditorState(string content)
  {
    this.content = content;
  }  
  public string GetContent()
  {
    return this.content;
  }
}

class History
{
  Stack<EditorState> states = new Stack<EditorState>();
  public void pushState(EditorState state)
  {
    states.Push(state);
  }
  public EditorState popState()
  {
    return states.Pop();
  }
}

class Program
{
  public static void Main(string[] args)
  {
    Editor editor = new Editor();
    History history = new History();

    editor.SetContent("a");
    history.pushState(editor.createState());
    editor.SetContent("b");
    history.pushState(editor.createState());
    editor.SetContent("c");
 
    // Now we want to restore the previous state

    editor.restore(history.popState());
    Console.WriteLine(editor.GetContent());
  }
}


