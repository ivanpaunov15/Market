using System;

namespace Market
{
    class Card : ICard
    {
        protected string owner;
        protected decimal turnover;
        protected decimal purchaseValue;
        protected decimal discountRate;
        protected decimal discount;
        protected decimal total;

        public Card(string owner, decimal turnover, decimal purchaseValue)
        {
            this.owner = owner;
            this.turnover = turnover;
            this.purchaseValue = purchaseValue;
        }

        public string Owner
        {
            get
            {
                return this.owner;
            }
            set
            {
                this.owner = value;
            }
        }
        public decimal Turnover
        {
            get
            {
                return this.turnover;
            }
            set
            {
                this.turnover = value;
            }
        }
        public decimal PurchaseValue
        {
            get
            {
                return this.purchaseValue;
            }
            set
            {
                this.purchaseValue = value;
            }
        }
        public decimal DiscountRate
        {
            get
            {
                return this.discountRate;
            }
            set
            {
                this.discountRate = value;
            }
        }
        public decimal Discount
        {
            get
            {
                return this.discount;
            }
            set
            {
                this.discount = value;
            }
        }
        public decimal Total
        {
            get
            {
                return this.total;
            }
            set
            {
               this.total = value;
            }
        }

        public virtual decimal GetDiscount()
        {
            this.discount = this.purchaseValue * this.discountRate;
            return this.discount;
        }

        public virtual decimal GetDiscountRate()
        {
            throw new NotImplementedException();
        }

        public virtual decimal GetTotal()
        {
            this.total = this.purchaseValue - this.discount;

            return this.total;
        }
    }
}
