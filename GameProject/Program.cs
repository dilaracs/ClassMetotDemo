using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer1 = new Gamer();
            gamer1.Name = "Doruk";
            gamer1.Surname = "Karadeniz";
            gamer1.TCNo = "12548796";
            gamer1.BirthYear = "22.08.1998";

            Gamer gamer2 = new Gamer();
            gamer2.Name = "Demir";
            gamer2.Surname = "Karadeniz";
            gamer2.TCNo = "98746523";
            gamer2.BirthYear = "11.06.1997";

            E_Devlet eDevletPlayerInformation1 = new E_Devlet();
            eDevletPlayerInformation1.E_Devlet_Name = "Doruk";
            eDevletPlayerInformation1.E_Devlet_Surname = "Karadeniz";
            eDevletPlayerInformation1.E_Devlet_TCNo = "12548796";
            eDevletPlayerInformation1.E_Devlet_BirthDay = "22.08.1998";

            Game game1 = new Game();
            game1.GameName = "Sniper";
            game1.GamePrice = 156;

            Game game2 = new Game();
            game2.GameName = "CS-GO";
            game2.GamePrice = 64;

            Game game3 = new Game();
            game3.GameName = "LOL";
            game3.GamePrice = 260;

            Game game4 = new Game();
            game4.GameName = "PUBG";
            game4.GamePrice = 500;

            Verification verification = new Verification();
            verification.PlayerControl(gamer1, eDevletPlayerInformation1);

            Console.WriteLine("------------------------------");

            ICampaign campaignManager = new CampaignManager();
            campaignManager.CampaignEntry(game1);
            campaignManager.DeleteCampaign(game1);
            campaignManager.UpdateCampaign(game1);

            Console.WriteLine("----------------------------");

            IGamer playerManager = new GamerManager();
            playerManager.NewPlayer(gamer1);
            playerManager.DeletePlayer(gamer1);
            playerManager.UpdatePlayer(gamer1);

            Console.WriteLine("-------------------------------");

            GameManager gameSaleManager = new GameManager();
            gameSaleManager.GameSale(gamer1, game2);

            Console.WriteLine("------------------------------");

            Console.ReadLine();
        }
    }
}
