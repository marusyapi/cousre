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
using Course_Pituykova.Forms;

namespace Course_Pituykova
{
    public partial class Form1 : Form
    {
        List<Abiturient> abiturient = new List<Abiturient>();

        private void Read_List(string file) // считывание данных с текстового документа
        {
            StreamReader stream = new StreamReader(file);
            abiturient.Clear();

            while (stream.ReadLine() == "^_^")
            {
                abiturient.Add(new Abiturient());
                abiturient[abiturient.Count - 1] = new Abiturient();

                abiturient[abiturient.Count - 1].Surname = stream.ReadLine();
                abiturient[abiturient.Count - 1].Name = stream.ReadLine();
                abiturient[abiturient.Count - 1].Patronymic = stream.ReadLine();

                abiturient[abiturient.Count - 1].Birthday = stream.ReadLine();
                abiturient[abiturient.Count - 1].Nationality = stream.ReadLine();

                abiturient[abiturient.Count - 1].PlaceBirth = stream.ReadLine();
                abiturient[abiturient.Count - 1].PlaceLive = stream.ReadLine();

                abiturient[abiturient.Count - 1].Document = stream.ReadLine();
                abiturient[abiturient.Count - 1].NumberDocument = stream.ReadLine();

                abiturient[abiturient.Count - 1].NumberTelefone = stream.ReadLine();
                abiturient[abiturient.Count - 1].Email = stream.ReadLine();

                abiturient[abiturient.Count - 1].Average = stream.ReadLine();
                abiturient[abiturient.Count - 1].Subject1 = stream.ReadLine();
                abiturient[abiturient.Count - 1].Subject2 = stream.ReadLine();
                abiturient[abiturient.Count - 1].Subject3 = stream.ReadLine();
                abiturient[abiturient.Count - 1].Complex = Int32.Parse(stream.ReadLine());
                abiturient[abiturient.Count - 1].PlusComplex = stream.ReadLine();
                abiturient[abiturient.Count - 1].Contract = stream.ReadLine();
            }
            stream.Close();
            PrintA();
            Init_comboBoxBase();
        }

        private void Init_comboBoxBase() // считывание фамилий в comboBox
        {

            comboBoxBase.Items.Clear();
            for (int i = 0; i < abiturient.Count; i++)
                comboBoxBase.Items.Add(abiturient[i].Surname);
        }

        private void PrintA() // заполнение dataGridViewInformation
        {
            dataGridViewInformation.Rows.Clear();

            for (int i = 0; i < abiturient.Count; i++)
            {
                dataGridViewInformation.Rows.Add(AddToGrid(i, abiturient));
            }
        }

        internal DataGridViewRow AddToGrid(int i, List<Abiturient> abit) // заполнение dataGridView по строкам
        {
            DataGridViewRow row = new DataGridViewRow();

            DataGridViewCell Surname = new DataGridViewTextBoxCell();
            Surname.Value = abit[i].Surname;

            DataGridViewCell Name = new DataGridViewTextBoxCell();
            Name.Value = abit[i].Name;

            DataGridViewCell Patronymic = new DataGridViewTextBoxCell();
            Patronymic.Value = abit[i].Patronymic;

            DataGridViewCell Birthday = new DataGridViewTextBoxCell();
            Birthday.Value = abit[i].Birthday;

            DataGridViewCell Nationality = new DataGridViewTextBoxCell();
            Nationality.Value = abit[i].Nationality;

            DataGridViewCell PlaceBirth = new DataGridViewTextBoxCell();
            PlaceBirth.Value = abit[i].PlaceBirth;

            DataGridViewCell PlaceLive = new DataGridViewTextBoxCell();
            PlaceLive.Value = abit[i].PlaceLive;

            DataGridViewCell Document = new DataGridViewTextBoxCell();
            Document.Value = abit[i].Document;

            DataGridViewCell NumberDocument = new DataGridViewTextBoxCell();
            NumberDocument.Value = abit[i].NumberDocument;

            DataGridViewCell NumberTelefone = new DataGridViewTextBoxCell();
            NumberTelefone.Value = abit[i].NumberTelefone;

            DataGridViewCell Email = new DataGridViewTextBoxCell();
            Email.Value = abit[i].Email;

            DataGridViewCell Average = new DataGridViewTextBoxCell();
            Average.Value = abit[i].Average;

            DataGridViewCell Subject1 = new DataGridViewTextBoxCell();
            Subject1.Value = abit[i].Subject1;

            DataGridViewCell Subject2 = new DataGridViewTextBoxCell();
            Subject2.Value = abit[i].Subject2;

            DataGridViewCell Subject3 = new DataGridViewTextBoxCell();
            Subject3.Value = abit[i].Subject3;

            DataGridViewCell Complex = new DataGridViewTextBoxCell();
            Complex.Value = abit[i].Complex;

            DataGridViewCell PlusComplex = new DataGridViewTextBoxCell();
            PlusComplex.Value = abit[i].PlusComplex;

            DataGridViewCell Contract = new DataGridViewTextBoxCell();
            Contract.Value = abit[i].Contract;

            row.Cells.Add(Surname);
            row.Cells.Add(Name);
            row.Cells.Add(Patronymic);
            row.Cells.Add(Birthday);
            row.Cells.Add(Nationality);
            row.Cells.Add(PlaceBirth);
            row.Cells.Add(PlaceLive);
            row.Cells.Add(Document);
            row.Cells.Add(NumberDocument);
            row.Cells.Add(NumberTelefone);
            row.Cells.Add(Email);
            row.Cells.Add(Average);
            row.Cells.Add(Subject1);
            row.Cells.Add(Subject2);
            row.Cells.Add(Subject3);
            row.Cells.Add(Complex);
            row.Cells.Add(PlusComplex);
            row.Cells.Add(Contract);

            return row;
        }

        public Form1()
        {
            InitializeComponent(); //объявленный в  Form1.Designer.cs.
            //this.StartPosition = FormStartPosition.CenterParent; //центр родительского окна
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e) //метод обработчика события Load
        //sender - объект, инициировавший событие, и аргумент, хранящий информацию о событии (в данном случае EventArgs e).
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void добавитьАбитуриентаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add newForm = new Add(); //привязка формы
            newForm.Show();
        }

        private void выбратьАбитуриентовПоКатегорииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Choice newForm = new Choice(); //привязка формы
            newForm.Show();
        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
           
        }

        private void опрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.ShowDialog();
        }

        private void файлToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            if (file.ShowDialog() == DialogResult.OK)
                Read_List(file.FileName);

        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void содержаниеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help newForm = new Help(); //привязка формы
            newForm.ShowDialog();
        }


        private void dataGridViewInformation_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void comboBoxBase_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
