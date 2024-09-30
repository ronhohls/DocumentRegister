using AutoMapper;
using Blazored.LocalStorage;
using DocumentRegister.WebAssembly.UI.Contracts;
using DocumentRegister.WebAssembly.UI.Models.DocumentSegment;
using DocumentRegister.WebAssembly.UI.Services.Base;

namespace DocumentRegister.WebAssembly.UI.Services
{
    public class DocumentSegmentService : BaseHttpService, IDocumentSegmentService
    {
        private readonly IMapper _mapper;

        public DocumentSegmentService(IClient client, IMapper mapper, ILocalStorageService localStorage) : base(client, localStorage)
        {
            _mapper = mapper;
        }

        public async Task<Response<int>> CreateDocumentSegment(DocumentSegmentVM documentSegment)
        {
            try
            {
                await AddBearerToken();
                var createDocumentSegmentCommand = _mapper.Map<CreateDocumentSegmentCommand>(documentSegment);
                
                var response = await _client.SingleAsync(createDocumentSegmentCommand);
                
                return new Response<int>()
                {
                    Success = true,
                    Data = response.Data
                };
            }
            catch (ApiException ex)
            {
                return ConvertApiExceptions<int>(ex);
            }
        }

        public async Task<Response<List<int>>> CreateDocumentSegments(List<DocumentSegmentVM> documentSegments)
        {
            if (documentSegments == null || !documentSegments.Any())
            {
                return new Response<List<int>>
                {
                    Success = false,
                    Message = "No document segments provided for creation"
                };
            }
            try
            {
                await AddBearerToken();
                var createDocumentSegmentCommands = documentSegments
                    .Select(documentSegment => _mapper.Map<CreateDocumentSegmentCommand>(documentSegment))
                    .ToList();

                //assign document ids, all have the same id
                int documentId = documentSegments.First().DocumentSegmentId;
                foreach (var command in createDocumentSegmentCommands)
                {
                    command.DocumentId = documentId;
                }

                //call bulk create API endpoint 
                var response = await _client.BulkAsync(createDocumentSegmentCommands);
                var createdDocumentSegmentIds = response.Data;

                return new Response<List<int>>
                {
                    Success = true,
                    Data = createdDocumentSegmentIds.ToList()
                };
            }
            catch (ApiException ex)
            {
                return ConvertApiExceptions<List<int>>(ex);
            }
        }

        public async Task<Response<int>> DeleteDocumentSegment(int id)
        {
            try
            {
                await AddBearerToken();
                await _client.DocumentSegmentDELETEAsync(id);
                return new Response<int>()
                {
                    Success = true,
                };
            }
            catch (ApiException ex)
            {
                return ConvertApiExceptions<int>(ex);
            }
        }

        public async Task<List<DocumentSegmentVM>> GetDocumentSegments()
        {
            await AddBearerToken();
            var documentSegments = await _client.DocumentSegmentAllAsync();
            return _mapper.Map<List<DocumentSegmentVM>>(documentSegments);
        }

        public async Task<DocumentSegmentVM> GetDocumentSegment(int id)
        {
            await AddBearerToken();
            var documentSegment = await _client.DocumentSegmentGETAsync(id);
            return _mapper.Map<DocumentSegmentVM>(documentSegment);
        }

        public async Task<Response<int>> UpdateDocumentSegment(int id, DocumentSegmentVM documentSegment)
        {
            try
            {
                await AddBearerToken();
                var updateDocumentSegmentCommand = _mapper.Map<UpdateDocumentSegmentCommand>(documentSegment);
                updateDocumentSegmentCommand.DocumentSegmentId = id;
                await _client.DocumentSegmentPUTAsync(id.ToString(), updateDocumentSegmentCommand);
                return new Response<int>()
                {
                    Success = true,
                };
            }
            catch (ApiException ex)
            {
                return ConvertApiExceptions<int>(ex);
            }
        }
    }
}