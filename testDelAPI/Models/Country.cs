namespace testDelAPI.Models
{
    public class Country
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        public ICollection<Owner>? OwnerClt { get; set;}
    }
}
