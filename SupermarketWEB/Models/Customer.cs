namespace SupermarketWEB.Models
{
	public class Customer
	{
		public int Id { get; set; }
		public int Document { get; set; }
		public string First_Name { get; set; }
		public string Last_Name { get; set; }
		public string? Address { get; set; }
		public DateTime? Birthday { get; set; }
		public int? Phone { get; set; }
		public string? Email { get; set; }
	}
}
