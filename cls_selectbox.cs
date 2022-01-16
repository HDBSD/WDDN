﻿
namespace SWD4CS
{
    internal class cls_selectbox
    {
        private cls_form? form;
        private cls_control? ctrl;
        private Control parent;
        private Label[] selectbox = new Label[8];
        private Point memPos;
        private int grid = 8;

        public cls_selectbox(cls_form ctrl, Control parent)
        {
            this.form = ctrl;
            this.parent = parent;

            Init();
        }
        public cls_selectbox(cls_control ctrl, Control parent)
        {
            this.ctrl = ctrl;
            this.parent = parent;

            Init();
        }

        private void Init()
        {
            // 
            // selectbox
            // 
            for (int i = 0; i < 8; i++)
            {
                this.selectbox[i] = new Label();

                if (i == 2 || i == 3)
                {
                    this.selectbox[i].Cursor = Cursors.SizeNESW;
                }
                else if (i == 0 || i == 5)
                {
                    this.selectbox[i].Cursor = Cursors.SizeNWSE;
                }
                else if (i == 1 || i == 4)
                {
                    this.selectbox[i].Cursor = Cursors.SizeNS;
                }
                else if (i == 6 || i == 7)
                {
                    this.selectbox[i].Cursor = Cursors.SizeWE;
                }

                this.selectbox[i].BorderStyle = BorderStyle.FixedSingle;
                this.selectbox[i].Size = new Size(8, 8);
                this.selectbox[i].Visible = false;
                this.selectbox[i].TabIndex = i;

                //event_handler
                this.selectbox[i].MouseDown += new MouseEventHandler(SelectboxMouseDown!);
                this.selectbox[i].MouseMove += new MouseEventHandler(SelectboxMouseMove!);
            }

            parent.Controls.AddRange(this.selectbox);
        }

        public void SetSelectBoxPos(bool flag)
        {
            if (flag)
            {
                int x1;
                int x2;
                int x3;
                int y1;
                int y2;
                int y3;

                if (ctrl != null)
                {
                    x1 = ctrl.Left - 8;
                    x2 = ctrl.Width / 2 + ctrl.Left - 4;
                    x3 = ctrl.Width + ctrl.Left;
                    y1 = ctrl.Top - 8;
                    y2 = ctrl.Height / 2 + ctrl.Top - 4;
                    y3 = ctrl.Height + ctrl.Top;
                }
                else
                {
                    x1 = form!.Left - 8;
                    x2 = form.Width / 2 + form.Left - 4;
                    x3 = form.Width + form.Left;
                    y1 = form.Top - 8;
                    y2 = form.Height / 2 + form.Top - 4;
                    y3 = form.Height + form.Top;
                }

                this.selectbox[0].Location = new Point(x1, y1);
                this.selectbox[1].Location = new Point(x2, y1);
                this.selectbox[2].Location = new Point(x3, y1);

                this.selectbox[3].Location = new Point(x1, y3);
                this.selectbox[4].Location = new Point(x2, y3);
                this.selectbox[5].Location = new Point(x3, y3);

                this.selectbox[6].Location = new Point(x1, y2);
                this.selectbox[7].Location = new Point(x3, y2);
            }

            for (int i = 0; i < 8; i++)
            {
                this.selectbox[i].Visible = flag;
            }
        }

        private void SelectboxMouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                memPos = e.Location;
            }
        }

        private void SelectboxMouseMove(object sender, MouseEventArgs e)
        {
            var move_selectbox = (Label)sender;

            if (e.Button == MouseButtons.Left)
            {
                var newPos = new Point(e.X - memPos.X + move_selectbox.Location.X, e.Y - memPos.Y + move_selectbox.Location.Y);
                move_selectbox.Location = newPos;

                if (ctrl == null)
                {
                    SetFormSize(newPos, move_selectbox.TabIndex);
                }
                else
                {
                    SetControlSize(newPos, move_selectbox.TabIndex);
                }
            }
        }

        private void SetFormSize(Point newPos, int index)
        {
            newPos.X = (int)(newPos.X / grid) * grid;
            newPos.Y = (int)(newPos.Y / grid) * grid;

            int width = newPos.X - form!.Left;
            int height = newPos.Y - form.Top;

            switch (index)
            {
                case 3:
                case 4:
                    form.Height = height;
                    break;
                case 5:
                    form.Width = width;
                    form.Height = height;
                    break;
                case 2:
                case 7:
                    form.Width = width;
                    break;
            }

            if (form.Width < 160)
            {
                form.Width = 160;
            }

            if (form.Height < 40)
            {
                form.Height = 40;
            }

            form.SetSelect(true);
        }

        private void SetControlSize(Point newPos, int index)
        {
            newPos.X = (int)(newPos.X / grid) * grid;
            newPos.Y = (int)(newPos.Y / grid) * grid;

            int width = newPos.X - ctrl!.Left;
            int height = newPos.Y - ctrl.Top;
            int width2 = ctrl.Width - (newPos.X + 8 - ctrl.Left);
            int height2 = ctrl.Height - (newPos.Y + 8 - ctrl.Top);
            int memleft = ctrl.Left;
            int memtop = ctrl.Top;

            switch (index)
            {
                case 0:
                    ctrl.Left = newPos.X + 8;
                    ctrl.Top = newPos.Y + 8;
                    ctrl.Width = width2;
                    ctrl.Height = height2;
                    break;
                case 1:
                    ctrl.Top = newPos.Y + 8;
                    ctrl.Height = height2;
                    break;
                case 2:
                    ctrl.Top = newPos.Y + 8;
                    ctrl.Height = height2;
                    ctrl.Width = width;
                    break;
                case 3:
                    ctrl.Left = newPos.X + 8;
                    ctrl.Width = width2;
                    ctrl.Height = height;
                    break;
                case 4:
                    ctrl.Height = height;
                    break;
                case 5:
                    ctrl.Width = width;
                    ctrl.Height = height;
                    break;
                case 6:
                    ctrl.Left = newPos.X + 8;
                    ctrl.Width = width2;
                    break;
                case 7:
                    ctrl.Width = width;
                    break;
            }

            if (ctrl.Width < 24)
            {
                ctrl.Width = 24;
                ctrl.Left = memleft;
            }

            if (ctrl.Height < 24)
            {
                ctrl.Height = 24;
                ctrl.Top = memtop;
            }

            ctrl.Selected = true;
        }
    }
}
