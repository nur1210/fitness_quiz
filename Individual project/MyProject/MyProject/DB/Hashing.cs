using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.DB
{
    public static class Hashing
    {
		public static string GenerateSalt()
		{
			return BCrypt.Net.BCrypt.GenerateSalt();
		}

		public static string HashPassword(string password)
		{
			return BCrypt.Net.BCrypt.HashPassword(password, GenerateSalt());
		}

		public static bool ValidatePassword(string password, string correctHash)
		{
			return BCrypt.Net.BCrypt.Verify(password, correctHash);
		}
	}
}
