using AutoMapper;
using DocumentRegister.Application.Contracts.Persistence;
using DocumentRegister.Application.Exceptions;
using DocumentRegister.Core.DTOs.SegmentCategory;
using MediatR;

namespace DocumentRegister.Application.Features.DeptDocNumStruct.Queries.GetSegmentCategories
{
    public class GetSegmentCategoriesQueryHandler : IRequestHandler<GetSegmentCategoriesQuery, List<SegmentCategoryDetailsDto>>
    {
        private readonly IMapper _mapper;
        private readonly IDeptDocNumStructRepository _deptDocNumStructRepository;
        public GetSegmentCategoriesQueryHandler(IMapper mapper, IDeptDocNumStructRepository deptDocNumStructRepository)
        {
            _mapper = mapper;
            _deptDocNumStructRepository = deptDocNumStructRepository;
        }
        public async Task<List<SegmentCategoryDetailsDto>> Handle(GetSegmentCategoriesQuery request, CancellationToken cancellationToken)
        {
            var deptDocNumStruct = await _deptDocNumStructRepository.GetDeptDocNumStructWithDetails(request.DeptDocNumStructId);
            if (deptDocNumStruct == null)
            {
                throw new NotFoundException(nameof(deptDocNumStruct), request.DeptDocNumStructId);
            }

            List<SegmentCategoryDetailsDto> categories = new List<SegmentCategoryDetailsDto>();
            return null;
        }
    }
}
