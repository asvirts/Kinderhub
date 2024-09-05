namespace Kinderhub.Data.Models
{
	public class Parent
	{
		public required Guid Id { get; set; }
		public required string FirstName { get; set; }
		public required string LastName { get; set; }

		public List<Child> Children { get; set; }
	}
}
