using System;
using Xunit;
using FraudPredictorML.Model;
using FraudPredictor.Controllers;
using System.Collections.Generic;

namespace FraudPredictorTests
{
    public class FraudPredictorTests
    {
        [Fact]
        public void GetBankAccounts_ShouldReturnBankAccounts()
        {

            ModelInput modelInput = new ModelInput()
            {
                Trans_date_trans_time = @"2/3/2019",
                Cc_num = 3.569685E+15F,
                Amt = 8.571544E+07F,
                First = "John",
                Trans_distance = 5152.628F,
            };

            List<string> modelInputString = new List<string> { modelInput.Trans_date_trans_time, modelInput.Cc_num.ToString(), modelInput.Amt.ToString(), modelInput.First, modelInput.Trans_distance.ToString() };

            FraudController controller = new FraudController();

            var result = controller.Index(modelInputString);

            Assert.True(result.Prediction == "1" || result.Prediction == "0");

        }
    }
}
