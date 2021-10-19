using System;
namespace modul6opg3.Client.Shared
{
    public class OnlineItem: ShoppingItem
    {

        private int Pris;
        public OnlineItem(string title, bool isdone, int pris)
        {
            Title = title;
            IsDone = isdone;
            Pris = pris;
        }
        public OnlineItem()
        {
        }

        public int pris { get; set; }
    }
}
