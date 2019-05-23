using System;

namespace ecommerce
{
    class DeliveryCompany
    {
        String name;
        String phone;
        String address;
        Boolean hasExpressDelivery;

        public String Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public String Phone
        {
            get { return this.phone; }
            set { this.phone = value; }
        }

        public String Address
        {
            get { return this.address; }
            set { this.address = value; }
        }

        public Boolean HasExpressDelivery
        {
            get { return this.hasExpressDelivery; }
            set { this.hasExpressDelivery = value; }
        }

        public DeliveryCompany() : base()
        {
        }
    }
}
