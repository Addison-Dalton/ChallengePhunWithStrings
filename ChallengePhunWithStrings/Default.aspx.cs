using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengePhunWithStrings
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // 1.  Reverse your name
            // In my case, the result would be:
            // notlaD nosiddA
            string name = "Addison Dalton";
            char[] nameArray = name.ToCharArray();
            Array.Reverse(nameArray);
            name = new string(nameArray);
            resultLabel.Text = name;
            //SECTION 1 END


            // 2.  Reverse this sequence:
            string names = "Luke,Leia,Han,Chewbacca";
            // When you're finished it should look like this:
            // Chewbacca,Han,Leia,Luke

            string[] namesArray = names.Split(',');
            Array.Reverse(namesArray);
            resultLabel.Text = string.Join(",", namesArray);
            //SECOND 2 END



            // 3. Use the sequence to create ascii art:
            // *****luke*****
            // *****leia*****
            // *****han******
            // **Chewbacca***

            int asciiArtLength = 14;
            string[] namesArrayArt = names.Split(',');

            for(int i =0; i < namesArrayArt.Length; i++)
            {
                string currentNameArt = namesArrayArt[i];
                int currentNameArtLength = currentNameArt.Length;
                int lengthDiff = asciiArtLength - currentNameArtLength;
                
                currentNameArt = currentNameArt.PadLeft(currentNameArtLength + (lengthDiff / 2), '*').PadRight(currentNameArtLength + lengthDiff, '*');
                namesArrayArt[i] = currentNameArt;
            }

            resultLabel.Text = string.Join("<br />",namesArrayArt);
            //SECTION 3 END



            // 4. Solve this puzzle:
            // Once you fix it with string helper methods, it should read:
            // Now is the time for all good men to come to the aid of their country.

            string puzzle = "NOW IS ZHEremove-me ZIME FOR ALL GOOD MEN ZO COME ZO ZHE AID OF ZHEIR COUNZRY.";

            //change all 'z' to 't'
            //lowercase, then set first letter to upper
            puzzle = puzzle.Remove(puzzle.IndexOf("remove-me"), "remove-me".Length);
            puzzle = puzzle.ToLower();
            puzzle = puzzle.Replace('z', 't');
            puzzle = puzzle.Substring(0, 1).ToUpper() + puzzle.Substring(1);

            resultLabel.Text = puzzle;
        }
    }
}