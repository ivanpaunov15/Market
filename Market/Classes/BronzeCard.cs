namespace Market
{
    class BronzeCard : Card
    {
        public BronzeCard(string owner,decimal turnover,decimal purchaseValue) : base (owner,turnover,purchaseValue)
        {
            
        } 
     
        public override decimal GetDiscountRate()
        {
            if(this.turnover < 100)
            {
                this.discountRate = 0.0m;
            }
            else if (this.turnover > 100 && this.turnover < 300)
            {
                this.discountRate = 0.01m;
            }
            else if (this.turnover > 300)
            {
                this.discountRate = 0.025m;
            }
            return this.discountRate;
        }
    }
}
