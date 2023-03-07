using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notes.Presistance
{
    //этот класс будет создавать базу данных, если ее нет
    public class DbInitialiser
    {
        //метод, который будет создавать базу данных
        public static void Initialise(NotesDbContext context)
        {
            //если база данных уже существует, то ничего не делаем
            context.Database.EnsureCreated();
        }
    }
}
