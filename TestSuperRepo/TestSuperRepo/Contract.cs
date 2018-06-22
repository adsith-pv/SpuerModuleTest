// -----------------------------------------------------------------------
// <copyright file="Contract.cs" company="Payvision">
//     Payvision Copyright © 2018
// </copyright>
// -----------------------------------------------------------------------

namespace TestSuperRepo
{
    using SubModuleTest;

    public class Contract : IContract
    {
        public int ContractNumber()
        {
            return 3;
        }
    }
}