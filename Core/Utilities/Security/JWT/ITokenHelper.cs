using Core.Entitites.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Security.JWT
{
    public interface ITokenHelper
    {
        //giriş yapan kulkanıcı adı ve şifre için bir token üretiyor
        AccessToken CreateToken(User user, List<OperationClaim> operationClaims);
    }
}
