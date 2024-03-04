namespace _07.CompanyUsers
{
    internal class Program
    {
        internal static void Main()
        {
            var company = new Dictionary<string, List<string>>();
            string? command;
            while ((command = Console.ReadLine()) != "End")
            {
                var cmd = command?
                    .Split(" -> ", StringSplitOptions.RemoveEmptyEntries)
                    .ToList();
                var companyName = cmd?[0];
                var employerId = cmd?[1];

                if (!company.ContainsKey(companyName))
                {
                    company.Add(companyName, new List<string>());
                }

                if (!company[companyName].Contains(employerId))
                {
                    company[companyName].Add(employerId);
                }
            }

            foreach (var (key, value) in company)
            {
                Console.WriteLine(key);
                foreach (var v in value)
                {
                    Console.WriteLine($"-- {v}");
                }
            }
        }
    }
}
