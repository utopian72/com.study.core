using System;
using System.Collections.Generic;

namespace com.study.core.web.menu
{
    public class MenuItem
    {
        public MenuItem(string name , string label , bool istop)
        {
            Controller = name;
            Label = label;
            IsTop = istop;
        }
        public string Controller { get; set; }
        public string Label { get; set; }

        public bool IsTop { get; set; }

        public static List<MenuItem>  CreateMenus()
        {
            var lists = new List<MenuItem>();
            lists.Add(new MenuItem("TblSurveys" , "조사" , true));
            lists.Add(new MenuItem("TblLists", "리스트" , false));
            lists.Add(new MenuItem("TblQuestions", "항목", false));


            return lists;

        }
    }
}
