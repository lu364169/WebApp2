using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Schema;

namespace WebApp2.Data_Layer
{
    public class CartList
    {

        static Dictionary<string, string> store = new Dictionary<string, string>();

        public void AddToCart(Dictionary<string, string> list) {

            store = list;

        }

        public Dictionary<string,string> Read() {
            return store;
        }
    }
}