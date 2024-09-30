using Blazored.Toast.Services;
using DocumentRegister.WebAssembly.UI.Contracts;
using DocumentRegister.WebAssembly.UI.Models.Document;
using Microsoft.AspNetCore.Components;

namespace DocumentRegister.WebAssembly.UI.Pages.Document
{
    public partial class Index
    {
        [Inject]
        public NavigationManager navigationManager { get; set; }

        [Inject]
        public IDocumentService documentService { get; set; }

        [Inject]
        IToastService toastService { get; set; }
        [Inject]
        ILogger<Index> logger { get; set; }
        public string message { get; set; } = string.Empty;
        List<DocumentVM> documents { get; set; }

        protected void CreateDocument()
        {
            navigationManager.NavigateTo("/documents/create/");
        }

        protected void EditDocument(int id)
        {
            navigationManager.NavigateTo($"/documents/edit/{id}");
        }

        protected void DetailsDocument(int id)
        {
            navigationManager.NavigateTo($"/documents/details/{id}");
        }

        protected async Task DeleteDocument(int id)
        {
            var response = await documentService.DeleteDocument(id);
            if (response.Success)
            {
                toastService.ShowSuccess("Document deleted Successfully");
                await OnInitializedAsync();
            }
            else
            {
                message = response.Message;
            }
        }

        protected override async Task OnInitializedAsync()
        {
            documents = await documentService.GetDocuments();
        }
    }
}
