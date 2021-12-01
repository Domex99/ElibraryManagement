using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using WebApplication3.models;

namespace WebApplication3
{
    public class UserService
    {

        IUserRepo _userRepo ;

        public UserService(IUserRepo userRepo)
        {
            _userRepo = userRepo;
        }

        public bool checkMemberExists(String textbox)
        {
            try
            {
                return _userRepo.checkMemberExists(textbox);
            }catch(Exception ex)
            {
                throw new Exception("" + ex);
            }
        }
    }
}