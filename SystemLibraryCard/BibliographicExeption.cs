using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemLibraryCard
{
    public class BibliographicExeption : Exception
    {
        public BibliographicExeption(string message)
            : base(message)
        {
        }
    }
}
