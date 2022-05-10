using System;

namespace ControleFinanceiro.Api.Config
{
    public static class ControleFinanceiroAutoMapper
    {
        public static Type[] config()

        {
            return new Type[]
            {
                typeof (ControleFinanceiroProfile)
            };
        }
        
    }
}
