namespace Market
{
    class GoldenCard : Card
    {
        public GoldenCard(string owner, decimal turnover, decimal purchaseValue) : base(owner, turnover, purchaseValue)
        {
            this.discountRate = 0.02m;
        }

        public override decimal GetDiscountRate()
        {
            if(this.turnover % 100 == 0)
            {
                this.discountRate = this.turnover / 10000;
            }
            if(this.turnover >= 1000)
            {
                this.discountRate = 0.1m;
            }
            return this.discountRate;
        }
    }
}
