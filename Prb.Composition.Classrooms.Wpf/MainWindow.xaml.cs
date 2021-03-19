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
using Prb.Composition.Classrooms.Core.Entities;
using Prb.Composition.Classrooms.Core.Services;

namespace Prb.Composition.Classrooms.Wpf
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

        ClassroomService classroomService;
        StudentService studentService;
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            classroomService = new ClassroomService();
            studentService = new StudentService();
            PopulateListbox();
        }
        private void PopulateListbox()
        {
            lstClassrooms.ItemsSource = null;
            lstClassrooms.ItemsSource = classroomService.Classrooms;
        }

        private void lstClassrooms_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(lstClassrooms.SelectedItem != null)
            {
                Classroom classroom = (Classroom)lstClassrooms.SelectedItem;
                PopulateStudentsLisboxes(classroom);
            }
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            if(lstAvailableStudents.SelectedItem!= null && lstClassrooms.SelectedItem != null)
            {
                Classroom classroom = (Classroom)lstClassrooms.SelectedItem;
                Student student = (Student)lstAvailableStudents.SelectedItem;
                classroom.AddStudent(student);

                PopulateStudentsLisboxes(classroom);
            }
        }

        private void btnRemove_Click(object sender, RoutedEventArgs e)
        {
            if(lstStudentsInClassroom.SelectedItem != null && lstClassrooms.SelectedItem != null)
            {
                Classroom classroom = (Classroom)lstClassrooms.SelectedItem;
                Student student = (Student)lstStudentsInClassroom.SelectedItem;
                classroom.RemoveStudent(student);

                PopulateStudentsLisboxes(classroom);

            }
        }
        private void PopulateStudentsLisboxes(Classroom classroom)
        {
            lstStudentsInClassroom.ItemsSource = null;
            lstAvailableStudents.ItemsSource = null;

            lstStudentsInClassroom.ItemsSource = classroom.StudentsInClassroom;
            lstAvailableStudents.ItemsSource = studentService.AvailableStudents(classroom);
        }
    }
}
