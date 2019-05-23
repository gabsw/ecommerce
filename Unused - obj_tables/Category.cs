using System;

namespace ecommerce
{
    class Category
    {
        int code;
        String name;
        int vat;

        public int Code
        {
            get { return this.code; }
            set { this.code = value; }
        }

        public String Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public int Vat
        {
            get { return this.vat; }
            set { this.vat = value; }
        }

        public Category() : base()
        {
        }
    }
}
