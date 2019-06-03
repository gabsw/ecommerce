using System;
using System.Windows.Forms;

namespace ecommerce
{
    class FormValidation
    {
        static public void showError(String errorMsg)
        {
            MessageBox.Show(errorMsg, "Error alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static bool validateUser(String userName, String name, String email, String password, String password_confirmation, String tin, String fullAddress, bool isUpdate)
        {
            if (userName == "" || userName.Length < 3 || userName.Length > 20)
            {
                showError("Please enter an username consisting of 3 to 20 characters.");
                return false;
            }

            if (!isUpdate && (password == "" || password.Length < 6 || password.Length > 20))
            {
                showError("Please enter a password consisting of 6 to 20 characters.");
                return false;
            }
            else if (isUpdate && password != "" && (password.Length < 6 || password.Length > 20))
            {
                showError("Please enter a password consisting of 6 to 20 characters.");
                return false;
            }

            if (password != password_confirmation)
            {
                showError("Your password and confirmation do not match. Re-enter both.");
                return false;
            }

            if (name == "")
            {
                showError("Your name cannot be empty.");
                return false;
            }

            if (name.Length > 50)
            {
                showError("Your name cannot exceed 50 digits. Use initials.");
                return false;
            }

            if (tin.Length > 11 || tin == "")
            {
                showError("Please enter a valid TIN.");
                return false;
            }

            if (email == "" || !email.Contains("@") || email.Length > 30)
            {
                showError("Please enter a valid e-mail under 30 characters.");
                return false;
            }

            if (fullAddress == "")
            {
                showError("Please enter a complete address.");
                return false;
            }

            if (fullAddress.Length > 200)
            {
                showError("Address is limited by 200 characters.");
                return false;
            }

            return true;
        }

        public static bool validateDebit(decimal debitAmount, String iban)
        {
            if (debitAmount < 0)
            {
                showError("Debit must be a positive number.");
                return false;
            }

            if (iban == "" || iban.Length > 34)
            {
                showError("Invalid IBAN field.");
                return false;
            }

            return true;
        }

        public static bool validateAdmin(String userName, String name, String email, String password,
            String password_confirmation, bool isUpdate)
        {
            if (userName == "" || userName.Length < 3 || userName.Length > 20)
            {
                showError("Please enter an username consisting of 3 to 20 characters.");
                return false;
            }

            if (!isUpdate && (password == "" || password.Length < 6 || password.Length > 20))
            {
                showError("Please enter a password consisting of 6 to 20 characters.");
                return false;
            }
            else if (isUpdate && password != "" && (password.Length < 6 || password.Length > 20))
            {
                showError("Please enter a password consisting of 6 to 20 characters.");
                return false;
            }

            if (password != password_confirmation)
            {
                showError("Your password and confirmation do not match. Re-enter both.");
                return false;
            }

            if (name == "")
            {
                showError("Your name cannot be empty.");
                return false;
            }

            if (name.Length > 50)
            {
                showError("Your name cannot exceed 50 digits. Use initials.");
                return false;
            }

            if (email == "" || !email.Contains("@") || email.Length > 30)
            {
                showError("Please enter a valid e-mail under 30 characters.");
                return false;
            }

            return true;
        }

        public static bool validateCategory(String name, int vat)
        {
            if (vat < 0)
            {
                showError("Debit must be a positive integer.");
                return false;
            }

            if (name == "" || name.Length > 25 || name.Length < 3)
            {
                showError("Name field should consist of a minimum of 3 characters and a maximum of 25.");
                return false;
            }

            return true;
        }

        public static bool validateDeliveryCompany(String name, String phone, String address, Boolean hasExpressDelivery)
        {
            if (name == "" || name.Length > 20 || name.Length < 3)
            {
                showError("Name field should consist of a minimum of 3 characters and a maximum of 20.");
                return false;
            }

            if (phone == "" || phone.Length > 20 || phone.Length < 10)
            {
                showError("Phone field should consist of a minimum of 10 digits and a maximum of 20.");
                return false;
            }

            if (address == "")
            {
                showError("Please enter a complete address.");
                return false;
            }

            if (address.Length > 200)
            {
                showError("Address is limited by 200 characters.");
                return false;
            }

            return true;
        }

        public static bool validateProduct(String name, String description, String category)
        {

            if (name == "" || name.Length > 50 || name.Length < 3)
            {
                showError("Name field should consist of a minimum of 3 characters and a maximum of 50.");
                return false;
            }

            if (description == "" || description.Length > 200)
            {
                showError("Description field should not be empty or exceed 200.");
                return false;
            }

            if (category == "")
            {
                showError("Category field cannot be empty.");
                return false;
            }

            return true;
        }

        public static bool validateAuction(decimal minBidAmount, DateTime begDate, DateTime finishDate)
        {

            if (minBidAmount < 0)
            {
                showError("The minimum bid amount cannot be negative");
                return false;
            }

            if (begDate < DateTime.Now)
            {
                showError("The beginning date must start in the future time.");
                return false;
            }

            if (finishDate <= begDate)
            {
                showError("The finish date should be later than the beginning date.");
                return false;
            }

            return true;
        }

        public static bool validateBid(decimal bidAmount)
        {
            if (bidAmount < 0)
            {
                showError("Bid must be a positive number.");
                return false;
            }

            return true;
        }

        public static bool validateSearch(String keywords)
        {
            if (keywords.Length > 50)
            {
                showError("Search is limited to 50 characters.");
                return false;
            }

            return true;
        }

        public static bool validateReview(int rating, String comment)
        {
            if (comment == "")
            {
                showError("You must leave a comment in your review.");
                return false;
            }

            if (comment.Length > 500)
            {
                showError("Comment space is limited to 500 characters.");
                return false;
            }

            if (rating > 5 || rating < 1)
            {
                showError("Your rating must be an integer between 1 and 5.");
                return false;
            }

            return true;
        }

        public static bool validatePurchase(decimal finalPrice, decimal VAT_Record, bool hasExpressDelivery,
                int auctionID, String Buyer_Name_Record, String Buyer_TIN_Record, String Seller_Name_Record,
                String Seller_TIN_Record)
        {

            if (auctionID.ToString() == "")
            {
                showError("AuctionID cannot be empty.");
                return false;
            }

            if (finalPrice.ToString() == "")
            {
                showError("Final Price cannot be empty.");
                return false;
            }

            if (finalPrice < 0)
            {
                showError("Final Price cannot be negative.");
                return false;
            }

            if (hasExpressDelivery.ToString() == "")
            {
                showError("Delivery type cannot be empty.");
                return false;
            }

            if (VAT_Record < 0)
            {
                showError("VAT cannot be negative.");
                return false;
            }

            if (Buyer_Name_Record == "")
            {
                showError("Buyer's name cannot be empty.");
                return false;
            }

            if (Buyer_Name_Record.Length > 50)
            {
                showError("Buyer's name cannot exceed 50 digits. Use initials.");
                return false;
            }

            if (Buyer_TIN_Record.Length > 11 || Buyer_TIN_Record == "")
            {
                showError("Please enter a valid TIN for the buyer.");
                return false;
            }

            if (Seller_Name_Record == "")
            {
                showError("Seller's name cannot be empty.");
                return false;
            }

            if (Seller_Name_Record.Length > 50)
            {
                showError("Seller's name cannot exceed 50 digits. Use initials.");
                return false;
            }

            if (Seller_TIN_Record.Length > 11 || Seller_TIN_Record == "")
            {
                showError("Please enter a valid TIN for the seller.");
                return false;
            }



            return true;
        }

        public static bool validateShipping(int purchaseID, String delivery_company, String seller_address,
            String buyer_address, DateTime dispatchDate, DateTime estimatedArrivalDate)
        {

            if (purchaseID.ToString() == "")
            {
                showError("PurchaseID cannot be empty.");
                return false;
            }

            if (delivery_company == "")
            {
                showError("Delivery company cannot be empty.");
                return false;
            }

            if (delivery_company.Length > 20)
            {
                showError("Delivery company cannot have a name longer than 20 characters.");
                return false;
            }

            if (dispatchDate < DateTime.Now)
            {
                showError("The dispatch date must start in the future time.");
                return false;
            }

            if (estimatedArrivalDate < dispatchDate)
            {
                showError("The arrival date should be later than the dispatch date.");
                return false;
            }

            if (buyer_address == "")
            {
                showError("Buyer's address cannot be empty.");
                return false;
            }

            if (buyer_address.Length > 200)
            {
                showError("Buyer's address cannot exceed 200 digits.");
                return false;
            }

            if (seller_address == "")
            {
                showError("Seller's address cannot be empty.");
                return false;
            }

            if (seller_address.Length > 200)
            {
                showError("Seller's address cannot exceed 200 digits.");
                return false;
            }

            return true;
        }

        public static bool validatePayment(int purchaseID, decimal amount, String billing_address,
            String cc_number, String cc_cvc, DateTime cc_expiry_date)
        {

            if (purchaseID.ToString() == "")
            {
                showError("PurchaseID cannot be empty.");
                return false;
            }

            if (billing_address == "")
            {
                showError("Billing address cannot be empty.");
                return false;
            }

            if (billing_address.Length > 200)
            {
                showError("Billing address cannot be longer than 200 characters.");
                return false;
            }

            if (cc_expiry_date < DateTime.Now)
            {
                showError("Your credit card date has expired.");
                return false;
            }


            if (cc_number == "")
            {
                showError("Credit card number cannot be empty.");
                return false;
            }

            if (cc_number.Length > 19)
            {
                showError("Credit card number is invalid.");
                return false;
            }

            if (cc_cvc == "")
            {
                showError("Credit card CVC number cannot be empty.");
                return false;
            }

            if (cc_cvc.Length != 3)
            {
                showError("CVC number is invalid.");
                return false;
            }

            return true;
        }
    }
}
