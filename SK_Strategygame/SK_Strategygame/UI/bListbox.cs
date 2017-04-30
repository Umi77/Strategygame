﻿using AGFXLib.Drawables;
using OpenTK.Input;
using System.Collections.Generic;

namespace SK_Strategygame.UI
{
    class bListbox : Drawable
    {
        public Rect rectangle_border;
        public Rect rectangle_background;
        public Rect selection_rectangle;
        public List<bListboxEntry> entries;
        public bScrollbar scrollbar;
        public int selectedIndex;
        public float x;
        public float y;
        public float w;
        public float h;

        public bListbox ()
        {
            x = 20;
            y = 20;
            w = 300;
            h = 500;
            rectangle_background = new Rect(new Quad(20, 20, 300, 500), "fill", new DrawColor(255,255,255));
            rectangle_border = new Rect(new Quad(20, 20, 300, 500), "line", new DrawColor(0,0,255));
            selection_rectangle = new Rect(new Quad(0, 0, 1, 1), "fill", new DrawColor(0, 0, 0, 0));
            entries = new List<bListboxEntry>();
            scrollbar = new bScrollbar((int)x+(int)w-16, (int)y, 16, (int)h);
        }

        public void Add (string entry)
        {
            bListboxEntry e = new bListboxEntry(this, entry);
            e.index = entries.Count;
            entries.Add(e);
        }

        public override void Draw(DrawManager parent)
        {
            rectangle_background.Draw(parent);
            rectangle_border.Draw(parent);

            foreach (bListboxEntry bleh in entries)
                bleh.Draw(parent);
            scrollbar.Draw(parent);
        }

        public override void OnKeyDown(DrawManager parent, KeyboardKeyEventArgs key) { }
        public override void OnKeyUp(DrawManager parent, KeyboardKeyEventArgs key) { }
        public override void OnMouseDown(DrawManager parent, MouseButtonEventArgs button) { }
        public override void OnMouseUp(DrawManager parent, MouseButtonEventArgs button) { }
    }
}
