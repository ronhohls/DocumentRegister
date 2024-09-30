using AutoMapper;
using DocumentRegister.Application.Contracts.Persistence;
using DocumentRegister.Application.Exceptions;
using MediatR;

namespace DocumentRegister.Application.Features.SegmentCategory.Commands.CreateSegmentCategory
{
	public class CreateSegmentCategoryCommandHandler : IRequestHandler<CreateSegmentCategoryCommand, int>
	{
		private readonly IMapper _mapper;
		private readonly ISegmentCategoryRepository _segmentCategoryRepository;

        public CreateSegmentCategoryCommandHandler(IMapper mapper, ISegmentCategoryRepository segmentCategoryRepository)
        {
			_mapper = mapper;
			_segmentCategoryRepository = segmentCategoryRepository;
		}

        public async Task<int> Handle(CreateSegmentCategoryCommand request, CancellationToken cancellationToken)
		{
			var validator = new CreateSegmentCategoryCommandValidator(_segmentCategoryRepository);
			var validationResult = await validator.ValidateAsync(request, cancellationToken);

			if (validationResult.Errors.Any())
			{
                foreach (var error in validationResult.Errors)
                {
                    Console.WriteLine($"Property: {error.PropertyName} Error: {error.ErrorMessage}");
                }
                throw new BadRequestException("Invalid Segment Category");
            }

			var segmentCategory = _mapper.Map<DocumentRegister.Core.Entities.SegmentCategory>(request);
			await _segmentCategoryRepository.CreateAsync(segmentCategory);

			return segmentCategory.SegmentCategoryId;
		}
	}
}
