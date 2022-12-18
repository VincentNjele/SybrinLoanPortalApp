using Microsoft.AspNetCore.Components;
using MudBlazor;
using SybrinLoanPortal.Client.Services.Interfaces;
using SybrinLoanPortal.Shared.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SybrinLoanPortal.Client.Pages
{
    public partial class RequestForAccount
    {
        [Inject]
        public IServiceInterface service { get; set; }
        public IList<ClientDoc> ClientDocs { get; set; } = new List<ClientDoc>();
        public string searchString { get; set; }
        public bool IsAssigned { get; set; } = true;
        public int? Id { get; set; }
        public DateTime? Date { get; set; } = DateTime.Today;
        MudForm? form;
        public async void GetClients()
        {
            var data = await service.LoadData<ClientDoc>("api/Service/GetClients");
            ClientDocs = data.ToList();
            StateHasChanged();
        }

        public void Save(int id, ClientDoc clientDoc)
        {
           
            var data = ClientDocs.Where(v=> v.Id == id).ToList();

            if(data.Count > 0 )
            {
                 foreach(var item in data) 
                    {
                      Id = item.ProductTypeId;
                    }
            }
           if(Id !=null)
            {
                IsAssigned = true;
            } else
            {
                IsAssigned = false;
            }
           
            StateHasChanged();
        }
        
        public void CreateCase(ClientDoc clientDoc)
        {
            
        }

        protected override void OnInitialized()
        {
           GetClients();
        }
    }
}
