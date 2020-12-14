using MadLibs.Models;
using Microsoft.AspNetCore.Mvc;

namespace MadLibs.Controllers
{
  public class HomeController : Controller
  {
    [Route("/")]
    public ActionResult Stories() { return View(); }

    [Route("/monkeyStory")]
    public ActionResult MonkeyStory() { return View(); }

    [Route("/monkeyStoryText")]
    public ActionResult MonkeyStoryText(string verb1, string noun1, string adverb1, string adjective1)
    {
      TextVariable monkeyTextVariable = new TextVariable();
      monkeyTextVariable.Verb1 = verb1;
      monkeyTextVariable.Noun1 = noun1;
      monkeyTextVariable.Adverb1 = adverb1;
      monkeyTextVariable.Adjective1 = adjective1;
      return View(monkeyTextVariable);
    }

    [Route("/inTheJungleStory")]
    public ActionResult InTheJungleStory() { return View(); }

    [Route("/inTheJungleStoryText")]
    public ActionResult InTheJungleStoryText(string verb1, string verb2, string verb3, string verb4, string noun1, string noun2, string noun3, string noun4, string adjective1, string adjective2, string adjective3, string adjective4, string adjective5, string adjective6, string adjective7)
    {
      TextVariable inTheJungleTextVariable = new TextVariable();
      inTheJungleTextVariable.Verb1 = verb1;
      inTheJungleTextVariable.Verb1 = verb2;
      inTheJungleTextVariable.Verb1 = verb3;
      inTheJungleTextVariable.Verb1 = verb4;
      inTheJungleTextVariable.Noun1 = noun1;
      inTheJungleTextVariable.Noun1 = noun2;
      inTheJungleTextVariable.Noun1 = noun3;
      inTheJungleTextVariable.Noun1 = noun4;
      inTheJungleTextVariable.Adjective1 = adjective1;
      inTheJungleTextVariable.Adjective1 = adjective2;
      inTheJungleTextVariable.Adjective1 = adjective3;
      inTheJungleTextVariable.Adjective1 = adjective4;
      inTheJungleTextVariable.Adjective1 = adjective5;
      inTheJungleTextVariable.Adjective1 = adjective6;
      inTheJungleTextVariable.Adjective1 = adjective7;
      return View(inTheJungleTextVariable);
    }

  }


}