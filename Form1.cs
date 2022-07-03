using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListasI
{
    public partial class Form1 : Form
    {
        private string[] cadenas;

        public Form1()
        {
            InitializeComponent();
            actualizaElementos();
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            escogerOpcionAñadir(compruebaRadioButton());
            actualizaElementos();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            revisarItems(compruebaRadioButton());
            actualizaElementos();
        }

        private void actualizaElementos()
        {
            lblListBox.Text = listBox.Items.Count.ToString();
            lblComboBox.Text = comboBox.Items.Count.ToString();
            lblCheckedListBox.Text = checkedListBox.Items.Count.ToString();
        }

        private int compruebaRadioButton()
        {
            int num = 0;
            if (rButListBox.Checked) { num = 1; }
            if (rButComboBox.Checked) { num = 2; }
            if (rButCheckListBox.Checked) { num = 3; }
            return num;
        }

        private void escogerOpcionAñadir(int n)
        {
            if (n == 1) { añadirListBox(); }
            if (n == 2) { añadirComboBox(); }
            if (n == 3) { añadirCheckedListBox(); }
        }

        private void añadirListBox()
        {
            listBox.Items.Add(txtBoxEntrada.Text);
        }

        private void añadirComboBox()
        {
            comboBox.Items.Add(txtBoxEntrada.Text);
        }

        private void añadirCheckedListBox()
        {
            checkedListBox.Items.Add(txtBoxEntrada.Text);
            //añadirSeleccionMultiple();
        }

        private void revisarItems(int n)
        {
            if (n == 1) { cadenas = new string[listBox.Items.Count]; eliminarListBox(); }
            if (n == 2) { cadenas = new string[comboBox.Items.Count]; eliminarComboBox(); }
            if (n == 3) { cadenas = new string[checkedListBox.Items.Count]; eliminarCheckedListBox(); }
        }

        private void eliminarListBox()
        {
            listBox.Items.Remove(txtBoxEntrada.Text);
        }

        private void eliminarComboBox()
        {
            comboBox.Items.Remove(txtBoxEntrada.Text);
        }

        private void eliminarCheckedListBox()
        {
            checkedListBox.Items.Remove(txtBoxEntrada.Text);
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            eligeSeleccion(compruebaRadioButton());
        }

        private void eligeSeleccion(int n)
        {
            if (n == 1) { escogerSeleccionadoSimpleListBox(); }
            if (n == 2) { escogerSeleccionadoSimpleComboBox(); }
            if (n == 3) { escogerSeleccionadoMultiple(); }
        }

        private void escogerSeleccionadoSimpleListBox()
        { txtBoxSeleccion.Text = listBox.SelectedItem.ToString(); }

        private void escogerSeleccionadoSimpleComboBox()
        { txtBoxSeleccion.Text = comboBox.SelectedItem.ToString(); }

        private void escogerSeleccionadoMultiple()
        {
            lstBoxSeleccion.Items.Clear();
            CheckedListBox.CheckedItemCollection itemsSeñalados = checkedListBox.CheckedItems;
            List<object> listaSeñalados = new List<object>();
            foreach (object check in itemsSeñalados) 
                { listaSeñalados.Add(check); }
            //lstBoxSeleccion.Items.Add(listaSeñalados.ToArray());
            lstBoxSeleccion.Items.AddRange(listaSeñalados.ToArray());
        }

        private void añadirSeleccionMultiple()
        {
            lstBoxSeleccion.Items.Add(txtBoxEntrada.Text);
        }
    }
}

