using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HybridModel
{
    class Param
    {

        public Param(double alpha, double beta, double gamma)
        {
            this.Alpha = alpha;
            this.Beta = beta;
            this.Gamma = gamma;
        }

        public void assign(Param other)
        {
            this.Alpha = other.Alpha;
            this.Beta = other.Beta;
            this.Gamma = other.Gamma;
        }

        public double Alpha
        {
            get
            {
                return alpha;
            }
            set
            {
                if (value >= 0.0 && value <= 1.0)
                {
                    alpha = value;
                }
                else
                {
                    alpha = 0.0;
                }
            }
        }

        public double Beta
        {
            get
            {
                return beta;
            }
            set
            {
                if (value >= 0.0 && value <= 1.0)
                {
                    beta = value;
                }
                else
                {
                    beta = 0.0;
                }
            }
        }

        public double Gamma
        {
            get
            {
                return gamma;
            }
            set
            {
                if (value >= 0.0 && value <= 1.0)
                {
                    gamma = value;
                }
                else
                {
                    gamma = 0.0;
                }
            }
        }

        private double alpha;
        private double beta;
        private double gamma;
    }
}
