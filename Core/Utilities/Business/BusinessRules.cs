using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Business
{
    public class BusinessRules
    {

        //logic kuralları gez anlamına geliyor.
        public static IResult Run(params IResult[] logics) 
        {
            foreach (var logic in logics)
            {
                if (!logic.Sucess)
                {
                    return logic;
                }
            }
                return null;
        }
    }
}
