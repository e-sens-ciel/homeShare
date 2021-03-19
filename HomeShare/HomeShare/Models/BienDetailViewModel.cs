using HomeShare.Repositories;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace HomeShare.Models
{
    public class BienDetailViewModel
    {
        private UnitOfWork uow = new UnitOfWork(ConfigurationManager.ConnectionStrings["Cnstr"].ConnectionString);
        private BienEchangeModel _bien;
        private List<BienEchangeModel> _biensAffiches;
        public BienDetailViewModel(int id )
        {
            Bien = uow.GetBien(id);
            BiensAffiches = new List<BienEchangeModel>();
            BiensAffiches.Add(Bien);
            
        }

        public BienEchangeModel Bien
        {
            get
            {
                return _bien;
            }

            set
            {
                _bien = value;
            }
        }

        public List<BienEchangeModel> BiensAffiches
        {
            get
            {
                return _biensAffiches;
            }

            set
            {
                _biensAffiches = value;
            }
        }
    }
}