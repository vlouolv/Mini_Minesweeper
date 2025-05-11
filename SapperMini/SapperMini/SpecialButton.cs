using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SapperMini
{
    enum InButtonObjects { Empty, Bomb }
    enum OnButtonObjects { Interactable, Activated, Flag, Question, AnInteractable}
    internal class SpecialButton : Button
    {
        private int _x = 0, _y = 0;

        private int _number = 0;

        private InButtonObjects _filling;
        private OnButtonObjects _coverage;

        public int X
        {
            get => _x; 
            set {  _x = value; } 
        }
        public int Y
        {
            get => _y;
            set { _y = value; }
        }
        public int Number
        {
            get => _number;
            set { _number = value; }
        }
        public InButtonObjects Filling
        {
            get => _filling;
            set
            { _filling = value; }
        }
        public OnButtonObjects Coverage
        {
            get => _coverage;
            set
            { _coverage = value; }
        }
    }
}
