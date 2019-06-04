using System.Collections.Generic;
using iddd_db.Entities;

namespace iddd_db.Service
{
	public class CustomerService
	{
		public List<CustomerEntity> GetAll()
		{
			return new List<CustomerEntity>();
		}

		public void RemoveCustomer(int customerId)
		{
			var customer = new CustomerEntity(customerId);

			if (!customer.HaveProject())
			{
				//// remove customer
			}
		}
	}
}
