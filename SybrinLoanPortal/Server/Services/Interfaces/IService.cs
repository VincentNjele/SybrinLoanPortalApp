namespace SybrinLoanPortal.Server.Services.Interfaces
{
    public interface IService
    {
       Task<IEnumerable<T>> LoadData<T>() where T : class;
    }
}
