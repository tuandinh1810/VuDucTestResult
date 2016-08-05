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
        Labconn_PKVuDucEntities labPKVuDuc;
        public Form1()
        {
            InitializeComponent();
            DateTime test= getMaxDateInPatientFromServer();
            labPKVuDuc = new Labconn_PKVuDucEntities();
            TestResult();
        }

        public void TestResult()
        {

            List<Doctor> lstDoctor = getDoctorFromClient();
            List<Patient> lstPatient = getPatientFromClient();
            List<TestResult> lstResult = getTestResultFromClient();
            
            string strResult = "";
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:64989/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

              
                //Improt Doctor

               
                foreach (var item in lstDoctor)
                {
                    var response = client.PostAsJsonAsync("api/TestResult/ImportDoctor", item).Result;
                    //client.PostAsJsonAsync
                    if (response.EnsureSuccessStatusCode().StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        //This method is an extension method, defined in System.Net.Http.HttpContentExtensions    
                        strResult = response.Content.ReadAsStringAsync().Result;
                    }
                }
                //Import Patient
                foreach (var item in lstPatient)
                {
                    var response = client.PostAsJsonAsync("api/TestResult/ImportPatient", item).Result;
                    //client.PostAsJsonAsync
                    if (response.EnsureSuccessStatusCode().StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        //This method is an extension method, defined in System.Net.Http.HttpContentExtensions    
                        strResult = response.Content.ReadAsStringAsync().Result;
                    }
                }

                // New code:
                //Import TestResult
                foreach (var item in lstResult)
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

        public DateTime getMaxDateInPatientFromServer()
        {
            DateTime result = DateTime.MinValue;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:64989/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));


                var response = client.GetAsync("api/TestResult/MaxDatInPatient").Result;
                //client.PostAsJsonAsync
                if (response.EnsureSuccessStatusCode().StatusCode == System.Net.HttpStatusCode.OK)
                {
                    //This method is an extension method, defined in System.Net.Http.HttpContentExtensions    
                    result = response.Content.ReadAsAsync<DateTime>().Result;
                }

            }

            return result;
        }

        public DateTime getMaxUpDateTimeResultFromServer()
        {
            DateTime result = DateTime.MinValue;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:64989/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));


                var response = client.GetAsync("api/TestResult/MaxUpdateTimeResult").Result;
                //client.PostAsJsonAsync
                if (response.EnsureSuccessStatusCode().StatusCode == System.Net.HttpStatusCode.OK)
                {
                    //This method is an extension method, defined in System.Net.Http.HttpContentExtensions    
                    result = response.Content.ReadAsAsync<DateTime>().Result;
                }

            }

            return result;
        }

        public List<TestResult> getTestResultFromClient()
        {
            List<TestResult> lstTestResult = new List<VuDucLapConnModel.TestResult>();
            TestResult testResult;
            DateTime maxUpdateTimeResult = getMaxUpDateTimeResultFromServer();
            List<tbl_Result> lstResult = labPKVuDuc.tbl_Result.Where(o => o.Updatetime> maxUpdateTimeResult).ToList();
            foreach (var item in lstResult)
            {
                testResult = new VuDucLapConnModel.TestResult();
                testResult.SID = item.SID;
                testResult.Testcode = item.Testcode;
                testResult.TestName = item.TestName;
                testResult.Result = item.Result;
                testResult.ResultTime = item.ResultTime;
                testResult.AutoID = item.AutoID;
                testResult.NormalRange = item.NormalRange;
                testResult.Unit = item.Unit;
                testResult.Category = item.Category;
                testResult.UpdateTime = item.Updatetime;
                lstTestResult.Add(testResult);
            }
            return lstTestResult;
        }
        public List<Doctor> getDoctorFromClient()
        {
            List<Doctor> lstDoctor = new List<Doctor>();
            Doctor objectDoctor;
            List<tbl_Doctor> lstDoctorClient = labPKVuDuc.tbl_Doctor.ToList();
            if(lstDoctorClient!=null && lstDoctorClient.Count>0)
            {
                foreach(var doctor in lstDoctorClient)
                {
                    objectDoctor = new Doctor();
                    objectDoctor.DoctorID = doctor.DoctorID;
                    objectDoctor.DoctorName = doctor.DoctorName;
                    lstDoctor.Add(objectDoctor);
                }
            }

            return lstDoctor;

        }
        public List<Patient> getPatientFromClient()
        {
            DateTime maxInTimePatient = getMaxDateInPatientFromServer();
            List<Patient> lstPatient = new List<Patient>();
            Patient objPatient;
            List<tbl_Patient> lstPatientClient = labPKVuDuc.tbl_Patient.Where(o => o.Intime > maxInTimePatient).ToList();
            if (lstPatientClient != null && lstPatientClient.Count > 0)
            {
                foreach (var patient in lstPatientClient)
                {
                    objPatient = new Patient();
                    objPatient.SID = patient.SID;
                    objPatient.PatientName = patient.PatientName;
                    objPatient.Sex = patient.Sex;
                    objPatient.Phone = patient.Phone;
                    objPatient.Email = patient.Email;
                    objPatient.Address = patient.Address;
                    objPatient.Age = patient.Age;
                    objPatient.DateIn = patient.DateIN;
                    objPatient.DoctorID = patient.DoctorID;
                    objPatient.InTime = patient.Intime;
                    lstPatient.Add(objPatient);
                }
            }

            return lstPatient;
        }

    }
}
