using System;

namespace ecommerce
{
    class Admin
    {
        String username;
        String name;
        String email;
        String password;
        String confirmation_password;

        public String Username
        {
            get { return this.username; }
            set { this.username = value; }
        }

        public String Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public String Email
        {
            get { return this.email; }
            set { this.email = value; }
        }

        public String Password
        {
            get { return this.password; }
            set { this.password = value; }
        }

        public String Confirmation_Password
        {
            get { return this.confirmation_password; }
            set { this.confirmation_password = value; }
        }

        public Admin() : base()
        {
        }
    }
}
