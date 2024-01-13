namespace WPR
{
    public class TestDataSeeder
    {
        private readonly WPRDbContext _context;

        public TestDataSeeder(WPRDbContext context)
        {
            _context = context;
        }

        public void SeedTestData()
        {
            // Add test data to the database
            var newItem1 = new Company{CompanyId =1, ContactEmail = "test@test.nl", Name = "TestCompany", Sector = "TestSector", TrackingID = "TestTrackingID", WebsiteURL = "www.test.nl"};

            _context.Companies.Add(newItem1);
            _context.SaveChanges();
        }
    }
}