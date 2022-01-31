using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ContactApp
{
    public class DataAccess
    {
        public const string NoteListFile = "NoteList.csv";
        public List<Note> Notes { get; set; }

        public DataAccess()
        {
            Notes = LoadFile();
        }

        #region Note

        public Note SaveNote(Note note)
        {
            Notes.Add(note);

            return note;
        }

        public List<Note> ReturnNoteLists()
        {
            return Notes;
        }

        #endregion

        #region File
        public List<Note> LoadFile()
        {
            var filePath = FullFilePath();

            if (!File.Exists(filePath))
                return new List<Note> ();

            var lines = File.ReadAllLines(filePath).ToList(); 
            var tmpNotes = new List<Note>(); 

            foreach (var line in lines)
            {
                var tmp = line.Split(',');
                tmpNotes.Add(new Note(tmp[0], tmp[1]));
            }

            return tmpNotes;
        }

        public bool SaveToFile()
        {
            try
            {
                var lines = new StringBuilder();

                foreach (var item in Notes)
                    lines.Append($"{item.Title},{item.Description}\n");

                File.WriteAllText(FullFilePath(), lines.ToString(), Encoding.UTF8);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }

            return true;
        }

        public static string FullFilePath(string fileName = NoteListFile)
        {
            return @"C:\Users\mrsmile\source\repos\ContactAppSolution\ContactApp\NoteList.csv";
            //return $"{ConfigurationManager.AppSettings["filePath"]}\\{fileName}";
        }
        #endregion
    }
}
