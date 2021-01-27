using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class Verification
    {
        public void PlayerControl(Gamer gamer, E_Devlet e_Devlet)
        {
            if (gamer.Name == e_Devlet.E_Devlet_Name)
            {
                Console.WriteLine("Players name is verified.");
            }
            else
            {
                Console.WriteLine("Name is not verified.");
            }

            if (gamer.Surname == e_Devlet.E_Devlet_Surname)
            {
                Console.WriteLine("Surname is verified.");
            }
            else
            {
                Console.WriteLine("Surname is NOT verified.");
            }

            if (gamer.TCNo == e_Devlet.E_Devlet_TCNo)
            {
                Console.WriteLine("TC No is verified.");
            }
            else
            {
                Console.WriteLine("TC No is NOT verified.");
            }

            if (gamer.BirthYear == e_Devlet.E_Devlet_BirthDay)
            {
                Console.WriteLine("Birthday is verified.");
            }
            else
            {
                Console.WriteLine("Birthday is NOT verified.");
            }

        }
    }
}
