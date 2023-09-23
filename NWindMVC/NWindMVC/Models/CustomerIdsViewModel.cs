using Microsoft.AspNetCore.Mvc.Rendering;

namespace NWindMVC.Models
{
    public class CustomerIdsViewModel
    {
        public int Id { get; set; }
        public readonly List<SelectListItem> CustomerIdSelectedList;
        public CustomerIdsViewModel(List<string> customerIds)
        {
            CustomerIdSelectedList = new List<SelectListItem>();
            foreach (var no in customerIds)
            {
                CustomerIdSelectedList.Add(new SelectListItem { Text = $"{no}", Value = $"{no}" });
            }
        }
    }
}
