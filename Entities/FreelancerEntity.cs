namespace iddd_db.Entities
{
	public class FreelancerEntity
	{
		public FreelancerEntity(int id)
		{
			this.FreelancerId = id;
		}

		public int FreelancerId { get; private set; }

		public void UpdateAddress(string address)
		{

		}
	}
}
