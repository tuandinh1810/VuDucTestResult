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
        public string TestAPI()
        {
            return "hello word";

        }
        
    }
}
