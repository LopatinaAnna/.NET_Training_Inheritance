namespace InheritanceTask
{
    public class Company
    {
        private readonly Employee[] employees;

        public Company(Employee[] employees)
        {
            this.employees = employees;
        }

        public void GiveEverybodyBonus(decimal companyBonus)
        {
            foreach (Employee employee in employees)
                employee.SetBonus(companyBonus);
        }

        public decimal TotalToPay()
        {
            decimal total = 0;
            foreach (Employee employee in employees)
                total += employee.ToPay();
            return total;
        }

        public string NameMaxSalary()
        {
            string nameMaxSalary = employees[0].Name;
            decimal maxSalary = employees[0].ToPay();

            for (int i = 1; i < employees.Length; i++)
            {
                if (employees[i].ToPay() > maxSalary)
                {
                    maxSalary = employees[i].ToPay();
                    nameMaxSalary = employees[i].Name;
                }
            }

            return nameMaxSalary;
        }
    }
}