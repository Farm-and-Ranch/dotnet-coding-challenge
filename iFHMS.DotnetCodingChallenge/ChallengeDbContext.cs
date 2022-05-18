using Microsoft.EntityFrameworkCore;

namespace iFHMS.DotnetCodingChallenge;

public class ChallengeDbContext : DbContext
{
    public ChallengeDbContext(DbContextOptions<ChallengeDbContext> options)
        : base(options)
    {
    }

}
