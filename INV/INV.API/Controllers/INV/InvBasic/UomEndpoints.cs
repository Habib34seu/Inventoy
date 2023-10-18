using Carter;
using INV.Application.Features.InventoryFeatures.BasicFeatures.UomFeatures.Requests.Queries;
using MediatR;
namespace INV.API.Controllers.INV.InvBasic
{
    public class UomEndpoints : ICarterModule
    {
        public void AddRoutes(IEndpointRouteBuilder app)
        {
            var group = app.MapGroup("api/UOM");
            group.MapGet("", GetAllUnits);
            group.MapGet("{id}", GetUnitById).WithName(nameof(GetUnitById));
        }


        public static async Task<IResult> GetAllUnits(IMediator mediator)
        {
            var uoms = await mediator.Send(new GetUOMListRequest());
            return Results.Ok(uoms);
        }

        public static async Task<IResult> GetUnitById(int id,IMediator mediator)
        {
            var uom = await mediator.Send(new GetUOMByIdRequest { Id = id });
            return Results.Ok(uom);
        }
    }
}
