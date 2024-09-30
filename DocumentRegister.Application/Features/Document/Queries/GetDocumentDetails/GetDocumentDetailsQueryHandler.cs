using AutoMapper;
using DocumentRegister.Application.Contracts.Persistence;
using DocumentRegister.Application.Exceptions;
using DocumentRegister.Core.DTOs.Document;
using MediatR;

namespace DocumentRegister.Application.Features.Document.Queries.GetDocumentDetails
{
	public class GetDocumentDetailsQueryHandler : IRequestHandler<GetDocumentDetailsQuery, DocumentDetailsDto>
	{
		private readonly IMapper _mapper;
		private readonly IDocumentRepository _documentRepository;

        public GetDocumentDetailsQueryHandler(IMapper mapper, IDocumentRepository documentRepository)
        {
			_mapper = mapper;
			_documentRepository = documentRepository;
		}

		public async Task<DocumentDetailsDto> Handle(GetDocumentDetailsQuery request, CancellationToken cancellationToken)
		{
			var document = await _documentRepository.GetDocumentWithDetails(request.DocumentId);
			if (document == null)
			{
				throw new NotFoundException(nameof(document), request.DocumentId);
			}
			var data = _mapper.Map<DocumentDetailsDto>(document);

			return data;
		}
	}
}
