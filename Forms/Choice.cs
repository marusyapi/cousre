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


namespace Course_Pituykova.Forms
{
    public partial class Choice : Form
    {
        List<Abiturient> Abiturient1 = new List<Abiturient>();

        List<Abiturient> bestA = new List<Abiturient>();

        List<Abiturient> newContact = new List<Abiturient>();

        public void Read_List(string file) // считывание данных с текстового документа
        {
            StreamReader stream = new StreamReader(file);
            Abiturient1.Clear();

            while (stream.ReadLine() == "^_^")
            {
                Abiturient1.Add(new Abiturient());
                Abiturient1[Abiturient1.Count - 1] = new Abiturient();

                Abiturient1[Abiturient1.Count - 1].Surname = stream.ReadLine();
                Abiturient1[Abiturient1.Count - 1].Name = stream.ReadLine();
                Abiturient1[Abiturient1.Count - 1].Patronymic = stream.ReadLine();

                Abiturient1[Abiturient1.Count - 1].Birthday = stream.ReadLine();
                Abiturient1[Abiturient1.Count - 1].Nationality = stream.ReadLine();

                Abiturient1[Abiturient1.Count - 1].PlaceBirth = stream.ReadLine();
                Abiturient1[Abiturient1.Count - 1].PlaceLive = stream.ReadLine();

                Abiturient1[Abiturient1.Count - 1].Document = stream.ReadLine();
                Abiturient1[Abiturient1.Count - 1].NumberDocument = stream.ReadLine();

                Abiturient1[Abiturient1.Count - 1].NumberTelefone = stream.ReadLine();
                Abiturient1[Abiturient1.Count - 1].Email = stream.ReadLine();

                Abiturient1[Abiturient1.Count - 1].Average = stream.ReadLine();
                Abiturient1[Abiturient1.Count - 1].Subject1 = stream.ReadLine();
                Abiturient1[Abiturient1.Count - 1].Subject2 = stream.ReadLine();
                Abiturient1[Abiturient1.Count - 1].Subject3 = stream.ReadLine();
                Abiturient1[Abiturient1.Count - 1].Complex = Int32.Parse(stream.ReadLine());
                Abiturient1[Abiturient1.Count - 1].PlusComplex = stream.ReadLine();
                Abiturient1[Abiturient1.Count - 1].Contract = stream.ReadLine();
            }

            stream.Close();
            BestA();
            ContractA();
            BestcomboBox();
            ContactcomboBox();
        }

        public void BestcomboBox() // считывание фамилий в comboBox1 
        {
            comboBox1.Items.Clear();
            for (int i = 0; i < 7; i++)
                comboBox1.Items.Add(bestA[i].Surname);
        }

        public void ContactcomboBox() // считывание фамилий в comboBox2
        {
            comboBox2.Items.Clear();
            for (int i = 0; i < newContact.Count; i++)
                comboBox2.Items.Add(newContact[i].Surname);
        }

        public void BestA() // заполнение первого dataGridView
        {
            dataGridView1.Rows.Clear();

            SortP();
            //bestA.Sort();
            SelA();

            for (int i = 0; i < 7; i++) // вывод в  dataGridView1
            {
                dataGridView1.Rows.Add(AddToGrid(i, bestA));
            }

        }

        public void ContractA() // заполнение второго dataGridView
        {
            dataGridView2.Rows.Clear();

            SortP();
            DelF();

            List<Abiturient> Abiturient2 = DelA(Abiturient1);

            for (int i = 0; i < Abiturient2.Count; i++) // вывод в dataGridView2 
            {
                dataGridView2.Rows.Add(AddToGrid(i, Abiturient2));
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

        public void SortP() // сортировка пузырьком
        {
            for (int l = 0; l < Abiturient1.Count; l++) 
            {
                for (int i = 0; i < Abiturient1.Count - 1; i++)
                {
                    if (Abiturient1[i].Complex < Abiturient1[i + 1].Complex)
                    {
                        Abiturient temp = Abiturient1[i];
                        Abiturient1[i] = Abiturient1[i + 1];
                        Abiturient1[i + 1] = temp;
                    }
                }
            }
        }

        public void SelA() // отбор студентов, у которых балл >= 175
        {
            for (int i = 0; i < Abiturient1.Count; i++) 
            {
                if (Abiturient1[i].Complex >= 175)
                {
                    bestA.Add(Abiturient1[i]);
                }
            }
        }

        public void DelF() // удаление первых семи из списка Abiturient1
        {
            for (int i = 0; i < 7; i++) 
            {
                Abiturient1.RemoveAt(0);
            }
        }

        internal List<Abiturient> DelA(List<Abiturient> Abiturient1) // отбор студентов, у которых балл >= 175 и они не могут платить за обучение
        {
            for (int i = 0; i < Abiturient1.Count; i++)
            {
                if (Abiturient1[i].Complex > 175 && Abiturient1[i].Contract == "нет")
                {
                    newContact.Add(Abiturient1[i]);
                }
            }

            return newContact;
        }

        public Choice()
        {
            InitializeComponent();
        }

        private void зачислениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            comboBox1.Visible = true;
            dataGridView2.Visible = false;
            comboBox2.Visible = false;
        }

        private void контрактнаяФормаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            comboBox1.Visible = false;
            dataGridView2.Visible = true;
            comboBox2.Visible = true;
        }

        private void файлToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog(); 
            if (file.ShowDialog() == DialogResult.OK)
                Read_List(file.FileName);
        }

        private void Choice_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
