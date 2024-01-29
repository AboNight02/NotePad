using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace NotePadMoon
{
    public partial class NotePad : Form
    {
        private Point panelMouseDownLocation;
        public void AttachToPanel(Label panel, Form form)
        {
            // Lambda Expression --> (=>)
            panel.MouseDown += (sender, e) =>
            {
                if (e.Button == MouseButtons.Left)
                {
                    panelMouseDownLocation = e.Location;
                }
            };

            panel.MouseMove += (sender, e) =>
            {
                if (e.Button == MouseButtons.Left)
                {
                    form.Left = e.X + form.Left - panelMouseDownLocation.X;
                    form.Top = e.Y + form.Top - panelMouseDownLocation.Y;
                }
            };
        }

        DataTable notes = new DataTable();
        bool Editing = false;
        
        private void NotePad_Load(object sender, EventArgs e)
        {
            notes.Columns.Add("Title");
            notes.Columns.Add("Note");

            DGview.DataSource = notes;
        }
        public NotePad()
        {
            InitializeComponent();
            AttachToPanel(label2, this);
        }

        private void Panel_control_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Menu_Click(object sender, EventArgs e)
        {
            if (!DGview.Visible)
            {
                DGview.Visible = true;
            }
            else
            {
                DGview.Visible = false;
            }
        }

        private void exalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void newNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TxtTitle.Text = "";
            NoteBody.Text = "";
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                notes.Rows[DGview.CurrentCell.RowIndex].Delete();
            }
            catch (Exception)
            {

                MessageBox.Show("Note is Not found..!");
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                TxtTitle.Text = notes.Rows[DGview.CurrentCell.RowIndex].ItemArray[0].ToString();
                NoteBody.Text = notes.Rows[DGview.CurrentCell.RowIndex].ItemArray[1].ToString();
                Editing = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Not Found");
            }

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Editing)
            {
                notes.Rows[DGview.CurrentCell.RowIndex]["Title"] = TxtTitle.Text;
                notes.Rows[DGview.CurrentCell.RowIndex]["Note"] = TxtTitle.Text;
            }
            else
            {
                notes.Rows.Add(TxtTitle.Text,NoteBody.Text);
            }
            TxtTitle.Text = "";
            NoteBody.Text = "";
            Editing = false;
        }

        private void DGview_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                TxtTitle.Text = notes.Rows[DGview.CurrentCell.RowIndex].ItemArray[0].ToString();
                NoteBody.Text = notes.Rows[DGview.CurrentCell.RowIndex].ItemArray[1].ToString();
                Editing = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Not Found");
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Title = "Save File";
                sfd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                sfd.FileName = TxtTitle.Text + ".txt";
                //"Untitle.txt"
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (Path.GetExtension(sfd.FileName).ToLower() != ".txt")
                    {
                        sfd.FileName += ".txt";
                    }
                    StreamWriter sw = new StreamWriter(sfd.FileName);
                    sw.WriteLine(NoteBody.Text);
                    sw.Close();
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Not File to save");
            }

            
        }
    }
}
