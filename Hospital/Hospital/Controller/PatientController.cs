using Model;
using System;
using System.Collections.Generic;

namespace Controller
{
    public class PatientController
    {
        public List<Patient> GetAll()
        {
            throw new NotImplementedException();
        }

        public Model.Patient GetByJmbg(String jmbg)
        {
            throw new NotImplementedException();
        }

        public void Save(Model.Patient patient)
        {
            throw new NotImplementedException();
        }

        public void Delete(String jmbg)
        {
            throw new NotImplementedException();
        }

        public void Update(Model.Patient patient)
        {
            throw new NotImplementedException();
        }

        public Service.PatientService patientService;

    }
}