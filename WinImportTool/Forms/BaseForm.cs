using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WinSCSMLiteTool.Forms
{
    public class BaseForm : Form
    {
        private readonly Color _backgroungColor = Color.AliceBlue;

        private readonly Font _defaultFont = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));

        public BaseForm()
        {
            this.Load += BaseForm_Load;
        }

        private void BaseForm_Load(object sender, EventArgs e)
        {

            var form = sender as Form;
            form.BackColor = _backgroungColor;

            //Indica los valores para todos los labels presentes
            foreach (var ctrl in form.Controls.OfType<Label>())
                (ctrl).Font = _defaultFont;

            foreach (var ctrl in form.Controls.OfType<CheckBox>())
                (ctrl).Font = _defaultFont;

            this.StartPosition = FormStartPosition.CenterParent;
        }

    }
}
