using AutoMapper;
using DocumentRegister.Application.Contracts.Persistence;
using DocumentRegister.Application.Exceptions;
using MediatR;

namespace DocumentRegister.Application.Features.SegmentData.Commands.UpdateSegmentData
{
	public class UpdateSegmentDataCommandHandler : IRequestHandler<UpdateSegmentDataCommand, Unit>
	{
		private readonly IMapper _mapper;
		private readonly ISegmentDataRepository _segmentDataRepository;

        public UpdateSegmentDataCommandHandler(IMapper mapper, ISegmentDataRepository segmentDataRepository)
        {
			_mapper = mapper;
            _segmentDataRepository = segmentDataRepository;
		}

		public async Task<Unit> Handle(UpdateSegmentDataCommand request, CancellationToken cancellationToken)
		{
			var validator = new UpdateSegmentDataCommandValidator(_segmentDataRepository);
			var validationResult = await validator.ValidateAsync(request, cancellationToken);

			
			if (validationResult.Errors.Any())
			{
				throw new BadRequestException("Invalid Segment Data", validationResult);
			}

			var segmentData = await _segmentDataRepository.GetByIdAsync(request.SegmentDataId);

			if (segmentData == null)
			{
				throw new NotFoundException(nameof(segmentData), request.SegmentDataId);
			}

			_mapper.Map(request, segmentData);
			await _segmentDataRepository.UpdateAsync(segmentData);

            return Unit.Value;
		}
	}
}
