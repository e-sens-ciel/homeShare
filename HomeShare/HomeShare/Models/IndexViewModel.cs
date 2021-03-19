using HomeShare.Repositories;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace HomeShare.Models
{
    public class IndexViewModel
    {
        private UnitOfWork uow = new UnitOfWork(ConfigurationManager.ConnectionStrings["Cnstr"].ConnectionString);

        private List<BienEchangeModel> _biens1;
        private List<BienEchangeModel> principalSlider;
        private List<SliderModel> _slider1;
        private List<SliderModel> _slider2;
        private string _requeteRecherche;


        public IndexViewModel()
        {
            principalSlider = uow.getAllBiens();
 
            Biens1 = principalSlider;


            //Slider1 = new List<SliderModel>();
            //SliderModel toAdd = new SliderModel() { Link = "#", Picture = "marre.jpg" };
            //Slider1.Add(toAdd);
            //Slider1.Add(new SliderModel() { Link = "#", Picture = "marreDeSlider.jpg" });

            //Section Slider1
            Slider1 = new List<SliderModel>();
            SliderModel toAdd = new SliderModel() { Titre="Maison au bord de la mer", Image = "properties/3.jpg", Prix ="6035000$"};
            Slider1.Add(toAdd);
            Slider1.Add(new SliderModel() { Titre = "Maison au bord de la mer", Image = "properties/1.jpg", Prix = "488500000$" });
            Slider1.Add(new SliderModel() { Titre = "Cosy House", Image = "properties/4.jpg", Prix = "8900000$" });
            Slider1.Add(new SliderModel() { Titre = "Happy House", Image = "properties/2.jpg", Prix = "4890000$" });
            Slider1.Add(new SliderModel() { Titre = "Villa #Richesse", Image = "properties/1.jpg", Prix = "12003000$" });
            Slider1.Add(new SliderModel() { Titre = "HappyLand House", Image = "properties/4.jpg", Prix = "5000000$" });

        }

        public List<BienEchangeModel> Biens1
        {
            get
            {
                return _biens1;
            }

            set
            {
                _biens1 = value;
            }
        }

        public List<SliderModel> Slider1
        {
            get
            {
                return _slider1;
            }

            set
            {
                _slider1 = value;
            }
        }

        public List<SliderModel> Slider2
        {
            get
            {
                return _slider2;
            }

            set
            {
                _slider2 = value;
            }
        }

        public string RequeteRecherche
        {
            get
            {
                return _requeteRecherche;
            }

            set
            {
                _requeteRecherche = value;
            }
        }

        //public List<BienEchangeModel> BiensForSlider
        //{
        //    get
        //    {
        //        return _biensForSlider;
        //    }

        //    set
        //    {
        //        _biensForSlider = value;
        //    }
        //}
    }
}