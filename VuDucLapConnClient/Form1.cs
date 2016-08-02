using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Net.Http.Headers;
using VuDucLapConnModel;
using VuDucLapConnClient.Model;
namespace VuDucLapConnClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            List<TestResult> lstResult = getTestResultFromClient();
            TestResult(lstResult);
        }

        public void TestResult(List<TestResult> lstResult)
        {
            
            string strResult = "";
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:64989/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                // New code:
                foreach(var item in lstResult)
                {
                    var response = client.PostAsJsonAsync("api/TestResult/ImportTestResult", item).Result;
                    //client.PostAsJsonAsync
                    if (response.EnsureSuccessStatusCode().StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        //This method is an extension method, defined in System.Net.Http.HttpContentExtensions    
                        strResult = response.Content.ReadAsStringAsync().Result;
                    }
                }

            }
        }
        public List<TestResult> getTestResultFromClient()
        {
            List<TestResult> lstTestResult = new List<VuDucLapConnModel.TestResult>();
            TestResult testResult;
            Labconn_PKVuDucEntities labPKVuDuc = new Labconn_PKVuDucEntities();
            List<tbl_Result> lstResult = labPKVuDuc.tbl_Result.Where(o => o.ResultTime.Value.Year == 2016 &&
             o.ResultTime.Value.Month == 7 && o.ResultTime.Value.Day == 23).ToList();
            foreach (var item in lstResult)
            {
                testResult = new VuDucLapConnModel.TestResult();
                testResult.SID = item.SID;
                testResult.Testcode = item.Testcode;
                testResult.TestName = item.TestName;
                testResult.Result = item.Result;
                testResult.ResultTime = item.ResultTime;
                testResult.AutoID = item.AutoID;

                lstTestResult.Add(testResult);
            }
            return lstTestResult;
        }

    }
}
