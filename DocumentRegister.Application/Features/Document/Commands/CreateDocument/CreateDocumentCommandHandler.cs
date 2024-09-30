using AutoMapper;
using DocumentRegister.Application.Contracts.Persistence;
using DocumentRegister.Application.Exceptions;

using MediatR;

namespace DocumentRegister.Application.Features.Document.Commands.CreateDocument
{
	public class CreateDocumentCommandHandler : IRequestHandler<CreateDocumentCommand, int>
	{
		private readonly IMapper _mapper;
		private readonly IDocumentRepository _documentRepository;
		private readonly IDocumentSegmentRepository _documentSegmentRepository;

        public CreateDocumentCommandHandler(IMapper mapper, IDocumentRepository documentRepository, IDocumentSegmentRepository documentSegmentRepository)
        {
			_mapper = mapper;
			_documentRepository = documentRepository;
			_documentSegmentRepository = documentSegmentRepository;
		}

        //      public async Task<int> Handle(CreateDocumentCommand request, CancellationToken cancellationToken)
        //{
        //	//validation
        //	var validator = new CreateDocumentCommandValidator(_documentRepository);
        //	var validationResult = await validator.ValidateAsync(request, cancellationToken);

        //	if (validationResult.Errors.Any())
        //	{
        //              foreach (var error in validationResult.Errors)
        //              {
        //                  Console.WriteLine($"Property: {error.PropertyName} Error: {error.ErrorMessage}");
        //              }
        //              throw new BadRequestException("Invalid Document");
        //	}

        //	//get document segment entities
        //	var documentSegments = await _documentSegmentRepository.GetDocumentSegmentsByIdList(request.DocumentSegmentIds);

        //	if (documentSegments == null || documentSegments.Any() == false)
        //	{
        //		throw new ArgumentException("Invalid DocumentSegment IDs");
        //          }
        //	//map command to entity
        //          var document = _mapper.Map<DocumentRegister.Core.Entities.Document>(request);
        //	//assign document segments
        //	document.DocumentSegments = documentSegments;
        //	//create entry in database
        //          await _documentRepository.CreateAsync(document);
        //	//return id
        //	return document.DocumentId;
        //}
        public async Task<int> Handle(CreateDocumentCommand request, CancellationToken cancellationToken)
        {
            var document = _mapper.Map<DocumentRegister.Core.Entities.Document>(request.Document);

            await _documentRepository.CreateAsync(document);

            return document.DocumentId;
        }
    }
}
