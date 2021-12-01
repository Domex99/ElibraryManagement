using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication3.models
{
    public interface IUserRepo
    {
        bool checkMemberExists(String textbox);
    }
}
