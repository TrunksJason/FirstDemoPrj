using FirstDemoPrj.EntityFrameworkCore;

namespace FirstDemoPrj.Tests.TestDatas
{
    public class TestDataBuilder
    {
        private readonly FirstDemoPrjDbContext _context;

        public TestDataBuilder(FirstDemoPrjDbContext context)
        {
            _context = context;
        }

        public void Build()
        {
            //create test data here...
        }
    }
}