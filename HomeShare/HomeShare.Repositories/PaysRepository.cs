using HomeShare.DAL.Repositories;
using HomeShare.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeShare.Repositories
{
    public class PaysRepository : BaseRepository<PaysEntity>, IConcreteRepository<PaysEntity>
    {
        public PaysRepository(string connectionString) : base(connectionString)
        {
        }

        public List<PaysEntity> Get()
        {
            string requete = "Select * from Pays";
            return base.Get(requete);
        }

        public PaysEntity GetOne(int PK)
        {
            string requete = "Select * from Pays where idPays =" + PK;
            return base.GetOne(PK, requete);

        }

        public bool Insert(PaysEntity toInsert)
        {
            throw new NotImplementedException();
        }

        public bool Update(PaysEntity toUpdate)
        {
            throw new NotImplementedException();
        }    
        
        public bool Delete(PaysEntity toDelete)
        {
            throw new NotImplementedException();
        }
    }
}
