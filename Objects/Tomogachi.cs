using System.Collections.Generic;
using System;

namespace VirtualPets
{
  public class Tomogachi
  {
    private int _food;
    private int _rest;
    private int _play;
    private int _id;
    private bool _isdead;
    private static List<Tomogachi> _petList = new List<Tomogachi> {};

    public Tomogachi(int food = 10, int rest = 10, int play = 10)
    {
      _food = food;
      _rest = rest;
      _play = play;
      _id = _petList.Count;
      _isdead = false;
    }

    public int GetFood()
    {
      return _food;
    }

    public int GetRest()
    {
      return _rest;
    }

    public int GetPlay()
    {
      return _play;
    }

    public void setDead()
    {
      _isdead=true;
    }

    public void SetFood(int newFood)
    {
      _food += newFood;
    }

    public void SetRest(int newRest)
    {
      _rest += newRest;
    }

    public void SetPlay(int newPlay)
    {
      _play += newPlay;
    }

    public static void DecayValues()
    {
      foreach (Tomogachi tomo in _petList) {
        tomo.SetFood(-1);
        tomo.SetRest(-1);
        tomo.SetPlay(-1);
      }
    }

    // public static void CheckForDead()
    // {
    //   foreach (Tomogachi tomo in _petList) {
    //     if (tomo.GetFood() == 0 || tomo.GetRest() == 0 || tomo.GetPlay() == 0) {
    //       tomo.setDead();
    //     }
    //   }
    // }
    //
    // public static void DisposeOfDead()
    // {
    //   foreach (Tomogachi tomo in _petList)
    //     {
    //       if (tomo.isDead()) {
    //         tomo.GetIdentification()
    //       }
    //     }
    // }

    // public void SetFood(int id)
    // {
    //   _petList[id]._food++;
    // }

    public int GetIdentification()
    {
      return _id;
    }

    public static List<Tomogachi> GetAllTomogachis()
    {
      return _petList;
    }

    public static void ClearAllTomogachis()
    {
      _petList.Clear();
    }
    public static Tomogachi FindById(int FindId)
    {
      return _petList[FindId];
    }

    public void Save()
    {
      _petList.Add(this);
    }
  }
}
