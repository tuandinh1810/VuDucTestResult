using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using VuDucLapConnModel;
namespace VuDucLabConn.Controllers
{

    public class TestResultController : ApiController
    {

        [HttpPost]
        public string ImportTestResult(TestResult model)
        {
            string isSucess = "";
            try
            {
                VuDucResultTestEntities testResultEntities = new VuDucResultTestEntities();
                testResultEntities.TestResults.Add(model);
                testResultEntities.SaveChanges();
                isSucess = "Sucess";
            }
            catch (Exception ex)
            {
                isSucess = ex.InnerException.ToString();
            }

            return isSucess;

        }
        [HttpPost]
        public string ImportDoctor(Doctor model)
        {


            string isSucess = "";
            try
            {
                VuDucResultTestEntities testResultEntities = new VuDucResultTestEntities();
                testResultEntities.Doctors.Add(model);
                testResultEntities.SaveChanges();
                isSucess = "Sucess";
            }
            catch (Exception ex)
            {
                isSucess = ex.InnerException.ToString();
            }

            return isSucess;

        }
        [HttpPost]
        public string ImportPatient(Patient model)
        {
            string isSucess = "";
            try
            {
                VuDucResultTestEntities testResultEntities = new VuDucResultTestEntities();
                testResultEntities.Patients.Add(model);
                testResultEntities.SaveChanges();
                isSucess = "Sucess";
            }
            catch (Exception ex)
            {
                isSucess = ex.InnerException.ToString();
            }

            return isSucess;

        }
        [HttpGet]
        public DateTime MaxDatInPatient()
        {
            DateTime maxDateIn = DateTime.MinValue;
            string isSucess = "";
            try
            {
                VuDucResultTestEntities testResultEntities = new VuDucResultTestEntities();
                if (testResultEntities.Patients.Count() > 0)
                    maxDateIn = testResultEntities.Patients.Max(o => o.InTime).Value;
                isSucess = "Sucess";
            }
            catch (Exception ex)
            {
                isSucess = ex.InnerException.ToString();
            }

            return maxDateIn;
        }
        [HttpGet]
        public DateTime MaxUpdateTimeResult()
        {
            DateTime maxUpDateTime = DateTime.MinValue;
            string isSucess = "";
            try
            {
                VuDucResultTestEntities testResultEntities = new VuDucResultTestEntities();
                if (testResultEntities.TestResults.Count() > 0)
                    maxUpDateTime = testResultEntities.TestResults.Max(o => o.UpdateTime).Value;
                isSucess = "Sucess";
            }
            catch (Exception ex)
            {
                isSucess = ex.InnerException.ToString();
            }

            return maxUpDateTime;
        }
        [HttpGet]
        public string TestAPI()
        {
            return "hello word";

        }

    }
}
