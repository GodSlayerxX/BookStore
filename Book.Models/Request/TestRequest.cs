using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Models.Request
{
    public class TestRequest
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime SomeDate { get; set; }
    }
}