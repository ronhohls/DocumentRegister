using AutoMapper;
using DocumentRegister.Application.Contracts.Persistence;
using DocumentRegister.Application.Exceptions;
using MediatR;

namespace DocumentRegister.Application.Features.DeptDocNumStruct.Commands.UpdateDeptDocNumStruct
{
	public class UpdateDeptDocNumStructCommandHandler : IRequestHandler<UpdateDeptDocNumStructCommand, Unit>
	{
		private readonly IMapper _mapper;
		private readonly IDeptDocNumStructRepository _deptDocNumStructRepository;
		private readonly ISegmentCategoryRepository _segmentCategoryRepository;

        public UpdateDeptDocNumStructCommandHandler(IMapper mapper, IDeptDocNumStructRepository deptDocNumStructRepository, ISegmentCategoryRepository segmentCategoryRepository)
        {
			_mapper = mapper;
            _deptDocNumStructRepository = deptDocNumStructRepository;
			_segmentCategoryRepository = segmentCategoryRepository;
        }

		public async Task<Unit> Handle(UpdateDeptDocNumStructCommand request, CancellationToken cancellationToken)
		{
			//validation 
			var validator = new UpdateDeptDocNumStructCommandValidator(_deptDocNumStructRepository);
			var validationResult = await validator.ValidateAsync(request, cancellationToken);

			if (validationResult.Errors.Any())
			{
				throw new BadRequestException("Invalid Dept Doc Num Structure", validationResult);
			}

            var deptDocNumStruct = await _deptDocNumStructRepository.GetDeptDocNumStructWithDetails(request.DeptDocNumStructId);
            //var deptDocNumStruct = _mapper.Map<DocumentRegister.Core.Entities.DeptDocNumStruct>(request);

            if (deptDocNumStruct == null)
			{
				throw new NotFoundException(nameof(deptDocNumStruct), request.DeptDocNumStructId);
			}

			var segmentCategories = await _segmentCategoryRepository.GetSegmentCategoriesByIdList(request.SegmentCategoryIds);

            if (segmentCategories == null || segmentCategories.Any() == false)
            {
                throw new ArgumentException("Invalid SegmentCategory IDs");
            }
			deptDocNumStruct.Seperator = request.Seperator;
			deptDocNumStruct.Description = request.Description;

			//clear and add segment categories currently selected
			deptDocNumStruct.SegmentCategories.Clear();

            foreach (var segmentCategory in segmentCategories)
			{
				deptDocNumStruct.SegmentCategories.Add(segmentCategory);
			}

            //_mapper.Map(request, deptDocNumStruct);
			await _deptDocNumStructRepository.UpdateAsync(deptDocNumStruct);

            return Unit.Value;
		}
	}
}
