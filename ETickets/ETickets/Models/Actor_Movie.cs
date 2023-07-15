using System;
namespace ETickets.Models
{
	public class Actor_Movie
	{
		public int Movie_id { get; set; }
		public Movie Movie { get; set; }

		public int Actor_id { get; set; }
        public Actor Actor { get; set; }
    }
}

