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
        IConcreteRepository<PaysEntity> _paysRepo;


        public UnitOfWork(string connectionString)
        {
            _membreRepo = new MembreRepository(connectionString);
            _paysRepo = new PaysRepository(connectionString);
        }
        
        public PaysModel getPays(int id)
        {
            PaysEntity paysfromDB = _paysRepo.GetOne(id);
            PaysModel paysforController = new PaysModel();
            paysforController.IdPays = paysfromDB.IdPays;
            paysforController.Libelle = paysfromDB.Libelle;
            return paysforController;

        }
        public List<PaysModel> getAllPays()
        {

            return _paysRepo.Get()
            .Select(paysFromDB =>
            new PaysModel()
            {
                IdPays = paysFromDB.IdPays,
                Libelle = paysFromDB.Libelle
            }
            ).ToList();
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
