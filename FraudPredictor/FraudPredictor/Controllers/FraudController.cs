using FraudPredictorML.Model;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace FraudPredictor.Controllers
{
    public class FraudController : Controller
    {
        [HttpPost]
        public ModelOutput Index([FromBody] List<string> listToPredict)
        {   
            ModelInput modelToSend = new ModelInput
            {
                Trans_date_trans_time = listToPredict[0],
                Cc_num = float.Parse(listToPredict[1]),
                Amt = float.Parse(listToPredict[2]),
                First = listToPredict[3],
                Trans_distance = float.Parse(listToPredict[4])
            };

            var prediction = ConsumeModel.Predict(modelToSend);
            return prediction;
        }
    }
}
