using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeShare.Models
{
    public class SliderModel
    {
        private string _titre, _image, _prix;

        public string Titre
        {
            get
            {
                return _titre;
            }

            set
            {
                _titre = value;
            }
        }
        public string Image
        {
            get
            {
                return _image;
            }

            set
            {
                _image = value;
            }
        }

        public string Prix
        {
            get
            {
                return _prix;
            }

            set
            {
                _prix = value;
            }
        }
    }
}
