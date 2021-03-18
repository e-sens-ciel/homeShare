﻿using HomeShare.DAL.Repositories;
using HomeShare.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tools;

namespace HomeShare.Repositories
{
    public class MembreRepository : BaseRepository<MembreEntity>, IConcreteRepository<MembreEntity>
    {
        public MembreRepository(string connectionString) : base(connectionString)
        {
        }

        public List<MembreEntity> Get()
        {
            throw new NotImplementedException();
        }

        public MembreEntity GetOne(int PK)
        {
            throw new NotImplementedException();
        }

        public bool Insert(MembreEntity toInsert)
        {
            SecurityHelper securityHelper = new SecurityHelper();
            byte[] salt = securityHelper.GenerateLongRandomSalt();
            toInsert.Salt = Convert.ToBase64String(salt);
            toInsert.Password = securityHelper.createHash(toInsert.Password, salt);
            string requete = @"INSERT INTO [dbo].[Membre]
           ([Nom]
           ,[Prenom]
           ,[Email]
           ,[Pays]
           ,[Telephone]
           ,[Login]
           ,[Password]
           ,[Salt])
            VALUES
           (@Nom
           ,@Prenom 
           ,@Email
           ,@Pays
           ,@Telephone
           ,@Login
           ,@Password
           ,@Salt)";
            return base.Insert(toInsert, requete);
        }

        public bool Update(MembreEntity toUpdate)
        {
            throw new NotImplementedException();
        }

        public bool Delete(MembreEntity toDelete)
        {
            throw new NotImplementedException();
        }
    }
}
