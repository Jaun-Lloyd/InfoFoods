using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Infoslips.Food.Models
{
	public class Restaurant
	{
		public string Name { get; set; }
		public List<MenuItems> MenuItems { get; set; }
	}
}
