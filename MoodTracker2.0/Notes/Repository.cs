using System;
using System.Collections.Generic;
using System.Text;

namespace Notes
{
    public class Repository
    {
        public IList<Notees> Notess { get; set; }

        public Repository()
        {
            Notess = new List<Notees>()
            {
                new Notees()
                {
                    Note= "Write your note here!"
                }
            };
        }
    }
}

