using Base.Application.Contracts.Users;

namespace Base.Application.Mapping;

public class MappingProfile : IRegister
{
    public void Register(TypeAdapterConfig config)
    {
        config.NewConfig<RegisterRequest, ApplicationUser>()
            .Map(des => des.UserName, src => src.Email);

        config.NewConfig<CreateUserRequest, ApplicationUser>()
            .Map(des => des.UserName, src => src.Email);
    }
}
