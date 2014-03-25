using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commerce.Data {
    /// <summary>
    /// The Results of a UPC Search Result
    /// </summary>
    public class SearchResult {

        public string ASIN {
            get {
                if (Product != null) {
                    return Product.ASIN;
                }
                return null;
            }
        }

        public decimal BuyItNowPrice {
            get {
                if (Product != null) {
                    return Product.BuyItNowPrice;
                }
                return 0;
            }
        }

        public string ErrorMessage {
            get;
            set;
        }

        public bool Failed {
            get;
            set;
        }

        public string ModelNumber {
            get {
                if (Product != null) {
                    return Product.Model;
                }
                return null;
            }
        }

        public decimal MSRP {
            get {
                if (Product != null) {
                    return Product.ListPrice;
                }
                return 0;
            }
        }

        public MongoProduct Product {
            get;
            set;
        }

        public SearchResult() {

        }

    }
}
