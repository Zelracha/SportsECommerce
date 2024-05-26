namespace SportsECommerce.Models.ViewModel
{
    public class PagingInfo
    {
        // Tag helper: pass the information to the view about the number of pages available, current pages, and total number of products
        public int TotalItems { get; set; }
        public int ItemsPerPage { get; set; }
        public int CurrentPage { get; set; }

        public int TotalPages => (int)Math.Ceiling((decimal)TotalItems / ItemsPerPage);
    }
}
