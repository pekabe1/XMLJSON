using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
   internal class Book : IDisposable
    {
        public string Title { get; set; }
        public string Category { get; set; }
        public string Status { get; set; }
        public int Id { get; set; }
        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}

