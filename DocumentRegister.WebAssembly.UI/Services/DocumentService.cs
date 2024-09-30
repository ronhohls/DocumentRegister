using AutoMapper;
using Blazored.LocalStorage;
using DocumentRegister.WebAssembly.UI.Contracts;
using DocumentRegister.WebAssembly.UI.Models.Document;
using DocumentRegister.WebAssembly.UI.Services.Base;

namespace DocumentRegister.WebAssembly.UI.Services
{
    public class DocumentService : BaseHttpService, IDocumentService
    {
        private readonly IMapper _mapper;

        public DocumentService(IClient client, IMapper mapper, ILocalStorageService localStorage) : base(client, localStorage)
        {
            _mapper = mapper;
        }

        //public async Task<Response<int>> CreateDocument(DocumentVM document)
        //{
        //    try
        //    {
        //        await AddBearerToken();
        //        var createDocumentCommand = _mapper.Map<CreateDocumentCommand>(document);
        //        var response = await _client.OldAsync(createDocumentCommand);
        //        var createdDocumentId = response.Data;

        //        return new Response<int>()
        //        {
        //            Success = true,
        //            Data = createdDocumentId
        //        };
        //    }
        //    catch (ApiException ex)
        //    {
        //        return ConvertApiExceptions<int>(ex);
        //    }

        //}
        public async Task<int> CreateDocument(CreateDocumentVM document)
        {

            var result = await _client.DocumentPOSTAsync(_mapper.Map<CreateDocumentDto>(document));
            return result;
        }

        public async Task<Response<int>> DeleteDocument(int id)
        {
            try
            {
                await AddBearerToken();
                await _client.DocumentDELETEAsync(id);
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

        public async Task<List<DocumentVM>> GetDocuments()
        {
            await AddBearerToken();
            var documents = await _client.DocumentAllAsync();
            return _mapper.Map<List<DocumentVM>>(documents);
        }

        public async Task<DocumentVM> GetDocument(int id)
        {
            await AddBearerToken();
            var document = await _client.DocumentGETAsync(id);
            return _mapper.Map<DocumentVM>(document);
        }

        public async Task<Response<int>> UpdateDocument(int id, DocumentVM document)
        {
            try
            {
                await AddBearerToken();
                var updateDocumentCommand = _mapper.Map<UpdateDocumentCommand>(document);
                updateDocumentCommand.DocumentId = id;
                await _client.DocumentPUTAsync(id.ToString(), updateDocumentCommand);
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