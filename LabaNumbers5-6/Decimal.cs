using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabaNumbers5_6
{
    internal class Decimal : Integer
    {
        

        public override string Dec(string a)
        {

            int resul = Convert.ToInt32(getNum()) - Convert.ToInt32(a);
            return Convert.ToString(resul);
        }

        public override string Div(string a)
        {
            try 
            {   if (a == "0")
                    throw new Exception();
                int resul = Convert.ToInt32(getNum()) * Convert.ToInt32(a);
                return Convert.ToString(resul);
            }
            catch(Exception e) 
            {
                return "You can't divide by zero!";
            }
        }

        public override string Mul(string a)
        {
            int resul = Convert.ToInt32(getNum()) * Convert.ToInt32(a);
            return Convert.ToString(resul); 
        }

        public override string getNum()
        {
            return this.num;
        }

        public override string Plus(string a)
        {
            int resul = Convert.ToInt32(getNum()) + Convert.ToInt32(a);
            return Convert.ToString(resul);
        }

        public override void setNum(string a)
        {
            this.num = a;
        }
    }
}
