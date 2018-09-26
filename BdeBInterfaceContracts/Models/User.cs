using System;

namespace BdeBInterfaceContracts.Models
{
	public class User : IHasCreationDate
	{
		public int Id { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string Email { get; set; }
		public string Phone { get; set; }
		public UserRole Role { get; set; }
        public DateTime Creation { get; set; }
	}
}
