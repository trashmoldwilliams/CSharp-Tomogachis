using Nancy;
using System.Collections.Generic;
using VirtualPets;
using System;

namespace Pets
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {

      Post["/add_pets"] = _ => {
        Tomogachi newTomogachi = new Tomogachi();
        newTomogachi.Save();
        List<Tomogachi> theTomogachis = Tomogachi.GetAllTomogachis();
        return View["viewpets.cshtml", theTomogachis];
      };

      Get["/"] = _ => {
        List<Tomogachi> theTomos = Tomogachi.GetAllTomogachis();
        return View["viewpets.cshtml", theTomos];
      };


      Post["/pets_cleared"] = _ => {
        Tomogachi.ClearAllTomogachis();
        List<Tomogachi> theTomos = Tomogachi.GetAllTomogachis();
        return View["viewpets.cshtml", theTomos];
      };

      Get["/view_tasks/{id}"] = parameters => {
        Tomogachi tomo = Tomogachi.FindById(parameters.id);
        return View["aSingleTask.cshtml", tomo];
      };

      Post["/decayPetValues"] = _ => {
        Tomogachi.DecayValues();
        // Tomogachi.CheckForDead();
        List<Tomogachi> theTomos = Tomogachi.GetAllTomogachis();
        return View["viewpets.cshtml", theTomos];
      };
    }
  }
}
