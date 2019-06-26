using LinqToDB.Mapping;

namespace DatabaseDemo.model
{
    [Table(Schema = "public", Name = "Employees")]
    public class Employees
    {
        [Column("id")] [NotNull] public string Id { get; set; }
        [Column("name")] public string Name { get; set; }
    }
}