using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TimeSeriesModel
{
    public enum enum_PreprocessType { 
        NONE,
        DIFFERENCE,
        LINEAR_DETREND,
        SEASONAL_DIFF,
        SEASONAL_ADJ,
        LN_TRANSFORM,
    }
    class ProcessType
    {
        protected enum_PreprocessType type;
        protected int lag; //use for difference and seasonal difference
        protected double[] fixLine; // use for linear detrend
        protected double[] startValues; // user for use for difference and seasonal difference
        public ProcessType() {
            this.type = enum_PreprocessType.NONE;
            this.lag = 0;
            fixLine = null;
            startValues = null;
        }

        public ProcessType(enum_PreprocessType ty) : this() {
            this.type = ty;
        }

        public ProcessType(enum_PreprocessType ty, int l) : this()
        {
            this.type = ty;
            this.lag = l;
        }

        public ProcessType(enum_PreprocessType ty, int l, double[] start) : this()
        {
            this.type = ty;
            this.lag = l;
            this.startValues = new double[start.Count()];
            for (int i = 0; i < start.Count(); i++) {
                this.startValues[i] = start[i];
            }
        }

        public ProcessType(enum_PreprocessType ty, int l, double a, double b) : this() {
            this.type = ty;
            this.lag = l;
            this.fixLine = new double[2];
            this.fixLine[0] = a;
            this.fixLine[1] = b;
        }

        public enum_PreprocessType getType() {
            return this.type;
        }

        public int getLag(){
            return this.lag;
        }

        public double[] getStartValues() {
            return this.startValues;
        }

        public double[] getFixLine() {
            return this.fixLine;
        }

        public void setType(enum_PreprocessType ty) {
            this.type = ty;
        }

        public void setLag(int l){
            this.lag = l;
        }

        public void setFixLine(double a, double b) {
            this.fixLine = new double[2];
            this.fixLine[0] = a;
            this.fixLine[1] = b;
        }

        public void setStartValues(double[] start) {
            this.startValues = new double[start.Count()];
            for (int i = 0; i < start.Count(); i++)
            {
                this.startValues[i] = start[i];
            }
        }
    }
}
