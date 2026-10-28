using Microsoft.AspNetCore.Identity;

namespace Ecotech.Data;

// IdentityUser already has Id, Email, UserName, PasswordHash, lockout fields, etc.
// Add your own profile columns here later.
public class ApplicationUser : IdentityUser
{
}
