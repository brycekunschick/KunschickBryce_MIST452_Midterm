using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace KunschickMidterm452.Models.ViewModels
{
    public class RequestWithOfficersVM
    {
        public Request Request { get; set; }

        [ValidateNever]
        public IEnumerable<SelectListItem> ListOfOfficers { get; set; }
    }
}
