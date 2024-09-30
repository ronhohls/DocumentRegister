using AutoMapper;
using DocumentRegister.Application.Contracts.Persistence;
using DocumentRegister.Core.DTOs.Document;
using MediatR;

namespace DocumentRegister.Application.Features.Document.Queries.GetDocuments
{
	public class GetDocumentsQueryHandler : IRequestHandler<GetDocumentsQuery, List<DocumentsDto>>
	{
		private readonly IMapper _mapper;
		private readonly IDocumentRepository _documentRepository;

        public GetDocumentsQueryHandler(IMapper mapper, IDocumentRepository documentRepository) 
        {
            _mapper = mapper;
            _documentRepository = documentRepository;
        }

		public async Task<List<DocumentsDto>> Handle(GetDocumentsQuery request, CancellationToken cancellationToken)
		{
			var documents = await _documentRepository.GetAllDocumentsWithDetails();
			var data = _mapper.Map<List<DocumentsDto>>(documents);

			return data;
		}
	}
}
