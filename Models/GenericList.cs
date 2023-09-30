namespace ProvaPub.Models
{
    public class GenericList<T>
    {
        public List<T> Items { get; set; }
        public int TotalCount { get; set; }
        public bool HasNext { get; set; }

        public GenericList<T> ListItems<T>(int page, List<T> Data)
        {
            var list = new GenericList<T>()
            {
                HasNext = false,
                TotalCount = 10,
                Items = Data.Skip(page > 0 ? (page - 1) * 10 : 0).Take(10).ToList()
            };

            return list;
        }
    }    
}
