using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;
using WebApp2.Data_Layer;

namespace WebApp2.Bussiness_Layer
{
    public class DetailBL
    {

        public Dictionary<string, string> GetDetails()
        {
            try
            {
                CartList objdal = new CartList();
                Dictionary<string, string> b = new Dictionary<string, string>(objdal.Read());
                return b;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error",e);
                return null;
            }

        }

        public void AddCart(Dictionary<string, string> list)
        {
            try
            {
                CartList objdal = new CartList();
                objdal.AddToCart(list);

            }
            catch (Exception e)
            {
                Console.WriteLine("Error", e);
            }

        }

        public int Total() {

            CartList objdal = new CartList();
            Dictionary<string, string> b = new Dictionary<string, string>(objdal.Read());
            

            return b.Sum(x => Int32.Parse(x.Value));
        }
    }
}