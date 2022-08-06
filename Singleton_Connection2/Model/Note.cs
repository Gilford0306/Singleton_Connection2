namespace Singleton_Connection2.Model
{
    internal class Note
    {
        public int id { get; set; }
        public string note_text { get; set; }
        public DateTime date { get; set; }

        public override string ToString()
        {
            string dateonly = date.ToString();
            string [] day = dateonly.Split(" ");
            return $"{id}) Note text:{note_text} - Date:{day[0]}\n";
        }
        private Note()
        {}
        public Note(int id, string note_text, DateTime date)
        {
            this.id = id;
            this.note_text = note_text;
            this.date = date;   
        }

    }
}
