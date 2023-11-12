using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Modelo_EOQ_Basico
{
    //Proyecto elebaorado por Angel David Zavala Rodriguez, Alan Salgado Salas, Brian Menendez Lopez

    public partial class Form1 : MaterialForm
    {
        public Form1()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            //materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void rbtnCostoTotal_CheckedChanged(object sender, EventArgs e)
        {
            elementosVisibles();
        }

        private void rbtnVolOrden_CheckedChanged(object sender, EventArgs e)
        {
            elementosVisibles();
        }

        private void rbtnNumeroOrdenes_CheckedChanged(object sender, EventArgs e)
        {
            elementosVisibles();
        }

        private void rbtnTiempoOrdenes_CheckedChanged(object sender, EventArgs e)
        {
            elementosVisibles();
        }

        private void rbtnDemandaDia_CheckedChanged(object sender, EventArgs e)
        {
            elementosVisibles();
        }

        private void rbtnPuntoReorden_CheckedChanged(object sender, EventArgs e)
        {
            elementosVisibles();
        }

        public void borrarCajasTexto() 
        {
            checkBoxDias1.Checked = false;
            checkBoxDias2.Checked = false;
            txtCant1.ReadOnly = false; txtCant2.ReadOnly = false;
            txtCant1.Text = "";
            txtCant2.Text = "";
            txtCant3.Text = "";
            txtCant4.Text = "";
            txtCant5.Text = "";
            txtCant6.Text = "";
        }

        public void cartasVisibles(bool card1, bool card2, bool card3, bool card4, bool card5, bool card6) {
            Card1.Visible = card1;
            Card2.Visible = card2;
            Card3.Visible = card3;
            Card4.Visible = card4;
            Card5.Visible = card5;
            Card6.Visible = card6;
        }

        public void elementosVisibles()
        {
            if (rbtnCostoTotal.Checked) 
            {
                borrarCajasTexto();
                cartasVisibles(true, true, true, true, true, false);
                checkBoxDias1.Visible = false; checkBoxDias2.Visible = false;
                lbl1.Text = "Introduce la demanda anual (D)";
                lbl2.Text = "Introduce el costo por unidad (C)";
                lbl3.Text = "Introduce el Volumen de orden (Q)";
                lbl4.Text = "Introduce el costo de preparacion (K)";
                lbl5.Text = "Introduce el Costo anual de mantener inventario (h)";
            }
            else if (rbtnVolOrden.Checked)
            {
                borrarCajasTexto();
                cartasVisibles(true, true, true, false, false, false);
                checkBoxDias1.Visible = false; checkBoxDias2.Visible = false;
                lbl1.Text = "Introduce la demanda anual (D)";
                lbl2.Text = "Introduce el costo de preparacion (K)";
                lbl3.Text = "Introduce Costo anual de mantener inventario (h)";
            }
            else if (rbtnNumeroOrdenes.Checked)
            {
                borrarCajasTexto();
                cartasVisibles(true, true, false, false, false, false);
                checkBoxDias1.Visible = false; checkBoxDias2.Visible = false;
                lbl1.Text = "Introduce la demanda anual (D)";
                lbl2.Text = "Introduce el volumen de orden (Q)";
            }
            else if (rbtnTiempoOrdenes.Checked)
            {
                borrarCajasTexto();
                cartasVisibles(true, true, false, false, false, false);
                checkBoxDias1.Visible = true; checkBoxDias2.Visible = false;
                lbl1.Text = "Introduce el numero de dias habiles al año";
                lbl2.Text = "Introduce el numero de ordenes al año (N)";
                txtCant1.Text = "360";
                txtCant1.ReadOnly = true;

            }
            else if (rbtnDemandaDia.Checked)
            {
                borrarCajasTexto();
                cartasVisibles(true, true, false, false, false, false);
                checkBoxDias1.Visible = false; checkBoxDias2.Visible = true;
                lbl1.Text = "Introduce la demanda anual (D)";
                lbl2.Text = "Introduce el numero de dias habiles al año";
                txtCant2.Text = "360";
                txtCant2.ReadOnly = true;
            }
            else if (rbtnPuntoReorden.Checked)
            {
                borrarCajasTexto();
                cartasVisibles(true, true, false, false, false, false);
                checkBoxDias1.Visible = false; checkBoxDias2.Visible = false;
                lbl1.Text = "Introduce la demanda por dia (d)";
                lbl2.Text = "Introduce el tiempo de entrega (L)";
            }

        }

        private void checkBoxDias1_CheckedChanged(object sender, EventArgs e)
        {
            manejoCheckBox(checkBoxDias1, txtCant1);
        }

        private void manejoCheckBox(System.Windows.Forms.CheckBox checkBox, MaterialSkin.Controls.MaterialMultiLineTextBox2 textBox)
        {
            if (checkBox.Checked)
            {
                textBox.ReadOnly = false;
                textBox.Text = "";
            }
            else
            {
                textBox.ReadOnly = true;
                textBox.Text = "360";
            }
        }

        private void checkBoxDias2_CheckedChanged(object sender, EventArgs e)
        {
            manejoCheckBox(checkBoxDias2, txtCant2);
        }
    }
}
