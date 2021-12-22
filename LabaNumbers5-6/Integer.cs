using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabaNumbers5_6
{
    abstract class Integer
    {
        protected string num;
        abstract public string Plus(string a);
        abstract public string Div(string a);
        abstract public string Mul(string a);
        abstract public string Dec(string a);
        abstract public void setNum(string a);
        abstract public string getNum();
    }
}
