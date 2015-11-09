using Cloud.Note.Dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cloud.Note.Service
{
    public class SampleService:ISampleService
    {
        public ISampleDao SampleDao { private get; set; }

        public DateTime GetTime()
        {
            return SampleDao.GetTime();
        }
    }
}
