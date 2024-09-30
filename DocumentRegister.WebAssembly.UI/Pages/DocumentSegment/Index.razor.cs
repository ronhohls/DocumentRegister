using Blazored.Toast.Services;
using DocumentRegister.WebAssembly.UI.Contracts;
using DocumentRegister.WebAssembly.UI.Models.DocumentSegment;
using DocumentRegister.WebAssembly.UI.Services;
using Microsoft.AspNetCore.Components;

namespace DocumentRegister.WebAssembly.UI.Pages.DocumentSegment
{
    public partial class Index
    {
        [Inject]
        public NavigationManager navigationManager { get; set; }

        [Inject]
        public IDocumentSegmentService documentSegmentService { get; set; }

        [Inject]
        IToastService toastService { get; set; }
        [Inject]
        ILogger<Index> logger { get; set; }
		public List<DocumentSegmentVM> documentSegments { get; private set; }
        public string message { get; set; } = string.Empty;

        protected void EditDocumentSegment(int id)
        {
            navigationManager.NavigateTo($"/documentSegments/edit/{id}");
        }

        protected async Task DeleteDocumentSegment(int id)
        {
            var response = await documentSegmentService.DeleteDocumentSegment(id);
            if (response.Success)
            {
                toastService.ShowSuccess("Document Segment deleted Successfully");
                await OnInitializedAsync();
            }
            else
            {
                message = response.Message;
            }
        }

        protected override async Task OnInitializedAsync()
        {
            try
            {
                documentSegments = await documentSegmentService.GetDocumentSegments();
            }
            catch (Exception ex)
            {
                message = $"Error fetching data: {ex.Message}";
                toastService.ShowError(message);
            }
        }
    }
}