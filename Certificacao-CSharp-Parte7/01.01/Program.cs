using System;

namespace _01_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Campainha campainha = new Campainha();
            campainha.OnCampainhaTocou += CampainhaTocou;
            campainha.OnCampainhaTocou += CampainhaTocou2;

            Console.WriteLine("A campaninha será tocada.");
            campainha.Tocar();

            campainha.OnCampainhaTocou -= CampainhaTocou;
            Console.WriteLine("A campaninha será tocada.");
            campainha.Tocar();

            Console.ReadKey();

        }

        static void CampainhaTocou()
        {
            Console.WriteLine("A campaninha tocou. (1)");
        }

        static void CampainhaTocou2()
        {
            Console.WriteLine("A campaninha tocou. (2)");
        }
    }

    class Campainha
    {
        public Action OnCampainhaTocou { get; set; }

        public void Tocar()
        {
            if (OnCampainhaTocou != null)
            {
                OnCampainhaTocou();
            }
            
        }
    }
}
