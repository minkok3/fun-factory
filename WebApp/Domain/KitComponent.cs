namespace WebApp.Domain
{
    public class KitComponent
    {
        public long Id { get; set; }
        public int Qty { get; set; }

        public virtual Component Kit { get; set; }
        public virtual Component Component { get; set; }

    }
}