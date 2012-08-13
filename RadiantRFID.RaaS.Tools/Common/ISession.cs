// -----------------------------------------------------------------------
// <copyright file="ISession.cs" company="">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace RadiantRFID.RaaS.Tools.Common
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public interface ISession
    {
        void Add(string key, object value);

        object Get(string key);

        T Get<T>(string key) where T : class;
    }
}
