namespace ListPractice
{
    internal class BaseEntity
    {
        private static int _id;
        public int Id { get;}
        public BaseEntity()
        {
            _id++;
            Id = _id;
        }
    }
}
