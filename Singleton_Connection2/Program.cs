using Singleton_Connection2.Controler;

ConnectionControler controller1 = new ConnectionControler(@"D:\Projects\Singleton_Connection2\Singleton_Connection2\Connection_String\setting.json");
controller1.Download();
NoteContoller noteTable = new NoteContoller(SingletonConnection.GetInstance(controller1.defaultsetting).GetConnection());
noteTable.Show();
Console.WriteLine("==========================");
noteTable = new NoteContoller(SingletonConnection.GetInstance(controller1.defaultsetting).GetConnection());
noteTable.Show();