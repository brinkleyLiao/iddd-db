namespace iddd_db.Entities
{
	public class CustomerEntity
	{
		public CustomerEntity(int id)
		{
			this.CustomerId = id;
		}

		public int CustomerId { get; private set; }

		public void Paid(int projectId, string bankAccount)
		{

		}

		public bool HaveProject()
		{
			return true;
		}
	}
}
