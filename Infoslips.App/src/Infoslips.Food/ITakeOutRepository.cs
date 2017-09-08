using System.Collections.Generic;
using Infoslips.Food.Models;

namespace Infoslips.Food
{
	public interface ITakeOutRepository
	{
		IEnumerable<Restaurant> Restaurants { get; }

	}
}