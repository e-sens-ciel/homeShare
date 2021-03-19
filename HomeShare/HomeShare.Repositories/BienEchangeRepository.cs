using HomeShare.DAL.Repositories;
using HomeShare.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeShare.Repositories
{
    public class BienEchangeRepository : BaseRepository<BienEchangeEntity>, IConcreteRepository<BienEchangeEntity>
    {
        public BienEchangeRepository(string connectionString) : base(connectionString)
        {
        }


        public List<BienEchangeEntity> Get()
        {
            string requete = "Select * from BienEchange";
            return base.Get(requete);
        }
        public List<BienEchangeEntity> GetBySearch(string rechercheString)
        {
            string requete = $@"Select * from V_Search";
            if (!String.IsNullOrEmpty(rechercheString))
            {
                requete += " WHERE DescCourte LIKE '%" + rechercheString + "%' ";
            }
            return base.Get(requete);
        }
        public BienEchangeEntity GetOne(int PK)
        {
            throw new NotImplementedException();
        }

        public bool Insert(BienEchangeEntity toInsert)
        {
            throw new NotImplementedException();
        }

        public bool Update(BienEchangeEntity toUpdate)
        {
            throw new NotImplementedException();
        }
        public bool Delete(BienEchangeEntity toDelete)
        {
            throw new NotImplementedException();
        }

    }
}
