using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TimeSeriesModel
{
    class TimeSeries
    {
        protected List<double> originalSeries;
        protected List<double> processedSeries;
        //protected List<double> unitProcessedSeries;
        protected List<double> autocorrelationFunction;
        static public List<double> seasonalIndex = new List<double>();
        protected int start;
        protected int end;
        protected double max;
        protected double min;

        static public bool isSeasonalAdjust = false;
        static public bool isDetrend = false;
        //static public double a = 0.0;
        //static public double b = 0.0;
        static public double[] fixLine = new double[2]{0.0, 0.0};

        public List<ProcessType> preProcessList = new List<ProcessType>();

        public TimeSeries(){
            this.originalSeries = new List<double>();
            this.processedSeries = new List<double>();
            this.autocorrelationFunction = new List<double>();
        }
        public TimeSeries clone() {
            TimeSeries ret = new TimeSeries();
            ret.loadData(this.getOriginalSeries());
            return ret;
        }
        public void clearData() {
            if (this.processedSeries != null) {
                this.processedSeries.Clear();
            }
            if (this.originalSeries != null)
            {
                this.originalSeries.Clear();
            }
        }

        public void loadData(List<double> data)
        {
            try
            {
                this.preProcessList = new List<ProcessType>();
                this.originalSeries = new List<double>();
                this.processedSeries = new List<double>();
                for (int i = 0; i < data.Count(); i++)
                {
                    this.originalSeries.Add(data.ElementAt(i));
                    this.processedSeries.Add(data.ElementAt(i));
                }
                this.setStart(1);
                this.setEnd(this.originalSeries.Count);
            }
            catch (Exception)
            {
                
                MessageBox.Show("Error in loadData from list in TimeSeries", null, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void loadData(string fileName) {
            clearData();
            this.preProcessList = new List<ProcessType>();
            System.IO.StreamReader file = null;
            try
            {
                file = new System.IO.StreamReader(fileName);
                string line;
                while ((line = file.ReadLine()) != null)
                {
                    double data = Double.Parse(line);
                    this.originalSeries.Add(data);
                    this.processedSeries.Add(data);
                }

                this.setStart(1);
                this.setEnd(this.originalSeries.Count);
            }
            catch (System.IO.IOException ioException)
            {
                MessageBox.Show("File :" + fileName + " not found");
            }
            catch (System.Exception exception)
            {
                MessageBox.Show("File " + fileName + " is wrong format", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally {
                if ( file != null) {
                    file.Close();
                }
            }
        }

        public void saveData(string fileName) {
            System.IO.StreamWriter file = null;
            try
            {
                file = new System.IO.StreamWriter(fileName);
                foreach (double val in this.processedSeries) {
                    file.WriteLine(val);
                }
            }
            catch (System.IO.IOException ioException)
            {
                MessageBox.Show("File :" + fileName + " not found");
            }
            finally
            {
                if (file != null)
                {
                    file.Close();
                }
            }
        }

        public List<double> getOriginalSeries() {
            return this.originalSeries;
        }

        public void setSeriesData(List<double> series) {
            if (series == null) return;
            this.originalSeries = new List<double>();
            this.processedSeries = new List<double>();
            for (int i = 0; i < series.Count(); i++) {
                this.originalSeries.Add(series.ElementAt(i));
                this.processedSeries.Add(series.ElementAt(i));
            }

        }

        public List<double> getProcessedSeries(){
            return this.processedSeries;
        }

        public int getStart() {
            return this.start;
        }

        public int getEnd() {
            return this.end;
        }

        public void setStart(int start) {
            this.start = start;
        }

        public void setEnd(int end) {
            this.end = end;
        }

        public void restore() {
            try
            {
                if (this.processedSeries != null)
                {
                    this.processedSeries.Clear();
                }
                this.processedSeries = new List<double>();
                for (int i = 0; i < this.originalSeries.Count; i++)
                {
                    this.processedSeries.Add(this.originalSeries.ElementAt(i));
                }
                this.setStart(1);
                this.setEnd(this.originalSeries.Count);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in restore Time Series", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public double getMean() {
            return this.processedSeries.Sum() / this.processedSeries.Count;
        }

        public double getSize() {
            return this.processedSeries.Count;
        }

        public double getVariance() {
            double mean = this.getMean();
            double sum = 0.0;
            foreach (double val in this.processedSeries) {
                sum += (val - mean) * (val - mean);
            }
            sum = sum / (this.getSize() - 1);
            return sum;
        }

        public double getAutocorrelation(int lag) {
            if (lag == 0) { 
                return 1.0;
            }
            double result = 0.0;
            double mean = this.getMean();
            for (int t = lag; t < this.getSize(); t++) {
                result += (this.processedSeries.ElementAt(t) - mean) * (this.processedSeries.ElementAt(t - lag) - mean);
            }
            result = result / (this.getVariance() * (this.getSize() - 1));
            return result;
        }

        public void lnTranformation() {
            try
            {
                this.preProcessList.Add(new ProcessType(enum_PreprocessType.LN_TRANSFORM));
                List<double> lst = this.getProcessedSeries();
                this.processedSeries = new List<double>();
                for (int i = 0; i < lst.Count; i++)
                {
                    this.processedSeries.Add(Math.Log(lst.ElementAt(i)));
                }
                if (lst != null)
                {
                    lst.Clear();
                }
            }
            catch (Exception)
            {
                
                MessageBox.Show("Error in lnTranformation TimeSeries", null, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void difference(int lag) {
            try
            {
                if (lag == 1)
                {
                    double[] start = new double[1];
                    start[0] = this.getProcessedSeries().ElementAt(0);
                    this.preProcessList.Add(new ProcessType(enum_PreprocessType.DIFFERENCE, 1, start));
                }
                else
                {
                    double[] start = new double[lag];
                    for (int i = 0; i < lag; i++)
                    {
                        start[i] = this.getProcessedSeries().ElementAt(i);
                    }
                    this.preProcessList.Add(new ProcessType(enum_PreprocessType.SEASONAL_DIFF, lag, start));
                }
                List<double> lst = this.getProcessedSeries();
                this.processedSeries = new List<double>();
                for (int i = 0; (i + lag) < lst.Count; i++)
                {
                    this.processedSeries.Add(lst.ElementAt(i + lag) - lst.ElementAt(i));
                }
                this.setStart(lag + this.getStart());
            }
            catch (Exception)
            {
                
                MessageBox.Show("Error in Differnece TimeSeries", null, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public double[] calRegressionFixLine(){
            try
            {
                double[] ret = new double[2];
                //double a, b; // two parameter of regression equation y = a + bt
                //ToDo bulid best-fix line of data
                double T = this.getSize();
                double sum_y = 0.0;
                double sum_yt = 0.0;
                for (int i = 0; i < this.getSize(); i++)
                {
                    sum_y += this.getProcessedSeries().ElementAt(i);
                    sum_yt += (i + 1) * this.getProcessedSeries().ElementAt(i);
                }
                double a = ((2 * (2 * T + 1)) / (T * (T - 1)) * sum_y) - (6 / (T * (T - 1)) * sum_yt);
                double b = (12 / (T * (T * T - 1)) * sum_yt) - (6 / (T * (T - 1)) * sum_y);
                ret[0] = a;
                ret[1] = b;
                TimeSeries.isDetrend = true;
                return ret;
            }
            catch (Exception)
            {
                
                MessageBox.Show("Error in calRegressionFixLine TimeSeries", null, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

        }
        public void linearDetrend() {

            try
            {
                // detrend
                if (!TimeSeries.isDetrend)
                {
                    TimeSeries.fixLine = this.calRegressionFixLine();
                }
                this.preProcessList.Add(new ProcessType(enum_PreprocessType.LINEAR_DETREND, 0, TimeSeries.fixLine[0], TimeSeries.fixLine[1]));
                List<double> lst = this.getProcessedSeries();
                this.processedSeries = new List<double>();
                double a = TimeSeries.fixLine[0];
                double b = TimeSeries.fixLine[1];
                for (int j = 0; j < lst.Count; j++)
                {
                    this.processedSeries.Add(lst.ElementAt(j) - (a + b * (j + 1)));
                }
                if (lst != null)
                {
                    lst.Clear();
                }
            }
            catch (Exception)
            {
                
               MessageBox.Show("Error in linearDetrend TimeSeries", null, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public List<double> seasonalIndexCal(int cycle) {
            try
            {
                List<double> ret = new List<double>();
                List<double> preRet = new List<double>();
                double[] data = this.originalSeries.ToArray();
                int size = this.originalSeries.Count();
                double[] movingTotal = new double[size];
                double[] centreMovingAvg = new double[size];
                int i, j;
                for (i = 0; i < size; i++)
                {
                    movingTotal[i] = Double.NaN;
                    centreMovingAvg[i] = Double.NaN;
                }
                int q = (cycle % 2 == 0) ? (cycle / 2) : ((cycle - 1) / 2 + 1);
                for (i = q; i <= (size - q); i++)
                {
                    movingTotal[i] = 0.0;
                    for (j = 0; j < cycle; j++)
                    {
                        movingTotal[i] += data[i - q + j];
                    }
                }
                for (i = q; i < (size - q); i++)
                {
                    centreMovingAvg[i] = (movingTotal[i] + movingTotal[i + 1]) / (2 * cycle);
                }
                Dictionary<int, List<double>> seasonalIndexMap = new Dictionary<int, List<double>>();
                for (i = 0; i < cycle; i++)
                {
                    seasonalIndexMap.Add(i, new List<double>());
                }
                for (i = 0; i < size; i++)
                {
                    if (!Double.IsNaN(centreMovingAvg[i]))
                    {
                        double val = data[i] / centreMovingAvg[i];
                        seasonalIndexMap[i % cycle].Add(val);
                    }
                }
                for (i = 0; i < cycle; i++)
                {
                    int count = seasonalIndexMap[i].Count();
                    seasonalIndexMap[i].Sort();
                    if (count % 2 == 0)
                    {
                        int mid = count / 2;
                        double median = (seasonalIndexMap[i].ElementAt(mid) + seasonalIndexMap[i].ElementAt(mid - 1)) / 2;
                        preRet.Add(median);
                    }
                    else
                    {
                        preRet.Add(seasonalIndexMap[i].ElementAt(count / 2));
                    }
                }
                double sumMedian = preRet.Sum();
                double multiplier = cycle / sumMedian;
                for (i = 0; i < cycle; i++)
                {
                    ret.Add(preRet.ElementAt(i) * multiplier);
                }
                TimeSeries.isSeasonalAdjust = true;
                return ret;
            }
            catch (Exception)
            {
                
                MessageBox.Show("Error in seasonalIndexCal TimeSeries", null, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public void seasonalAdjust(int cycle) {
            try
            {
                this.preProcessList.Add(new ProcessType(enum_PreprocessType.SEASONAL_ADJ, cycle));
                if (!TimeSeries.isSeasonalAdjust)
                {
                    TimeSeries.seasonalIndex = this.seasonalIndexCal(cycle);
                }
                List<double> lst = this.getProcessedSeries();
                this.processedSeries = new List<double>();
                for (int i = 0; i < lst.Count(); i++)
                {
                    double seasonalFactor = lst.ElementAt(i) / TimeSeries.seasonalIndex.ElementAt(i % cycle);
                    this.processedSeries.Add(seasonalFactor);
                }
                if (lst != null)
                {
                    lst.Clear();
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Error in seasonalAdjust TimeSeries", null, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //public void UnitScaleForProcessedList()
        //{
        //    try
        //    {
        //        /*convert input to [-0.99;0.99]*/
        //        List<double> temp = this.processedSeries;
        //        this.processedSeries = new List<double>();
        //        this.max = temp.Max();
        //        this.min = temp.Min();
        //        int count = temp.Count;
        //        for (int i = 0; i < count; i++)
        //        {
        //            double a = temp.ElementAt(i);
        //            double b = (a - this.min) / (this.max - this.min) * (0.99 + 0.09) - 0.99;
        //            this.processedSeries.Add(b);
        //        }
                
        //    }
        //    catch (Exception)
        //    {
                
        //         MessageBox.Show("Error in UnitScaleForProcessedList TimeSeries", null, MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        //public void RevertForUnitProcessedList()
        //{
        //    try
        //    {
        //        /*Convert unit processed list to [min,max]*/
        //        List<double> temp = this.processedSeries;
        //        this.processedSeries = new List<double>();
        //        int count = temp.Count;
        //        for (int i = 0; i < count; i++)
        //        {
        //            double a = temp.ElementAt(i);
        //            double b = (a + 0.99) / (0.99 + 0.99) * (this.max - this.min) + this.min;
        //            processedSeries.Add(b);
        //        }
        //    }
        //    catch (Exception)
        //    {
                
        //         MessageBox.Show("Error in RevertForUnitProcessedList TimeSeries", null, MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        /*
         * process data depend on items on preProcessList 
         * to support for ANN
         */
        public List<double> GetProcessDataForANN(List<ProcessType> preProcessList)
        {
            try
            {
                this.restore();
                foreach (ProcessType type in preProcessList)
                {
                    switch (type.getType())
                    {
                        case enum_PreprocessType.DIFFERENCE:
                            this.difference(type.getLag());
                            break;
                        case enum_PreprocessType.LINEAR_DETREND:
                            this.linearDetrend();
                            break;
                        case enum_PreprocessType.LN_TRANSFORM:
                            this.lnTranformation();
                            break;
                        case enum_PreprocessType.SEASONAL_ADJ:
                            this.seasonalAdjust(type.getLag());
                            break;
                        case enum_PreprocessType.SEASONAL_DIFF:
                            this.difference(type.getLag());
                            break;
                        default:
                            break;
                    }
                }
                //this.UnitScaleForProcessedList();
            }
            catch (Exception)
            {
                
                MessageBox.Show("Error in GetProcessDataForANN TimeSeries", null, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return this.processedSeries;
        }
        /*
         * Convert data to original depend on preProcessList 
         * to support for ANN
         */
        public List<double> convertToOriginalDataForANN() {
            try
            {
                List<ProcessType> lst = this.preProcessList;
                //this.RevertForUnitProcessedList();
                if (lst == null || lst.Count() == 0)
                {
                    if (lst.Count() == 0)
                    {
                        return processedSeries;
                    }
                    return null;
                }
                int size = lst.Count();
                for (int i = size - 1; i >= 0; i--)
                {
                    ProcessType type = lst.ElementAt(i);
                    switch (type.getType())
                    {
                        case enum_PreprocessType.DIFFERENCE:
                            double[] start = type.getStartValues();
                            int lag = type.getLag();
                            this.revertDifference(lag, start);
                            break;
                        case enum_PreprocessType.LINEAR_DETREND:
                            double[] fixLine = type.getFixLine();
                            this.revertLinearDetrend(fixLine[0], fixLine[1]);
                            break;
                        case enum_PreprocessType.LN_TRANSFORM:
                            this.revertLnTransformation();
                            break;
                        case enum_PreprocessType.SEASONAL_ADJ:
                            int cycle = type.getLag();
                            this.revertSeasonalAdjust(cycle);
                            break;
                        case enum_PreprocessType.SEASONAL_DIFF:
                            double[] start1 = type.getStartValues();
                            int lag1 = type.getLag();
                            this.revertDifference(lag1, start1);
                            break;
                        default:
                            break;
                    }
                }
            }
            catch (Exception)
            {
                
                MessageBox.Show("Error in convertToOriginalDataForANN() TimeSeries", null, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return processedSeries;
        }

        public void revertLnTransformation() {
            try
            {
                List<double> lst = this.getProcessedSeries();
                this.processedSeries = new List<double>();
                for (int i = 0; i < lst.Count; i++)
                {
                    this.processedSeries.Add(Math.Exp(lst.ElementAt(i)));
                }
                if (lst != null)
                {
                    lst.Clear();
                }
            }
            catch (Exception)
            {
                
                MessageBox.Show("Error in revertLnTransformation TimeSeries", null, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void revertSeasonalAdjust(int cycle) {
            try
            {
                if (TimeSeries.seasonalIndex == null || TimeSeries.seasonalIndex.Count() == 0) return;
                List<double> lst = this.getProcessedSeries();
                this.processedSeries = new List<double>();
                for (int i = 0; i < lst.Count(); i++)
                {
                    double originalData = lst.ElementAt(i) * TimeSeries.seasonalIndex.ElementAt(i % cycle);
                    this.processedSeries.Add(originalData);
                }
                if (lst != null)
                {
                    lst.Clear();
                }
            }
            catch (Exception ex)
            {
                
                MessageBox.Show("Error in revertSeasonalAdjust TimeSeries", null, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void revertLinearDetrend(double a, double b) {
            try
            {
                List<double> lst = this.getProcessedSeries();
                this.processedSeries = new List<double>();
                for (int j = 0; j < lst.Count; j++)
                {
                    this.processedSeries.Add(lst.ElementAt(j) + (a + b * (j + 1)));
                }
                if (lst != null)
                {
                    lst.Clear();
                }
            }
            catch (Exception)
            {
                
                 MessageBox.Show("Error in revertLinearDetrend TimeSeries", null, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void revertDifference(int lag, double[] start) {
            try
            {
                List<double> lst = this.getProcessedSeries();
                this.processedSeries = new List<double>();
                int i = 0;
                for (i = 0; i < start.Count(); i++)
                {
                    this.processedSeries.Add(start[i]);
                }
                for (i = 0; i < lst.Count(); i++)
                {
                    double val = this.processedSeries.ElementAt(i) + lst.ElementAt(i);
                    this.processedSeries.Add(val);
                }
                this.setStart(this.getStart() - lag);
            }
            catch (Exception)
            {
                
                MessageBox.Show("Error in revertDifference TimeSeries", null, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
