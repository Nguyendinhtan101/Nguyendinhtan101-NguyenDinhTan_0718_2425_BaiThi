using Microsoft.EntityFrameworkCore;

namespace NguyenVanTrien_0656_2425_BaiThi.Data
{
public class ApplicationDbContext : DbContext
{
   public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options){}
   
}
}