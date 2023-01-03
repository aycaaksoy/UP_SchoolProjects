namespace CQRS.CQRS.Queries.ProductQueries
{
    public class GetProductAccountantByIDQuery
    {
        public GetProductAccountantByIDQuery(int id)
        {
            this.id = id;
        }

        public int id { get; set; }
    }
}
