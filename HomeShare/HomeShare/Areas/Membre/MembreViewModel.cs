using HomeShare.Infra;
using HomeShare.Models;
using HomeShare.Repositories;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace HomeShare.Areas.Membre
{
    public class MembreViewModel
    {
        private UnitOfWork uow = new UnitOfWork(ConfigurationManager.ConnectionStrings["Cnstr"].ConnectionString);

        private MembreModel _membre;
        private List<MembreModel> _membresVue;

        public MembreViewModel()
        {
           Membre = SessionUtils.ConnectedUser;

            //AreaMembreModel amm = new AreaMembreModel();
            MembresVue = new List<MembreModel>();
           MembresVue.Add(Membre);


   
            
           
        }

        public MembreModel Membre
        {
            get
            {
                return _membre;
            }

            set
            {
                _membre = value;
            }
        }

        public List<MembreModel> MembresVue
        {
            get
            {
                return _membresVue;
            }

            set
            {
                _membresVue = value;
            }
        }
    }


}