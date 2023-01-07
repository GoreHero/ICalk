using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ICalk
{
    class MyCommands
    {
        public static RoutedCommand Exit { get; set; } 
        public static RoutedCommand Del { get; set; }
        public static RoutedCommand Btn0 { get; set; }


        static MyCommands()
        {
            //InputGestureCollection inputDel = new InputGestureCollection();
            //InputGestureCollection inputBtn0 = new InputGestureCollection();

            //inputDel.Add(new KeyGesture(Key.Delete,ModifierKeys.Control));
            //inputBtn0.Add(new KeyGesture(Key.NumPad0 ,ModifierKeys.Control));

            Exit = new RoutedCommand();
            //Del = new RoutedCommand("Delit", typeof(MyCommands),inputDel);
            //Btn0 = new RoutedCommand("Delit", typeof(MyCommands),inputBtn0);

        }

        
    }
}
