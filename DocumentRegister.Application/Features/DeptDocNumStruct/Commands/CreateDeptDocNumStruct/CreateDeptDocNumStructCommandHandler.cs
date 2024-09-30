using AutoMapper;
using DocumentRegister.Application.Contracts.Persistence;
using DocumentRegister.Application.Exceptions;
using MediatR;


namespace DocumentRegister.Application.Features.DeptDocNumStruct.Commands.CreateDeptDocNumStruct
{
	public class CreateDeptDocNumStructCommandHandler : IRequestHandler<CreateDeptDocNumStructCommand, int>
	{
		private readonly IMapper _mapper;
		private readonly IDeptDocNumStructRepository _deptDocNumStructRepository;
		private readonly ISegmentCategoryRepository _segmentCategoryRepository;

		public CreateDeptDocNumStructCommandHandler(IMapper mapper, IDeptDocNumStructRepository deptDocNumStructRepository, ISegmentCategoryRepository segmentCategoryRepository)
		{
			_mapper = mapper;
			_deptDocNumStructRepository = deptDocNumStructRepository;
			_segmentCategoryRepository = segmentCategoryRepository;
		}

		public async Task<int> Handle(CreateDeptDocNumStructCommand request, CancellationToken cancellationToken)
		{
			//validation
			var validator = new CreateDeptDocNumStructCommandValidator(_deptDocNumStructRepository);
			var validationResult = await validator.ValidateAsync(request, cancellationToken);

			if (validationResult.Errors.Any())
			{
				foreach (var error in validationResult.Errors)
                {
                    Console.WriteLine($"Property: {error.PropertyName} Error: {error.ErrorMessage}");
                }
                throw new BadRequestException("Invalid Dept Doc Num Structure");
			}
			//get segment category entities
            var segmentCategories = await _segmentCategoryRepository.GetSegmentCategoriesByIdList(request.SegmentCategoryIds);

            if (segmentCategories == null || segmentCategories.Any() == false)
            {
                throw new ArgumentException("Invalid SegmentCategory IDs");
            }
			//map command to entity
            var deptDocNumStruct = _mapper.Map<DocumentRegister.Core.Entities.DeptDocNumStruct>(request);
			//assign segment categories
			deptDocNumStruct.SegmentCategories = segmentCategories;
			//create entry in database
			await _deptDocNumStructRepository.CreateAsync(deptDocNumStruct);

			//return id
			return deptDocNumStruct.DeptDocNumStructId;
		}
	}
}
