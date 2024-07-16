namespace Application.DTO.Pagination
{
    public class Parameters
    {
        public int offset { get; set; }
        public int? limit { get; set; }
        public Parameters(int offset, int? limit)
        {
            this.offset = offset;
            this.limit = limit;
        }
        public Parameters() { }
    }
}
