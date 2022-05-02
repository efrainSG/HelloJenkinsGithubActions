namespace HelloJenkins.BL
{
    public class BusinessLogic : IBusinessLogic
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public string SayHello()
        {
            return $"Hello, {Name}.";
        }

        public string SayHelloAsync()
        {
            return $"Hello, {Name} asyncronously.\n{Description}.";
        }
    }
}