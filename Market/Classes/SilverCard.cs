namespace Market
{
    class SilverCard : Card
    {
        public SilverCard(string owner, decimal turnover, decimal purchaseValue) : base(owner, turnover, purchaseValue)
        {
            this.discountRate = 0.02m;
        }

        public override decimal GetDiscountRate()
        {         
            if (this.turnover > 300)
            {
                this.discountRate = 0.035m;
            }
            return this.discountRate;
        }
    }
}
