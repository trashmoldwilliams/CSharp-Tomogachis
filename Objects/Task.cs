using System.Collections.Generic;
using System;

namespace TaskList
{
  public class Task
  {
    private string _taskDescription;
    private int _id;
    private string _picturePath;
    private bool _haveLivedThere;
    private static List<Task> _taskList = new List<Task> {};

    public Task(string taskDescription, string pic, bool livedThere)
    {
      _taskDescription = taskDescription;
      // _taskList.Add(this);
      _id = _taskList.Count;
      _picturePath = pic;
      _haveLivedThere = livedThere;
    }

    public string GetTaskDescription()
    {
      return _taskDescription;
    }

    public string GetTaskPicture()
    {
      return _picturePath;
    }

    public bool GetTaskRadioResult()
    {
      return _haveLivedThere;
    }

    public void SetTaskDescription(string anDescription)
    {
      _taskDescription = anDescription;
    }

    public int GetIdentification()
    {
      return _id;
    }

    public static List<Task> GetAllTasks()
    {
      return _taskList;
    }

    public static void ClearAllTasks()
    {
      _taskList.Clear();
    }
    public static Task FindById(int FindId)
    {
      return _taskList[FindId];
    }

    public void Save()
    {
      _taskList.Add(this);
    }
    public static void ClearList()
    {
      _taskList.Clear();
    }
  }
}
