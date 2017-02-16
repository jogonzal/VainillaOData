using System.ComponentModel.DataAnnotations;

namespace VainillaOData.Models
{
	public class NotebookModel
	{
		[Key]
		public string Id { get; set; }
		public string Name { get; set; }
	}
}