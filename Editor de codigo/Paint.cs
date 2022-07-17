﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Editor_de_codigo
{
    public partial class Paint : Form
    {
        public Paint()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ColorDialog MyDialog = new ColorDialog();
            // Evita que el usuario seleccione un color personalizado.
            MyDialog.AllowFullOpen = false;
            // Permite al usuario obtener ayuda. (El valor predeterminado es falso.)
            MyDialog.ShowHelp = true;
            // Establece la selección de color inicial en el color de texto actual.
            MyDialog.Color = txtcolor.ForeColor;

            // Actualizar el color del cuadro de texto si el usuario hace clic en Aceptar
            if (MyDialog.ShowDialog() == DialogResult.OK)
                txtcolor.ForeColor = MyDialog.Color;
            txtcolor.BackColor = MyDialog.Color;
        }
    }
}
