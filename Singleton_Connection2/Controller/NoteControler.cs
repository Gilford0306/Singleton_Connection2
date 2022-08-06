using Singleton_Connection2.Model;
using System.Data.SqlClient;

namespace Singleton_Connection2.Controler
{
    class NoteContoller
    {
        List<Note> notes = new List<Note>();

        public NoteContoller(SqlConnection con)
        {


            using (SqlCommand cmd = new SqlCommand(" SELECT * FROM[Note].[dbo].[Notes]", con))

            {
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        notes.Add(new Note(reader.GetInt32(0), reader.GetString(1), reader.GetDateTime(2)));
                    }
                }
            }
        }

        public void Show()
        {
            foreach (var item in notes)
            {
                Console.WriteLine(item.ToString());
            }

        }
    }
}
