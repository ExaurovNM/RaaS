
namespace RadiantRFID.RaaS.Tools.Common
{
    using System;

    public class RandomToken : IRandomToken
    {
        public string GetRandomToken()
        {
            return Guid.NewGuid().ToString();
        }
    }
}