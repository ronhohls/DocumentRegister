using DocumentRegister.Application.Contracts.Persistence;
using DocumentRegister.Application.Exceptions;
using MediatR;

namespace DocumentRegister.Application.Features.SegmentData.Commands.DeleteSegmentData
{ 
	public class DeleteSegmentDataCommandHandler : IRequestHandler<DeleteSegmentDataCommand, Unit>
	{
		private readonly ISegmentDataRepository _segmentDataRepository;
        public DeleteSegmentDataCommandHandler(ISegmentDataRepository segmentDataRepository)
        {
			_segmentDataRepository = segmentDataRepository;
		}
        public async Task<Unit> Handle(DeleteSegmentDataCommand request, CancellationToken cancellationToken)
		{
			var segmentData = await _segmentDataRepository.GetByIdAsync(request.SegmentDataId);

			if (segmentData == null)
			{
				throw new NotFoundException(nameof(segmentData), request.SegmentDataId);
			}

			await _segmentDataRepository.DeleteAsync(segmentData);

			return Unit.Value;
		}
	}
}
