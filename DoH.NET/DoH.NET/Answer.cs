namespace DoH.NET
{
    public class Answer
    {
        public string name { get; set; }
        public int type { get; set; }
        public int TTL { get; set; }
        public string data { get; set; }

        public override string ToString()
        {
            return $"{name} --> {data}";
        }
    }
}
