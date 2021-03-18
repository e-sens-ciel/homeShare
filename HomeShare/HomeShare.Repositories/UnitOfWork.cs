using HomeShare.DAL.Repositories;
using HomeShare.Entities;
using HomeShare.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeShare.Repositories
{
    public class UnitOfWork
    {
        IConcreteRepository<MembreEntity> _membreRepo;

        public UnitOfWork(string connectionString)
        {
            _membreRepo = new MembreRepository(connectionString);
        }

        public bool CreateUser(MembreModel mm)
        {
            MembreEntity membreEntity = new MembreEntity()
            {
                Nom = mm.Nom,
                Prenom = mm.Prenom,
                Email = mm.Email,
                Pays = mm.Pays,
                Telephone = mm.Telephone,
                Login = mm.Login,
                Password = mm.Password,
            };
            return _membreRepo.Insert(membreEntity);
        }
    }
}
