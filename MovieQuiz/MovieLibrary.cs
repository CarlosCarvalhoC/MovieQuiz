using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace MovieQuiz
{
    public static class MovieLibrary
    {
        public static Dictionary<string, Dictionary<string, List<Image>>> Categories =
          new Dictionary<string, Dictionary<string, List<Image>>>()
          {
              {
                  "Action", new Dictionary<string, List<Image>>
                  {
                      { "Avengers - Endgame", new List<Image> { Properties.Resources.AvengersEndgame1, Properties.Resources.AvengersEndgame2, Properties.Resources.AvengersEndgame3, Properties.Resources.AvengersEndgame4 } },
                      { "Casino Royale", new List<Image> { Properties.Resources.CasinoRoyale1, Properties.Resources.CasinoRoyale2, Properties.Resources.CasinoRoyale3, Properties.Resources.CasinoRoyale4 } },
                      { "Die Hard", new List<Image> { Properties.Resources.DieHard1, Properties.Resources.DieHard2, Properties.Resources.DieHard3, Properties.Resources.DieHard4 } },
                      { "Gladiator", new List<Image> { Properties.Resources.Gladiator1, Properties.Resources.Gladiator2, Properties.Resources.Gladiator3, Properties.Resources.Gladiator4 } },
                      { "Mad Max - Fury Road", new List<Image> { Properties.Resources.MadMaxFuryRoad1, Properties.Resources.MadMaxFuryRoad2, Properties.Resources.MadMaxFuryRoad3, Properties.Resources.MadMaxFuryRoad4 } },
                      { "The Dark Knight", new List<Image> { Properties.Resources.TheDarkKnight1, Properties.Resources.TheDarkKnight2, Properties.Resources.TheDarkKnight3, Properties.Resources.TheDarkKnight4 } },
                      { "John Wick", new List<Image> { Properties.Resources.JohnWick1, Properties.Resources.JohnWick2, Properties.Resources.JohnWick3, Properties.Resources.JohnWick4 } },
                      { "Mission Impossible", new List<Image> { Properties.Resources.Impossible1, Properties.Resources.Impossible2, Properties.Resources.Impossible3, Properties.Resources.Impossible4 } },
                      { "Kick-Ass", new List<Image> { Properties.Resources.KickAss1, Properties.Resources.KickAss2, Properties.Resources.KickAss3, Properties.Resources.KickAss4 } },
                      { "Scott Pilgrim VS The World", new List<Image> { Properties.Resources.Pilgrim1, Properties.Resources.Pilgrim2, Properties.Resources.Pilgrim3, Properties.Resources.Pilgrim4 } }
                  }
              },
              {
                  "Animation", new Dictionary<string, List<Image>>
                  {
                      { "Coco", new List<Image> { Properties.Resources.Coco1, Properties.Resources.Coco2, Properties.Resources.Coco3, Properties.Resources.Coco4 } },
                      { "Encanto", new List<Image> { Properties.Resources.Encanto1, Properties.Resources.Encanto2, Properties.Resources.Encanto3, Properties.Resources.Encanto4 } },
                      { "Hotel Transylvania", new List<Image> { Properties.Resources.Hotel1, Properties.Resources.Hotel2, Properties.Resources.Hotel3, Properties.Resources.Hotel4 } },
                      { "Kubo and the Two Strings", new List<Image> { Properties.Resources.Kubo1, Properties.Resources.Kubo2, Properties.Resources.Kubo3, Properties.Resources.Kubo4 } },
                      { "My Neighbour Totoro", new List<Image> { Properties.Resources.Totoro1, Properties.Resources.Totoro2, Properties.Resources.Totoro3, Properties.Resources.Totoro4 } },
                      { "The Corpse Bride", new List<Image> { Properties.Resources.Corpse1, Properties.Resources.Corpse2, Properties.Resources.Corpse3, Properties.Resources.Corpse4 } },
                      { "The Nightmare Before Christmas", new List<Image> { Properties.Resources.Christmas1, Properties.Resources.Christmas2, Properties.Resources.Christmas3, Properties.Resources.Christmas4 } },
                      { "The Wind Rises", new List<Image> { Properties.Resources.Wind1, Properties.Resources.Wind2, Properties.Resources.Wind3, Properties.Resources.Wind4 } },
                      { "Up", new List<Image> { Properties.Resources.Up1, Properties.Resources.Up2, Properties.Resources.Up3, Properties.Resources.Up4 } },
                      { "Wall-E", new List<Image> { Properties.Resources.Wall_E1, Properties.Resources.Wall_E2, Properties.Resources.Wall_E3, Properties.Resources.Wall_E4 } }
                  }
              },
              {
                  "Fantasy", new Dictionary<string, List<Image>>
                  {
                      { "Alice in Wonderland", new List<Image> { Properties.Resources.Alice1, Properties.Resources.Alice2, Properties.Resources.Alice3, Properties.Resources.Alice4 } },
                      { "Harry Potter and the Sorcerer's Stone", new List<Image> { Properties.Resources.Potter1, Properties.Resources.Potter2, Properties.Resources.Potter3, Properties.Resources.Potter4 } },
                      { "Hocus Pocus", new List<Image> { Properties.Resources.HocusPocus1, Properties.Resources.HocusPocus2, Properties.Resources.HocusPocus3, Properties.Resources.HocusPocus4 } },
                      { "Maleficent", new List<Image> { Properties.Resources.Maleficent1, Properties.Resources.Maleficent2, Properties.Resources.Maleficent3, Properties.Resources.Maleficent4 } },
                      { "Pan's Labyrinth", new List<Image> { Properties.Resources.Pan1, Properties.Resources.Pan2, Properties.Resources.Pan3, Properties.Resources.Pan4 } },
                      { "Percy Jackson", new List<Image> { Properties.Resources.Percy1, Properties.Resources.Percy2, Properties.Resources.Percy3, Properties.Resources.Percy4 } },
                      { "The Chronicles of Narnia - The Lion, the Witch and the Wardrobe", new List<Image> { Properties.Resources.Narnia1, Properties.Resources.Narnia2, Properties.Resources.Narnia3, Properties.Resources.Narnia4 } },
                      { "The Golden Compass", new List<Image> { Properties.Resources.Compass1, Properties.Resources.Compass2, Properties.Resources.Compass3, Properties.Resources.Compass4 } },
                      { "The Lord of the Rings", new List<Image> { Properties.Resources.Rings1, Properties.Resources.Rings2, Properties.Resources.Rings3, Properties.Resources.Rings4 } },
                      { "The Princess Bride", new List<Image> { Properties.Resources.Bride1, Properties.Resources.Bride2, Properties.Resources.Bride3, Properties.Resources.Bride4 } }
                  }
              },
              {
                  "Horror", new Dictionary<string, List<Image>>
                  {
                      { "A Nightmare on Elm Street", new List<Image> { Properties.Resources.Nightmare1, Properties.Resources.Nightmare2, Properties.Resources.Nightmare3, Properties.Resources.Nightmare4 } },
                      { "Get Out", new List<Image> { Properties.Resources.GetOut1, Properties.Resources.GetOut2, Properties.Resources.GetOut3, Properties.Resources.GetOut4 } },
                      { "Halloween", new List<Image> { Properties.Resources.Halloween1, Properties.Resources.Halloween2, Properties.Resources.Halloween3, Properties.Resources.Halloween4 } },
                      { "Hereditary", new List<Image> { Properties.Resources.Hereditary1, Properties.Resources.Hereditary2, Properties.Resources.Hereditary3, Properties.Resources.Hereditary4} },
                      { "It", new List<Image> { Properties.Resources.It1, Properties.Resources.It2, Properties.Resources.It3, Properties.Resources.It4 } },
                      { "Paranormal Activity", new List<Image> { Properties.Resources.Paranormal1, Properties.Resources.Paranormal2, Properties.Resources.Paranormal3, Properties.Resources.Paranormal4 } },
                      { "Scream", new List<Image> { Properties.Resources.Scream1, Properties.Resources.Scream2, Properties.Resources.Scream3, Properties.Resources.Scream4 } },
                      { "The Conjuring", new List<Image> { Properties.Resources.Conjuring1, Properties.Resources.Conjuring2, Properties.Resources.Conjuring3, Properties.Resources.Conjuring4 } },
                      { "The Exorcist", new List<Image> { Properties.Resources.Exorcist1, Properties.Resources.Exorcist2, Properties.Resources.Exorcist3, Properties.Resources.Exorcist4 } },
                      { "The Shining", new List<Image> { Properties.Resources.Shining1, Properties.Resources.Shining2, Properties.Resources.Shining3, Properties.Resources.Shining4 } }
                  }
              },
              {
                  "Sci Fi", new Dictionary<string, List<Image>>
                  {
                      { "Arrival", new List<Image> { Properties.Resources.Arrival1, Properties.Resources.Arrival2, Properties.Resources.Arrival3, Properties.Resources.Arrival4 } },
                      { "Avatar", new List<Image> { Properties.Resources.Avatar1, Properties.Resources.Avatar2, Properties.Resources.Avatar3, Properties.Resources.Avatar4 } },
                      { "Blade Runner 2049", new List<Image> { Properties.Resources.BladeRunnerTwo1, Properties.Resources.BladeRunnerTwo2, Properties.Resources.BladeRunnerTwo3, Properties.Resources.BladeRunnerTwo4 } },
                      { "Dune", new List<Image> { Properties.Resources.Dune1, Properties.Resources.Dune2, Properties.Resources.Dune3, Properties.Resources.Dune4 } },
                      { "Ex Machina", new List<Image> { Properties.Resources.ExMachina1, Properties.Resources.ExMachina2, Properties.Resources.ExMachina3, Properties.Resources.ExMachina4 } },
                      { "Interstellar", new List<Image> { Properties.Resources.Interstellar1, Properties.Resources.Interstellar2, Properties.Resources.Interstellar3, Properties.Resources.Interstellar4 } },
                      { "Jurassic Park", new List<Image> { Properties.Resources.JurassicPark1, Properties.Resources.JurassicPark2, Properties.Resources.JurassicPark3, Properties.Resources.JurassicPark4 } },
                      { "Star Wars - A New Hope", new List<Image> { Properties.Resources.StarWars1, Properties.Resources.StarWars2, Properties.Resources.StarWars3, Properties.Resources.StarWars4 } },
                      { "The Martian", new List<Image> { Properties.Resources.Martian1, Properties.Resources.Martian2, Properties.Resources.Martian3, Properties.Resources.Martian4 } },
                      { "The Matrix", new List<Image> { Properties.Resources.Matrix1, Properties.Resources.Matrix2, Properties.Resources.Matrix3, Properties.Resources.Matrix4 } }
                      
                   }
               },
              {
                  "Shrek", new Dictionary<string, List<Image>>
                 {
                    { "Puss in Boots", new List<Image> { Properties.Resources.Puss1, Properties.Resources.Puss2, Properties.Resources.Puss3, Properties.Resources.Puss4 } },
                    { "Puss in Boots - The Last Wish", new List<Image> { Properties.Resources.PussTwo1, Properties.Resources.PussTwo2, Properties.Resources.PussTwo3, Properties.Resources.PussTwo4 } },
                    { "Shrek", new List<Image> { Properties.Resources.Shrek1, Properties.Resources.Shrek2, Properties.Resources.Shrek3, Properties.Resources.Shrek4 } },
                    { "Shrek 2", new List<Image> { Properties.Resources.ShrekTwo1, Properties.Resources.ShrekTwo2, Properties.Resources.ShrekTwo3, Properties.Resources.ShrekTwo4 } },
                    { "Shrek the Third", new List<Image> { Properties.Resources.ShrekThree1, Properties.Resources.ShrekThree2, Properties.Resources.ShrekThree3, Properties.Resources.ShrekThree4 } },
                    { "Shrek Forever After", new List<Image> { Properties.Resources.ShrekFour1, Properties.Resources.ShrekFour2, Properties.Resources.ShrekFour3, Properties.Resources.ShrekFour4 } }
    }
}


    };
    }
}