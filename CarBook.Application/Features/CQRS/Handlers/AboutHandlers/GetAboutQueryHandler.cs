using CarBook.Application.Features.CQRS.Results.AboutResults;
using CarBook.Application.Interface;
using CarBook.Domain.Entities;


namespace CarBook.Application.Features.CQRS.Handlers.AboutHandlers
{
    public class GetAboutQueryHandler
    {
        private readonly IRepository<About> _repository;

        public GetAboutQueryHandler(IRepository<About> repository)
        {
            _repository = repository;
        }
        public async Task<List<GetABoutQueryResult>>Handle()
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x=>new GetABoutQueryResult
            {
                Id = x.Id,
                Title = x.Title,
                Description = x.Description,
                ImageUrl = x.ImageUrl
            }).ToList();    
        }
    }
}
