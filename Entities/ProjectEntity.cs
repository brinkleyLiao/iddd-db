using System;
using System.Collections.Generic;
using System.Text;

namespace iddd_db.Entities
{
	public class ProjectEntity
	{
		public ProjectEntity(int id, CustomerEntity customer)
		{
			this.Customer = customer;
		}

		public int Id { get; private set; }

		public CustomerEntity Customer { get; private set; }

		public FreelancerEntity Freelancer { get; private set; }

		public void Assign(FreelancerEntity freelancer)
		{
			this.Freelancer = freelancer;
		}
	}
}
