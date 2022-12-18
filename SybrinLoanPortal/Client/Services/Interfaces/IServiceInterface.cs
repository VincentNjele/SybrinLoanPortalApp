namespace SybrinLoanPortal.Client.Services.Interfaces
{
    public interface IServiceInterface
    {
        Task<IEnumerable<T>> LoadData<T>(string url) where T : class;
    }
}
