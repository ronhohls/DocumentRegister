using AutoMapper;
using Blazored.Toast.Services;
using DocumentRegister.WebAssembly.UI.Contracts;
using DocumentRegister.WebAssembly.UI.Models.DeptDocNumStruct;
using DocumentRegister.WebAssembly.UI.Models.Document;
using DocumentRegister.WebAssembly.UI.Models.DocumentSegment;
using DocumentRegister.WebAssembly.UI.Models.MediaType;
using DocumentRegister.WebAssembly.UI.Models.SegmentCategory;
using DocumentRegister.WebAssembly.UI.Models.SegmentData;
using DocumentRegister.WebAssembly.UI.Models.Status;
using Microsoft.AspNetCore.Components;

namespace DocumentRegister.WebAssembly.UI.Pages.Document
{
    public partial class Create
    {
        [Inject]
        IDocumentService documentService { get; set; }
        [Inject]
        IDeptDocNumStructService deptDocNumStructService { get; set; }
        [Inject]
        IMediaTypeService mediaTypeService { get; set; }
        [Inject]
        IStatusService statusService { get; set; }
        [Inject]
        ISegmentDataService segmentDataService { get; set; }
        [Inject]
        IToastService toastService { get; set; }
        [Inject]
        NavigationManager navigationManager { get; set; }
        //document to be created
        CreateDocumentVM document { get; set; } = new CreateDocumentVM();

        //the document segments to be created
        List<CreateDocumentSegmentVM> documentSegments { get; set; } = new List<CreateDocumentSegmentVM>();

        //list of all department document number structures retieved from the database
        IEnumerable<DeptDocNumStructVM> deptDocNumStructs { get; set; } = new List<DeptDocNumStructVM>();
        //list of all media types retieved from the database
        List<MediaTypeVM> mediaTypes { get; set; } = new List<MediaTypeVM>();
        //list of all statuses retieved from the database
        List<StatusVM> statuses { get; set; } = new List<StatusVM>();
        List<SegmentDataVM> segmentDatum { get; set; } = new List<SegmentDataVM>();
        public string message { get; private set; } = string.Empty;

        public DeptDocNumStructVM deptDocNumStruct { get; set; } = new DeptDocNumStructVM();
        public bool DdnsSelected { get; set; } = false;

        //The segment categories for this document - to be populated based on the DDNS
        List<SegmentCategoryVM> segmentCategories { get; set; } = new List<SegmentCategoryVM>();
        
        //combined collection of segmentCategories and documentSegments for UI form generation
        public List<(SegmentCategoryVM segmentCategory, CreateDocumentSegmentVM documentSegment)> combinedCollection { get; set; }

        protected override async Task OnInitializedAsync()
        {
            deptDocNumStructs = await deptDocNumStructService.GetDeptDocNumStructs();
            mediaTypes = await mediaTypeService.GetMediaTypes(); 
            statuses = await statusService.GetStatuses();
            segmentDatum = await segmentDataService.GetSegmentData();
        }

        private async Task CreateDocument()
        {
            documentSegments = combinedCollection.Select(x => x.documentSegment).ToList();
            document.DocumentSegments = documentSegments;
            document.DdnsDescription = deptDocNumStruct.Description;
            document.DocumentNumber = BuildDocumentNumber(documentSegments, document.Seperator);
            var result  = await documentService.CreateDocument(document);
            navigationManager.NavigateTo("/documents");
        }

        private string BuildDocumentNumber(List<CreateDocumentSegmentVM> documentSegments, string seperator)
        {
            //return string.Join(seperator, documentSegments.Select(segment => segment.Value));
            return string.Join("", documentSegments
                .Select((segment, index) => segment.Value + ((index < seperator.Length) ? seperator[index].ToString() : "")));
        }

        private async Task HandleDDNSChange(ChangeEventArgs e)
        {
            //convert the selected value to an integer
            if (int.TryParse(e.Value.ToString(), out int ddnsId))
            {
                //get selected DDNS object
                deptDocNumStruct = await deptDocNumStructService.GetDeptDocNumStruct(ddnsId);

                //assign seperator and DdnsDescription to document
                document.Seperator = deptDocNumStruct.Seperator;
                document.DdnsDescription = deptDocNumStruct.Description;

                //get the segment categories for this DDNS
                segmentCategories = deptDocNumStruct.SegmentCategories.ToList();

                //clear previous document segments
                documentSegments.Clear();

                //initialise the correct amount of document segments
                for (int i = 0; i < segmentCategories.Count; i++)
                {
                    documentSegments.Add(new CreateDocumentSegmentVM());
                }

                //create a combined collection for iterating over categories and segments
                //simulataneously in the UI
                combinedCollection = segmentCategories.Zip(documentSegments,
                    (segmentCategory, documentSegment) => (segmentCategory, documentSegment)).ToList();
                DdnsSelected = true;
            }
        }
    }
}