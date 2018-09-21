using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using STATCONNECTORCLNTLib;
using StatConnectorCommonLib;
using STATCONNECTORSRVLib;

namespace HybridModel
{
    class HoltWinters
    {
        public double alpha = Double.NaN;
        public double beta = Double.NaN;
        public double gamma = Double.NaN;
        public double[] fitted = null;
        public double SSE = Double.NaN;
        public static HoltWinters getValue(string pathDLL, string pathData, int colum, int from, int end, int freq, bool additiveModel)
        {
            try
            {

                StatConnector engine = new StatConnector();
                engine.Init("R");
                // repare code
                engine.SetSymbol("pathData", pathData.Replace("\\", "/"));
                //engine.SetSymbol("from", from);
                //engine.SetSymbol("end", end);
                //engine.SetSymbol("freq", freq);
                //engine.SetSymbol("colum", colum);

                string readData = "data <- read.table(pathData)";
                string getData = "data <- data[" + from + ":" + end + ", c(" + colum + ")]";
                string getTsData = "data <- ts(data, freq=" + freq + ")";
                //string getHoltWinters = "data.hw <- HoltWinters(data)";
                string getHoltWinters = "";
                if (additiveModel)
                {
                    getHoltWinters = "data.hw <- HoltWinters(data, seasonal = \"additive\")";
                }
                else {
                    getHoltWinters = "data.hw <- HoltWinters(data, seasonal = \"mult\")";
                }
                string getAlpha = "alpha <- array(data.hw$alpha)";
                string getBeta = "beta <- array(data.hw$beta)";
                string getGamma = "gamma <- array(data.hw$gamma)";
                string getSSE = "SSE <- array(data.hw$SSE)";
                string getFitted = "fitted <- array(data.hw$fitted[,c(1)])";

                // execute code
                engine.EvaluateNoReturn(readData);
                engine.EvaluateNoReturn(getData);
                engine.EvaluateNoReturn(getTsData);
                engine.EvaluateNoReturn(getHoltWinters);
                engine.EvaluateNoReturn(getAlpha);
                engine.EvaluateNoReturn(getBeta);
                engine.EvaluateNoReturn(getGamma);
                engine.EvaluateNoReturn(getSSE);
                engine.EvaluateNoReturn(getFitted);

                // get value
                double alpha = engine.GetSymbol("alpha")[0];
                double beta = engine.GetSymbol("beta")[0];
                double gamma = engine.GetSymbol("gamma")[0];
                double SSE = engine.GetSymbol("SSE")[0];
                double[] fitted = engine.GetSymbol("fitted");
                engine.Close();

                HoltWinters hw = new HoltWinters();
                hw.alpha = alpha;
                hw.beta = beta;
                hw.gamma = gamma;
                hw.SSE = SSE;
                hw.fitted = fitted;
                return hw;
                

               
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw e;
            }
        }
    }
}
