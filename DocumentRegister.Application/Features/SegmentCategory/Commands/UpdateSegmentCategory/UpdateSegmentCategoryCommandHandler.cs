using AutoMapper;
using DocumentRegister.Application.Contracts.Persistence;
using DocumentRegister.Application.Exceptions;
using MediatR;

namespace DocumentRegister.Application.Features.SegmentCategory.Commands.UpdateSegmentCategory
{
	public class UpdateSegmentCategoryCommandHandler : IRequestHandler<UpdateSegmentCategoryCommand, Unit>
	{
		private readonly IMapper _mapper;
		private readonly ISegmentCategoryRepository _segmentCategoryRepository;

        public UpdateSegmentCategoryCommandHandler(IMapper mapper, ISegmentCategoryRepository segmentCategoryRepository)
        {
			_mapper = mapper;
			_segmentCategoryRepository = segmentCategoryRepository;
		}

		public async Task<Unit> Handle(UpdateSegmentCategoryCommand request, CancellationToken cancellationToken)
		{
			var validator = new UpdateSegmentCategoryCommandValidator(_segmentCategoryRepository);
			var validationResult = await validator.ValidateAsync(request, cancellationToken);

			if (validationResult.Errors.Any())
			{
				throw new BadRequestException("Invalid Segment Category", validationResult);
			}

			var segmentCategory = await _segmentCategoryRepository.GetByIdAsync(request.SegmentCategoryId);

			if (segmentCategory == null)
			{
				throw new NotFoundException(nameof(segmentCategory), request.SegmentCategoryId);
			}

			_mapper.Map(request, segmentCategory);
			await _segmentCategoryRepository.UpdateAsync(segmentCategory);

            return Unit.Value;
		}
	}
}
