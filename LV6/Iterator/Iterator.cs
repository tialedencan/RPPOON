﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Iterator
{
    class Iterator:IAbstractIterator<Note>
    {
        private Notebook notebook;
        private int currentPosition;
        public Iterator(Notebook notebook)
        {
            this.notebook = notebook;
            this.currentPosition = 0;
        }
        public bool IsDone { get { return this.currentPosition >= this.notebook.Count; } }
        public Note GetCurrent { get { return this.notebook[this.currentPosition]; } }
        public Note First() { return this.notebook[0]; }
        public Note Next()
        {
            this.currentPosition++;
            if (this.IsDone)
            {
                return null;
            }
            else
            {
                return this.notebook[this.currentPosition];
            }
        }
    }
}
