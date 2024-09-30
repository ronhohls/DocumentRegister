using AutoMapper;
using DocumentRegister.Application.Contracts.Persistence;
using DocumentRegister.Application.Exceptions;
using MediatR;

namespace DocumentRegister.Application.Features.SegmentData.Commands.CreateSegmentData
{
	public class CreateSegmentDataCommandHandler : IRequestHandler<CreateSegmentDataCommand, int>
	{
		private readonly IMapper _mapper;
		private readonly ISegmentDataRepository _segmentDataRepository;

        public CreateSegmentDataCommandHandler(IMapper mapper, ISegmentDataRepository segmentDataRepository)
        {
			_mapper = mapper;
            _segmentDataRepository = segmentDataRepository;
		}

        public async Task<int> Handle(CreateSegmentDataCommand request, CancellationToken cancellationToken)
		{
			//validation
			var validator = new CreateSegmentDataCommandValidator(_segmentDataRepository);
			var validationResult = await validator.ValidateAsync(request, cancellationToken);

			if (validationResult.Errors.Any())
			{
				throw new BadRequestException("Invalid Segment Data");
			}
			//map command to entity
			var segmentData = _mapper.Map<DocumentRegister.Core.Entities.SegmentData>(request);

			//create entry in database
			await _segmentDataRepository.CreateAsync(segmentData);
			//return id
			return segmentData.SegmentDataId;
		}
	}
}
