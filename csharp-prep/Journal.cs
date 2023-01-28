using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading. Tasks;
using static System.Cosole;


namespace JournalApp

{
    class Journal

    {
        public void Run ()
        {
           DisplayIntro();

           DisplayOutro();
        }
        private void CreateJournalFile(){ }

        private void DisplayIntro(){ 

                ForegroundColor = ConsoleColor.Black;
                BackgroundColor = ConsoleColor.White;
                Clear();
             WriteLine("Journal App");
                ReadKey(true);
        }

        private void DisplayOutro () {

              WriteLine("Hi! :D ");
              ReadKey(true);
         }

        private void DisplayJournalContents (){ }

        private void ClearFile () { }

        private void AddEntry () { }
    }
     
}