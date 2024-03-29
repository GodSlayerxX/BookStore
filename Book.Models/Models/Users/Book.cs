﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Models.Models.Users
{
	public record Book
	{
		public int Id { get; set; }
		public string Title { get; set; } = string.Empty;
        public int AuthorId { get; set; }
        public DateTime ReleaseDate { get; set; }
    }
}
