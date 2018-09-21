using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HybridModel
{
    enum EstimateAlgorithmType
    {
        BRUTE_FORCE,
        STEEPEST_ASCENT_HILL_CLIMBING,
        SIMULATED_ANNEALING_HILL_CLIMBING,
        USE_R_LIB,
    }

    class Smoothing
    {
        static public double acceleration = 0.1; // do lon he so thay doi

        private Param param; // param cua chuong trinh, se la toi uu sau khi hoc
        public bool isAdditiveModel;
        public int cycle; // chu ky cua tinh mua, vi du cycle = 12 neu du lieu lay theo thang.
        private List<double> sample;

        private List<double> level;
        private List<double> trend;
        private List<double> seasonality;
        private double[] forcast;
        private double MSE;

        public Smoothing(List<double> _sample, Param _param, int _cycle, bool isAdditive)
        {
            this.sample = _sample;
            this.cycle = _cycle;
            this.isAdditiveModel = isAdditive;
            this.SetParam(_param);
        }

        public Param GetParam()
        {
            return param;
        }

        public double GetMSE()
        {
            return MSE;
        }

        public void SetParam(Param _param)
        {
            this.param = _param;
            this.initLevel();
            this.initTrend();
            this.initSeasonality();
            this.updateSeries();
            forcast = this.calFocastSeries();
            MSE = calMSE();
        }

        public void SetSeries(List<double> _sample)
        {
            this.sample = _sample;
            this.SetParam(this.param);
        }

        private void initLevel()
        {
            this.level = new List<double>();
            double temp = 0.0;
            for (int i = 0; i < cycle; i++)
            {
                temp += sample.ElementAt(i);
            }
            for (int i = 0; i < cycle - 1; i++)
                level.Add(0.0);
            level.Add(temp / cycle);
        }

        private void initTrend()
        {
            this.trend = new List<double>();
            double tmp = 0.0;
            for (int i = 0; i < cycle; i++)
            {
                tmp += sample.ElementAt(cycle + i) - sample.ElementAt(i);
            }
            for (int i = 0; i < cycle - 1; i++)
                this.trend.Add(0.0);
            this.trend.Add(tmp * (1.0 / cycle) * (1.0 / cycle));
        }

        private void initSeasonality()
        {
            this.seasonality = new List<double>();
            for (int i = 0; i < cycle; i++)
            {
                if (this.isAdditiveModel)
                {
                    this.seasonality.Add(sample[i] - this.level[cycle - 1]);
                }
                else
                {
                    this.seasonality.Add(sample[i] / this.level[cycle - 1]);
                }
            }
        }

        //calculate all value for level, trend, seasonal with current data and param
        private void updateSeries()
        {
            int idx = this.seasonality.Count();
            for (int i = idx; i < sample.Count(); i++)
            {
                if (this.isAdditiveModel)
                {
                    this.level.Add(param.Alpha * (sample.ElementAt(i) - this.seasonality[i - cycle]) + (1 - param.Alpha) * (this.level[i - 1] + this.trend[i - 1]));
                }
                else
                {
                    this.level.Add(param.Alpha * (sample.ElementAt(i) / this.seasonality[i - cycle]) + (1 - param.Alpha) * (this.level[i - 1] + this.trend[i - 1]));
                }
                this.trend.Add(param.Beta * (this.level[i] - this.level[i - 1]) + (1 - param.Beta) * this.trend[i - 1]);
                this.seasonality.Add(param.Gamma * sample.ElementAt(i) / this.level[i] + (1 - param.Gamma) * this.seasonality[i - cycle]);
            }
        }

        //calculate forcast series to calculate MSE
        private double[] calFocastSeries()
        {
            List<double> temp = new List<double>();
            double[] result = new double[sample.Count()];
            for (int i = 0; i < cycle; i++)
            {
                result[i] = sample.ElementAt(i);
            }
            for (int i = cycle; i < sample.Count(); i++)
            {
                // int posCycle = i / cycle;
                // double temp1 = (this.level[posCycle*cycle - 1] + (i-posCycle*cycle+1)*this.trend[posCycle*cycle - 1]) * this.seasonality[i - cycle];
                // result[i] = temp1;
                if (this.isAdditiveModel)
                {
                    result[i] = this.level[i - 1] + this.trend[i - 1] + this.seasonality[i - cycle];
                }
                else
                {
                    result[i] = (this.level[i - 1] + this.trend[i - 1]) * this.seasonality[i - cycle];
                }
            }
            return result;
        }

        public List<double> CalOuputList(List<double> input)
        {
            //get sample
            int size = input.Count();

            this.sample = new List<double>();
            for (int i = 0; i < cycle; i++)
            {
                this.sample.Add(input.ElementAt(i));
            }
            this.initLevel();

            this.trend = new List<double>();
            double tmp = 0.0;
            for (int i = 0; i < cycle; i++)
            {
                tmp += input.ElementAt(cycle + i) - input.ElementAt(i);
            }
            for (int i = 0; i < cycle - 1; i++)
                this.trend.Add(0.0);
            this.trend.Add(tmp * (1.0 / cycle) * (1.0 / cycle));

            this.initSeasonality();

            for (int i = cycle; i < size; i++)
            {
                int posCycle = i / cycle;
                double temp;
                if (this.isAdditiveModel)
                {
                    temp = (this.level[posCycle * cycle - 1] + (i - posCycle * cycle + 1) * this.trend[posCycle * cycle - 1]) + this.seasonality[i - cycle];
                }
                else
                {
                    temp = (this.level[posCycle * cycle - 1] + (i - posCycle * cycle + 1) * this.trend[posCycle * cycle - 1]) * this.seasonality[i - cycle];
                }
                this.sample.Add(temp);
                if (this.isAdditiveModel)
                {
                    this.level.Add(param.Alpha * (sample.ElementAt(i) - this.seasonality[i - cycle]) + (1 - param.Alpha) * (this.level[i - 1] + this.trend[i - 1]));
                }
                else
                {
                    this.level.Add(param.Alpha * (sample.ElementAt(i) / this.seasonality[i - cycle]) + (1 - param.Alpha) * (this.level[i - 1] + this.trend[i - 1]));
                }
                this.trend.Add(param.Beta * (this.level[i] - this.level[i - 1]) + (1 - param.Beta) * this.trend[i - 1]);
                this.seasonality.Add(param.Gamma * sample.ElementAt(i) / this.level[i] + (1 - param.Gamma) * this.seasonality[i - cycle]);
            }
            return this.sample;
        }

        public double[] CalOuputListForTrain(List<double> input)
        {
            this.SetSeries(input);
            return forcast;
        }

        private double calMSE()
        {
            double result = 0.0;
            for (int i = cycle; i < sample.Count(); i++)
            {
                result += (sample.ElementAt(i) - forcast[i]) * (sample.ElementAt(i) - forcast[i]);
            }
            return result / (sample.Count() - cycle);
        }

        static public Smoothing FindSmoothModelWithR(List<double> sample, string pathDLL, string pathData, int colum, int from, int end, int freq, bool additiveModel)
        {
            HoltWinters hw = HoltWinters.getValue(pathDLL, pathData, colum, from, end, freq, additiveModel);
            Param param = new Param(hw.alpha, hw.beta, hw.gamma);
            Smoothing smooth = new Smoothing(sample, param, freq, additiveModel);
            return smooth;
        }

        static public Param FindBestParam(EstimateAlgorithmType type, Smoothing smooth)
        {
            if (type == EstimateAlgorithmType.BRUTE_FORCE)
                return Brute_Force(smooth);
            else if (type == EstimateAlgorithmType.SIMULATED_ANNEALING_HILL_CLIMBING)
                return Simulated_Annealing_Hill_Climbing(smooth);
            else if (type == EstimateAlgorithmType.STEEPEST_ASCENT_HILL_CLIMBING)
                return Steepest_Ascent_Hill_Climbing(smooth);
            else
                return smooth.GetParam();
        }

        static private Param Brute_Force(Smoothing smooth)
        {
            double i, j, k;
            Param result = new Param(0.0, 0.0, 0.0);
            double minMSE = double.MaxValue;
            for (i = 0.0; i < 1.0; i = i + acceleration)
            {
                for (j = 0.0; j < 1.0; j = j + acceleration)
                {
                    for (k = 0.0; k < 1.0; k = k + acceleration)
                    {
                        Param tParam = new Param(i, j, k);
                        smooth.SetParam(tParam);
                        double tMSE = smooth.GetMSE();
                        Form1.txtLogs.AppendText("Step alpha = " + i + " beta = " + j + " gamma = " + k + " MSE = " + tMSE + "\n");
                        if (tMSE < minMSE)
                        {
                            minMSE = tMSE;
                            result = tParam;
                        }
                    }
                }
            }
            return result;
        }

        static private Param Steepest_Ascent_Hill_Climbing(Smoothing smooth)
        {
            Param curState = smooth.GetParam();
            double currentMSE = smooth.GetMSE();
            while (true)
            {
                List<Param> nextStates = genNetxStates(curState);
                Param minParam = curState;
                double minMSE = currentMSE;
                foreach (Param state in nextStates)
                {
                    smooth.SetParam(state);
                    double tMSE = smooth.GetMSE();
                    if (tMSE < minMSE)
                    {
                        minMSE = tMSE;
                        minParam = state;
                    }
                }
                Form1.txtLogs.AppendText("Step alpha = " + curState.Alpha + " beta = " + curState.Beta + " gamma = " + curState.Gamma + " MSE = " + currentMSE + "\n");
                if (minMSE < currentMSE)
                {
                    //chuyen sang trang thai tot hon
                    curState = minParam;
                    currentMSE = minMSE;
                    continue;
                }
                break;
            }
            return curState;
        }

        static private Param Simulated_Annealing_Hill_Climbing(Smoothing smooth)
        {
            Param curState = smooth.GetParam();
            double currentMSE = smooth.GetMSE();
            Random random = new Random();
            while (true)
            {
                List<Param> nextStates = genNetxStates(curState);
                Param minParam = curState;
                double minMSE = currentMSE;
                foreach (Param state in nextStates)
                {
                    smooth.SetParam(state);
                    double tMSE = smooth.GetMSE();
                    if (tMSE < minMSE)
                    {
                        minMSE = tMSE;
                        minParam = state;
                    }
                }
                Form1.txtLogs.AppendText("Step alpha = " + curState.Alpha + " beta = " + curState.Beta + " gamma = " + curState.Gamma + " MSE = " + currentMSE + "\n");
                if (minMSE < currentMSE)
                {
                    //chuyen sang trang thai tot hon
                    curState = minParam;
                    currentMSE = minMSE;
                    continue;
                }
                else
                {
                    double tSimulated = random.NextDouble();
                    if (tSimulated < 0.1)
                    {
                        //chuyen trang thai
                        currentMSE = minMSE;
                        curState = minParam;
                        continue;
                    }
                }
                break;
            }
            return curState;
        }

        static private List<Param> genNetxStates(Param oldParam)
        { // sinh ra cac trang thai tiep theo tu trang thai truyen vao
            // TODO coding here
            List<Param> result = new List<Param>();
            for (int i = -1; i < 2; i++)
            {
                for (int j = -1; j < 2; j++)
                {
                    for (int k = -1; k < 2; k++)
                    {
                        double newAlpha = oldParam.Alpha + i * acceleration;
                        double newBeta = oldParam.Beta + j * acceleration;
                        double newGamma = oldParam.Gamma + k * acceleration;
                        Param temp = new Param(newAlpha, newBeta, newGamma);
                        result.Add(temp);
                    }
                }
            }
            return result;
        }

        public double[] doForecast(List<double> input, int ahead)
        { // sinh ra cac du bao
            this.sample = input;
            this.initLevel();
            this.initTrend();
            this.initSeasonality();

            this.updateSeries();

            double[] ret = new double[ahead];
            for (int i = 0; i < ahead; i++)
            {
                int posCycle = i % cycle;
                if (posCycle == 0 && i > 0)
                {
                    this.updateSeries();
                }
                int idx = this.seasonality.Count();
                double temp;
                if (this.isAdditiveModel)
                {
                    temp = (this.level[idx - 1] + (posCycle + 1) * this.trend[idx - 1]) + this.seasonality[idx - cycle + posCycle];
                }
                else
                {
                    temp = (this.level[idx - 1] + (posCycle + 1) * this.trend[idx - 1]) * this.seasonality[idx - cycle + posCycle];
                }
                this.sample.Add(temp);
                ret[i] = temp;
            }
            return ret;
        }
    }
}
