using DocumentRegister.Application.Contracts.Persistence;
using DocumentRegister.Application.Exceptions;
using MediatR;

namespace DocumentRegister.Application.Features.SegmentCategory.Commands.DeleteSegmentCategory
{
	public class DeleteSegmentCategoryCommandHandler : IRequestHandler<DeleteSegmentCategoryCommand, Unit>
	{
		private readonly ISegmentCategoryRepository _segmentCategoryRepository;
        public DeleteSegmentCategoryCommandHandler(ISegmentCategoryRepository segmentCategoryRepository)
        {
			_segmentCategoryRepository = segmentCategoryRepository;
		}
        public async Task<Unit> Handle(DeleteSegmentCategoryCommand request, CancellationToken cancellationToken)
		{
			var segmentCategory = await _segmentCategoryRepository.GetByIdAsync(request.SegmentCategoryId);

			if (segmentCategory == null)
			{
				throw new NotFoundException(nameof(segmentCategory), request.SegmentCategoryId);
			}

			await _segmentCategoryRepository.DeleteAsync(segmentCategory);

			return Unit.Value;
		}
	}
}
