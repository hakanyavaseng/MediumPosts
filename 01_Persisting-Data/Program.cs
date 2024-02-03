using Microsoft.EntityFrameworkCore;

Console.WriteLine();



#region Entity
class Person
{
    public int PersonId { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Address { get; set; }
}
#endregion

#region DbContext
class PersonDbContext : DbContext
{
    public DbSet<Person> Persons { get; set;}

	protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
	{
		optionsBuilder.UseSqlServer(@"Server =.\SQLEXPRESS;Database =PersonDb;Trusted_Connection = True;TrustServerCertificate=True;");
	}
}
#endregion

