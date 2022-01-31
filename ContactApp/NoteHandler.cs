using System;
using System.Collections.Generic;
using System.Text;

namespace ContactApp
{
    public class NoteHandler
    {
        public Note GetOneNote()
        {
            var note = new Note();

            Console.Write("Please enter title: "); 
            note.Title = Console.ReadLine();

            Console.Write("Please enter description and the press enter: ");
            note.Description = Console.ReadLine();

            return note;
        }

        public void ShowNoteList(DataAccess dataAccess)
        {
            Console.WriteLine("This Is your note list: ");

            var noteList = dataAccess.ReturnNoteLists();
            foreach (var note in noteList)
                Console.WriteLine($"{note.Title}, {note.Description}");

            Console.WriteLine("THE END!");
            Console.WriteLine(); // one empty line
        }
    }
}
