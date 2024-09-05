using System.Runtime.InteropServices;

namespace Kinderhub.Data.Models
{
	public class Child
	{
		public required Guid Id { get; set; }
		public required string FirstName { get; set; }
		public required string LastName { get; set; }

		public Parent Parent { get; set; }
	}
}
