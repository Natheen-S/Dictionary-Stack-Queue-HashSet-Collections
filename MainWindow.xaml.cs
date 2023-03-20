using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _4_Collections
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_dictionary_Click(object sender, RoutedEventArgs e)
        {
            string val="";
            Student student = new Student();
            student.Sname = txtbox_name.Text;
            student.Sid = txtbox_studid.Text;
            student.Clgname = txtbox_clgname.Text;
            student.Batch = txtbox_batch.Text;
            student.Phnum = txtbox_mobilenumber.Text;
            student.Gender = txtbox_gender.Text;
            student.Age = txtbox_age.Text;
            student.Skill = txtbox_skills.Text;
            Dictionary<int , string> dict = new Dictionary<int , string>();
            dict.Add(1, student.Sname);
            dict.Add(2, student.Sid);
            dict.Add(3, student.Clgname);
            dict.Add(4, student.Batch);
            dict.Add(5, student.Phnum);
            dict.Add(6, student.Gender);
            dict.Add(7, student.Age);
            dict.Add(8, student.Skill);
            foreach(var item in dict.Values)
            {
                val += item.ToString()+"\n";
            }
            MessageBox.Show(val.ToString(),"Dictionary");
        }

        private void btn_hashset_Click(object sender, RoutedEventArgs e)
        {
            string val = "";
            Student student = new Student();
            student.Sname = txtbox_name.Text;
            student.Sid = txtbox_studid.Text;
            student.Clgname = txtbox_clgname.Text;
            student.Batch = txtbox_batch.Text;
            student.Phnum = txtbox_mobilenumber.Text;
            student.Gender = txtbox_gender.Text;
            student.Age = txtbox_age.Text;
            student.Skill = txtbox_skills.Text;
            HashSet<string> list = new HashSet<string>();
            list.Add(student.Sname);
            list.Add(student.Sid);
            list.Add(student.Clgname);
            list.Add(student.Batch);
            list.Add(student.Phnum);
            list.Add(student.Gender);
            list.Add(student.Age);
            list.Add(student.Skill);
            foreach(var item in list)
            {
                val += item.ToString()+"\n";
            }
            MessageBox.Show(val.ToString(),"HashSet");
            
        }

        private void btn_stack_Click(object sender, RoutedEventArgs e)
        {
            string val = "";
            Student student = new Student();
            student.Sname = txtbox_name.Text;
            student.Sid = txtbox_studid.Text;
            student.Clgname = txtbox_clgname.Text;
            student.Batch = txtbox_batch.Text;
            student.Phnum = txtbox_mobilenumber.Text;
            student.Gender = txtbox_gender.Text;
            student.Age = txtbox_age.Text;
            student.Skill = txtbox_skills.Text;
            Stack<string> stack = new Stack<string>();
            stack.Push(student.Sname);
            stack.Push(student.Sid);
            stack.Push(student.Clgname);
            stack.Push(student.Batch);
            stack.Push(student.Phnum);
            stack.Push(student.Gender);
            stack.Push(student.Age);
            stack.Push(student.Skill);
            foreach (var item in stack)
            {
                val += item.ToString() + '\n';
            }
            MessageBox.Show(val,"Stack");
        }

        private void btn_queue_Click(object sender, RoutedEventArgs e)
        {
            string val = "";
            Student student = new Student();
            student.Sname = txtbox_name.Text;
            student.Sid = txtbox_studid.Text;
            student.Clgname = txtbox_clgname.Text;
            student.Batch = txtbox_batch.Text;
            student.Phnum = txtbox_mobilenumber.Text;
            student.Gender = txtbox_gender.Text;
            student.Age = txtbox_age.Text;
            student.Skill = txtbox_skills.Text;
            Queue<string> stack = new Queue<string>();
            stack.Enqueue(student.Sname);
            stack.Enqueue(student.Sid);
            stack.Enqueue(student.Clgname);
            stack.Enqueue(student.Batch);
            stack.Enqueue(student.Phnum);
            stack.Enqueue(student.Gender);
            stack.Enqueue(student.Age);
            stack.Enqueue(student.Skill);
            foreach(var item in stack)
            {
                val += item.ToString() + '\n';
            }
            MessageBox.Show(val,"Queue");

        }
    }
    public class Student 
    {
        public string Sname { get; set; }
        public string Sid { get; set; }
        public string Clgname { get; set; }
        public string Batch { get; set; }
        public string Phnum { get; set; }
        public string Gender { get; set; }
        public string Age { get; set; }
        public string Skill { get; set; }
    }
}
