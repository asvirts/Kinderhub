namespace Kinderhub.Data.Models
{
	public class Class
	{
		public Guid Id { get; set; }

		public Staff Teacher { get; set; }
		public List<Child> Children { get; set; }
	}
}
