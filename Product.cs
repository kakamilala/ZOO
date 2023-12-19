using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZOO
{
    public class Product
    {
        private int id_product;
        private string name;
        private string description;
        private int quantity;
        private int price;
        private int code;

        public Product()
        {
            id_product = 0; ;
            name="";
            description="";
            quantity=0;
            price=0;
            code=0;
        }

        public int getIDproduct()
        {
            return id_product;
        }
        public void setIDproduct(int id_product)
        {
            this.id_product = id_product;
        }

        public string getName()
        {
            return name;
        }
        public void setName(string name)
        {
            this.name = name;
        }

        public string getDescription()
        {
            return description;
        }
        public void setDescription(string description)
        {
            this.description = description;
        }

        public int getQuantity()
        {
            return quantity;
        }
        public void setQuantity(int quantity)
        {
            this.quantity = quantity;
        }

        public int getPrice()
        {
            return price;
        }
        public void setPrice(int price)
        {
            this.price = price;
        }
        public int getCode()
        {
            return code;
        }
        public void setCode(int code)
        {
            this.code = code;
        }


    }
}
