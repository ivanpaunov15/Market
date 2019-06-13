using System.Collections.Generic;

namespace Market.Classes
{
    class PayDesk
    {
        private List<Card> cards;

        public PayDesk()
        {
            this.cards = new List<Card>();
        }

        public List<Card> Cards
        {
            get
            {
                return this.cards;
            }
            set
            {
                this.cards = value;
            }
        }
        public void AddToList(Card card)
        {
            this.cards.Add(card);
        }
        public override string ToString()
        {
            var sb = new System.Text.StringBuilder();
            for (int i = 0; i < cards.Count; i++)
            {
                sb.AppendLine(string.Format("{0}. {1}:", i + 1, cards[i].GetType().Name));
                sb.AppendLine(string.Format("Owner: {0}", cards[i].Owner));
                sb.AppendLine(string.Format("Purchase value: ${0:0.00}",cards[i].PurchaseValue));
                sb.AppendLine(string.Format("Discount rate: {0:P2}",cards[i].GetDiscountRate()));
                sb.AppendLine(string.Format("Discount: ${0:0.00} ", cards[i].GetDiscount()));
                sb.AppendLine(string.Format("Total: ${0:0.00} ", cards[i].GetTotal()));
                sb.AppendLine();
            }
            return sb.ToString();
        }
    }
}
