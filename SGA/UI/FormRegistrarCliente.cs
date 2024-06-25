﻿using BLL;
using DOM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class FormRegistrarCliente : Form
    {
        

        public FormRegistrarCliente()
        {
            InitializeComponent();
            textBox13.Visible= false;
            textBox14.Visible= false;
        }

        private void button1_Click(object sender, EventArgs e)
        {

           Cliente cliente = new Cliente();

            cliente.dni=textBox1.Text;
            cliente.nombre=textBox2.Text;
            cliente.apellido=textBox3.Text;
            cliente.empresa=textBox4.Text;
            cliente.direccion=textBox5.Text;
            cliente.cuilcuit=textBox6.Text;
            cliente.telefono=textBox7.Text;
            cliente.codigopostal=textBox8.Text;
            cliente.usuario.alias=textBox9.Text;
            cliente.usuario.contraseña=textBox10.Text;
            cliente.usuario.email=textBox12.Text;

            if (checkBox1.Checked)
            {

                var token = textBox13.Text;
                var chatid= textBox14.Text;

            }

            BLLCliente bllcliente = new BLLCliente();
            bllcliente.Create(cliente);

            LimpiarCampos();


        }

        private void LimpiarCampos()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            textBox10.Text = "";
            textBox11.Text = "";
            textBox12.Text = "";
            textBox13.Text = "";
            textBox14.Text = "";

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            label13.Visible=checkBox1.Checked;
            label14.Visible = checkBox1.Checked;
            textBox13.Visible = checkBox1.Checked;
            textBox14.Visible = checkBox1.Checked;

        }
    }
}
