using Microsoft.EntityFrameworkCore;

namespace NguyenDinhTan_0718_2425_BaiThi.Data
{
public class ApplicationDbContext : DbContext
{
   public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options){}
   
}
}