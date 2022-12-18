namespace SybrinLoanPortal.Shared.Models
{
    public class ProductType
    {
        public ProductType()
        {
            ClientDocs = new HashSet<ClientDoc>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<ClientDoc> ClientDocs { get; set; }
    }
}
