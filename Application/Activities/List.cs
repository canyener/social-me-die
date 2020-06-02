using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Domain;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Activities
{
  public class List
  {
    public class Query : IRequest<List<Activity>> { }
    public class Handler : IRequestHandler<Query, List<Activity>>
    {
      private readonly DataContext _dataContext;
      public Handler(DataContext dataContext)
      {
        _dataContext = dataContext;
      }

      public async Task<List<Activity>> Handle(Query request, CancellationToken cancellationToken)
      {
        var activities = await _dataContext.Activities.ToListAsync();

        return activities;
      }
    }
  }
}