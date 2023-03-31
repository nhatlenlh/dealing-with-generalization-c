using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dealing_with_generalization.formtemplatemethod.beforechange
{
    class Movie
    {
        public static  int CHILDRENS = 2;

        public static  int REGULAR = 0;

        public static  int NEW_RELEASE = 1;

        private string title;

        private int priceCode;

        public Movie(string title, int priceCode)
        {
            this.title = title;
            this.priceCode = priceCode;
        }

        public string getTitle()
        {
            return title;
        }

        public int getPriceCode()
        {
            return priceCode;
        }

        public void setPriceCode(int priceCode)
        {
            this.priceCode = priceCode;
        }
    }
}
