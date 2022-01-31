using System;
//using ContactApp.NoteHandler;

namespace ContactApp
{
    internal class Program
    {

        private const string UserCommandList = "\nPlease enter your command:" +
                                                "\n1- Save note" +
                                                "\n2- Show note list" +
                                                "\n3- Save To File" +
                                                "\n0- To quit app";

        static void Main(string[] args)
        {
            var dataAccess = new DataAccess();
            var noteHandler = new NoteHandler();
            //dataAccess.LoadFile();

            while (true)
            {
                Console.WriteLine(UserCommandList);
                var userCommand = Console.ReadLine();

                switch (userCommand)
                {
                    case "1":
                        var note = noteHandler.GetOneNote();
                        dataAccess.SaveNote(note);
                        break;

                    case "2":
                        noteHandler.ShowNoteList(dataAccess);
                        break;

                    case "3":
                        dataAccess.SaveToFile();
                        break;

                    case "0":
                        Console.WriteLine("Bye. Take care!");
                        return;
                       
                    default:
                        Console.WriteLine("what did you say? i didnt get");
                        break;
                }
            }
        }
    }
}
