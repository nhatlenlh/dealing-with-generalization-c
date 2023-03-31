using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dealing_with_generalization.formtemplatemethod.beforechange
{
    class Customer
    {
        private string name;

        private List<Rental> rentals = new ArrayList<>();

        public Customer(string name)
        {
            this.name = name;
        }

        public void addRental(Rental arg)
        {
            rentals.Add(arg);
        }

        public string getName()
        {
            return name;
        }

        public string statement()
        {
            int frequentRenterPoints = 0;
            string result = "Rental Record for " + getName() + "\n";
            foreach ( var rentals in Rental)
            {
                frequentRenterPoints += each.frequentRenterCount();

                result += "\t" + each.getMovie().getTitle() + "\t" + each.countAmount() + "\n";
            }

            result += " Amount owed is " + countTotalAmount() + "\n";
            result += " You earned " + frequentRenterPoints + " frequent renter points";
            return result;
        }

        public string htmlStatement()
        {
            int frequentRenterPoints = 0;
            string result = "<H1>Rental Record for <EM> " + getName() + "</EM><H1><P>n";
            foreach (var rentals in Rental)
            {
                frequentRenterPoints += each.frequentRenterCount();

                result += "\t" + each.getMovie().getTitle() + "\t" + each.countAmount() + "<BR>\n";
            }

            result += "<P> Amount owed is <EM>" + countTotalAmount() + "</EM><P>\n";
            result += " You earned <EM>" + frequentRenterPoints + " </EM> frequent renter points <P>";
            return result;
        }

        private double countTotalAmount()
        {
            double totalAmount = 0;

            foreach (var rentals in Rental)
            {
                totalAmount += each.countAmount();
            }

            return totalAmount;
        }
    }
}
