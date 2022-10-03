namespace customerapp.model
{
    public class customerClass
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public static List<customerClass> GetAllcustomer()
        {
            List<customerClass> customers = new()
        {
        new customerClass() { Id=1, Name= "priya" },
        new customerClass() { Id=2, Name= "swathi" },
        new customerClass() { Id=3, Name= "swetha" },
        new customerClass() { Id=4, Name= "kanmani" }
      

        };

            return customers;
        }



    }
}
