using Microsoft.AspNetCore.Identity;

namespace BarilTripp.Models
{
	public class CustomIdentityValidator:IdentityErrorDescriber
	{
		public override IdentityError PasswordTooShort(int length)
		{
			return new IdentityError()
			{
				Code = "PasswordTooShort",
				Description = $"Parola Minumum {length} karakter olmalıdır"

			};
		}
	}
}
