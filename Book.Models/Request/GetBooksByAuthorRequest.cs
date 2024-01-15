using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Models.Request
{
    public class GetBooksByAuthorRequest
    {
        public int AuthorId { get; set; }

        public DateTime AfterDate { get; set; }
    }
}
