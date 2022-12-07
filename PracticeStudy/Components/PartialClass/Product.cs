using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeStudy.Components
{
    partial class Product
    {
       
        public string ActiveText
        {
            get
            {
                if (IsActive == true)
                    return "Актуален";
                else
                    return "Нет в наличии";
                //return (IsActive) ? "Актуален" : "Нет в наличии";
            }
        }
    }
}
