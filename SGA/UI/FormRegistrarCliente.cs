using BLL.Services;
using DOM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
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
            label13.Visible= false;
            label14.Visible= false;
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
            cliente.nacimiento=dateTimePicker1.Value;
            cliente.usuario.alias=textBox9.Text;
            cliente.usuario.email = textBox10.Text;
            cliente.usuario.contraseña=textBox11.Text;
            cliente.usuario.confirma=textBox12.Text;
            cliente.usuario.perfil = "cliente";
           

            if (checkBox1.Checked)
            {

                var token = textBox13.Text;
                var chatid= textBox14.Text;

            }
            List<ValidationResult> errors = new List<ValidationResult>();

            ValidationContext validationContextCliente = new ValidationContext(cliente, null, null);
            Validator.TryValidateObject(cliente, validationContextCliente, errors, true);

            ValidationContext validationContextUsuario = new ValidationContext(cliente.usuario, null, null);
            Validator.TryValidateObject(cliente.usuario, validationContextUsuario, errors, true);


            if (errors.Count() > 0)
            {
                string errorMessages = string.Empty;

                foreach (var error in errors)
                {
                    errorMessages += error.ErrorMessage + Environment.NewLine;
                }
                MessageBox.Show(errorMessages);
            }
            else
            {
                ClienteService.Current.Create(cliente);
                UsuarioService.Current.Create(cliente.usuario);

                MessageBox.Show("Cliente registrado!");

                LimpiarCampos();
            }


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
