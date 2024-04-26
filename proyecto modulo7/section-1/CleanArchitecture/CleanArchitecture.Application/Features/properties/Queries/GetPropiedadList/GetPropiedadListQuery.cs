using MediatR;


namespace CleanArchitecture.Application.Features.properties.Queries.GetPropiedadList
{
    public class GetPropiedadListQuery : IRequest<List<PropiedadVm>>
    {
        public string _Username { get; set; } = string.Empty;
        public GetPropiedadListQuery(string username)
        {
            _Username = username ?? throw new ArgumentNullException(nameof(username));
        }
    }
}
