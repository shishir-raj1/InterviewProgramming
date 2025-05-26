using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewProgramming.oopsProgramming
{
    public class car
    {
        //member variable, private hides the variable from other classes
        private string _model = "";
        private string _brand = "";
        private bool _isLuxury;

        //property with lambda expression
        public string Model { get => _model; set => _model = value; }
        public string Brand
        {
            get
            {
                if (_isLuxury)
                {
                    return _brand + " - Luxury Edition";
                }
                else
                {
                    return _brand;
                }
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    _brand = value;
                }
                else
                {
                    _brand = value;
                }

            }

        }

        public bool IsLuxury { get => _isLuxury; set => _isLuxury = value; }

        //custom constructor

        public car(string model,string brand, bool isLuxury)
        {
            Model = model;
            Brand = brand;
            IsLuxury = isLuxury;
        }

    }
}
