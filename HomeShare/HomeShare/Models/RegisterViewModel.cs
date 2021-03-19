using HomeShare.Repositories;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace HomeShare.Models
{
    public class RegisterViewModel
    {
        private UnitOfWork uow = new UnitOfWork(ConfigurationManager.ConnectionStrings["Cnstr"].ConnectionString);

        public MembreModel membreModel { get; set; }
        public List<PaysModel> paysModel { get; set; }


        public RegisterViewModel()
        {
            paysModel = uow.getAllPays();
        }
    }
}