namespace interfaces.Services
{
	class BrasilTaxService : ITaxService
	{
            public double Tax (double amount)
            {
                if (amount <= 100.0)
                {
                    return amount * 0.2;
                }
                else
                {
                    return amount * 0.15;
                }
            }
		
	}
}