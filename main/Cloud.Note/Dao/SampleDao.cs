using Spring.Data.NHibernate.Generic.Support;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cloud.Note.Dao
{
    public class SampleDao:HibernateDaoSupport,ISampleDao
    {
        public DateTime GetTime()
        {
            return Session.GetNamedQuery("SampleDao_GetTime")
                .UniqueResult<DateTime>();
        }
    }
}
