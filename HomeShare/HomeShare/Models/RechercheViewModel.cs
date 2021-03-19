using HomeShare.Repositories;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace HomeShare.Models
{
    public class RechercheViewModel
    {
        private UnitOfWork uow = new UnitOfWork(ConfigurationManager.ConnectionStrings["Cnstr"].ConnectionString);
        private List<BienEchangeModel> _bienRetrouver;

       
        public RechercheViewModel(string recherche)
        {
            if (recherche != null)
            {
            BienRetrouver = uow.GetBySearch(recherche);
            }
        }

        public List<BienEchangeModel> BienRetrouver
        {
            get
            {
                return _bienRetrouver;
            }

            set
            {
                _bienRetrouver = value;
            }
        }
    }
}