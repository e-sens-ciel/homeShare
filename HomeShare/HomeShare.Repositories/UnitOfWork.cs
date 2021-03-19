using HomeShare.DAL.Repositories;
using HomeShare.Entities;
using HomeShare.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tools;

namespace HomeShare.Repositories
{
    public class UnitOfWork
    {
        IConcreteRepository<MembreEntity> _membreRepo;
        IConcreteRepository<PaysEntity> _paysRepo;
        IConcreteRepository<BienEchangeEntity> _bienEchangeRepo;
        IConcreteRepository<BienEchangeEntity> _biensRechercher;



        public UnitOfWork(string connectionString)
        {
            _membreRepo = new MembreRepository(connectionString);
            _paysRepo = new PaysRepository(connectionString);
            _bienEchangeRepo = new BienEchangeRepository(connectionString);
            _biensRechercher = new BienEchangeRepository(connectionString);
        }

        public MembreModel UserAuth(LoginModel mm)
        {
            MembreEntity ue = ((MembreRepository)_membreRepo).GetFromLogin(mm.Login);
            if (ue == null) return null;
            SecurityHelper sh = new SecurityHelper();
            if (sh.VerifyHash(mm.Password, ue.Password, ue.Salt))
            {
                return new MembreModel()
                {
                    Login = ue.Login,
                    Password = ue.Password,
                };
            }
            else
            {
                return null;
            }
        }

        /*-----Barre de recherche-----*/
        public List<BienEchangeModel> GetBySearch(string recherche)
        {
            return ((BienEchangeRepository)_biensRechercher).GetBySearch(recherche)
            .Select(bienFromDB =>
            new BienEchangeModel()
            {
                IdBien = bienFromDB.IdBien,
                Titre = bienFromDB.Titre,
                DescCourte = bienFromDB.DescCourte,
                DescLong = bienFromDB.DescLong,
                NombrePerson = bienFromDB.NombrePerson,
                Pays = bienFromDB.Pays,
                Ville = bienFromDB.Ville,
                Rue = bienFromDB.Rue,
                Numero = bienFromDB.Numero,
                CodePostal = bienFromDB.CodePostal,
                Photo = bienFromDB.Photo,
                AssuranceObligatoire = bienFromDB.AssuranceObligatoire,
                IsEnabled = bienFromDB.IsEnabled,
                DisabledDate = bienFromDB.DisabledDate,
                Latitude = bienFromDB.Latitude,
                Longitude = bienFromDB.Longitude,
                IdMembre = bienFromDB.IdMembre,
                DateCreation = bienFromDB.DateCreation
            }
            ).ToList();
        }

        /*------------Pays------------*/
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

        /*------------Biens------------*/
        public List<BienEchangeModel> getAllBiens()
        {
            return _bienEchangeRepo.Get()
            .Select(bienFromDB =>
            new BienEchangeModel()
            {
                IdBien = bienFromDB.IdBien,
                Titre = bienFromDB.Titre,
                DescCourte = bienFromDB.DescCourte,
                DescLong = bienFromDB.DescLong,
                NombrePerson = bienFromDB.NombrePerson,
                Pays = bienFromDB.Pays,
                Ville = bienFromDB.Ville,
                Rue = bienFromDB.Rue,
                Numero = bienFromDB.Numero,
                CodePostal = bienFromDB.CodePostal,
                Photo = bienFromDB.Photo,
                AssuranceObligatoire = bienFromDB.AssuranceObligatoire,
                IsEnabled = bienFromDB.IsEnabled,
                DisabledDate = bienFromDB.DisabledDate,
                Latitude = bienFromDB.Latitude,
                Longitude = bienFromDB.Longitude,
                IdMembre = bienFromDB.IdMembre,
                DateCreation = bienFromDB.DateCreation
            }
            ).ToList();
        }

        /*------------User------------*/
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
