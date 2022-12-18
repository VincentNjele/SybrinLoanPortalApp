using MudBlazor;
using SybrinLoanPortal.Shared.Models;

namespace SybrinLoanPortal.Client.Pages
{
    public partial class AddClient
    {
        MudForm? form;
        ClientDoc ClientDoc = new ClientDoc();
        public bool success { get; set; }
    }
}
