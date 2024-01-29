using Sheenam.Models.Foundations.Tokens;
using Sheenam.Models.Foundations.Users;

namespace Sheenam.Brokers.Tokens
{
    public interface ITokenBroker
    {
        UserToken GenerateJWTToken(User user);
    }
}