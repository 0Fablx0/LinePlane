﻿using LinePlaneCore.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace LinePlaneCore.Manger
{
    static internal class SaveManager
    {
        internal static ObservableCollection<SaveView> GetSaveList()
        {
            ObservableCollection<SaveView> Colection = new ObservableCollection<SaveView>();

            using (var DBContext = new LinePlaneContext())
            {
                /*foreach ( var x in DBContext.Conservations.Where(b=>b._IdUser== UserData.UserID))
                {
                    SaveView DbSave = new SaveView() { SaveName = x._FurnitureName };
                    Colection.Add(DbSave);
                }*/

            }
            return Colection;
        }

        internal static void SetSave (Canvas canvas)
        {

        }
    }
}