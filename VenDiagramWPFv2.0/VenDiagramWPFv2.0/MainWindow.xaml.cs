using Nest;
using System;
using System.Collections;
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

namespace VenDiagramWPFv2._0
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


        public string[] a = new string[20];
        public string[] b = new string[20];
        public string[] c = new string[20];


        public void AddToA(object sender, RoutedEventArgs e)
        {
            int index = 0;
            if (index < a.Length && a.Length == 20 )
            {
                a[index] = ElementA.Text;
                ListboxA.Items.Add(a[index++]);
                ElementA.Text = "";
            }
            else
            {
                MessageBox.Show("You have already 20 elements");
            }
        }


        private void SaveA(object sender, RoutedEventArgs e)
        {
            ListboxA.Items.RemoveAt(ListboxA.Items.Count - 1);
        }


        private void AddToB(object sender, RoutedEventArgs e)
        {
            int index = 0;
            if (index < b.Length && b.Length == 20)
            {
                b[index] = ElementB.Text;
                ListboxB.Items.Add(b[index++]);
                ElementB.Text = "";
            }
            else
            {
                MessageBox.Show("You have already 20 elements");
            }
        }


        private void SaveB(object sender, RoutedEventArgs e)
        {
           ListboxB.Items.RemoveAt(ListboxB.Items.Count - 1);
        }


        private void AddToC(object sender, RoutedEventArgs e)
        {
            int index = 0;
            if (index < c.Length && c.Length == 20)
            {
                c[index] = ElementC.Text;
                ListboxC.Items.Add(c[index++]);
                ElementC.Text = "";
            }
            else
            {
                MessageBox.Show("You have already 20 elements");
            }
        }

        
        private void SaveC(object sender, RoutedEventArgs e)
        {
            ListboxC.Items.RemoveAt(ListboxB.Items.Count - 1);
        }

        private void AddSetC(object sender, RoutedEventArgs e)
        {
            if (SetC.Visibility == Visibility.Collapsed)
            {
                SetC.Visibility = Visibility.Visible;
            }
            else
            {
                SetC.Visibility = Visibility.Collapsed;
            }
        }

        private void Reset(object sender, RoutedEventArgs e)
        {
            ElementA.Text = "";
            ElementB.Text = "";
            ElementC.Text = "";
            ListboxA.Items.Clear();
            ListboxB.Items.Clear();
            ListboxC.Items.Clear();
            ListboxOutputA.Items.Clear();
            ListboxOutputB.Items.Clear();
            //ListboxOutputC.Items.Clear();
            ListboxOutput.Items.Clear();
            Diagram.Source = new BitmapImage(new Uri(@"\Resources\", UriKind.Relative));
        }
        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (Operation.SelectedIndex == 0)
            {
                //Union
                Diagram.Source = new BitmapImage(new Uri(@"\Resources\Union.jpg", UriKind.Relative));

                ListboxOutputA.Items.Clear();
                ListboxOutputA.Items.Add("A = {");
                foreach (var count in ListboxA.Items)
                {
                     ListboxOutputA.Items.Add(count);
                     ListboxOutputA.Items.Add(",");
                }
                ListboxOutputA.Items.RemoveAt(ListboxOutputA.Items.Count - 1);
                ListboxOutputA.Items.Add("}");

                ListboxOutputB.Items.Clear();
                ListboxOutputB.Items.Add("B = {");
                foreach (var count in ListboxB.Items)
                {
                    ListboxOutputB.Items.Add(count);
                    ListboxOutputB.Items.Add(",");
                }
                ListboxOutputB.Items.RemoveAt(ListboxOutputB.Items.Count - 1);
                ListboxOutputB.Items.Add("}");

                ListboxOutput.Items.Clear();
                ListboxOutput.Items.Add("= {");
                foreach (var count in ListboxA.Items)
                {
                    if (!ListboxB.Items.Contains(count))
                    {
                        ListboxOutput.Items.Add(count);
                        ListboxOutput.Items.Add(",");
                    }
                }
                for (int Count = 0; Count < ListboxA.Items.Count; Count++)
                {
                    for (int Count2 = 0; Count2 < ListboxB.Items.Count; Count2++)
                    {
                        if (ListboxA.Items[Count].ToString() == ListboxB.Items[Count2].ToString())
                        {
                            ListboxOutput.Items.Add(ListboxA.Items[Count].ToString());
                            ListboxOutput.Items.Add(",");
                        }
                    }
                }
                foreach (var count in ListboxB.Items)
                {
                    if (!ListboxA.Items.Contains(count))
                    {
                        ListboxOutput.Items.Add(count);
                        ListboxOutput.Items.Add(",");
                    }
                }
                ListboxOutput.Items.RemoveAt(ListboxOutput.Items.Count - 1);
                ListboxOutput.Items.Add("}");
                
            }
            else if (Operation.SelectedIndex == 1)
            {
                //Intersection
                Diagram.Source = new BitmapImage(new Uri(@"\Resources\Intersection.jpg", UriKind.Relative));

                ListboxOutputA.Items.Clear();
                ListboxOutputA.Items.Add("A = {");
                foreach (var count in ListboxA.Items)
                {
                    ListboxOutputA.Items.Add(count);
                    ListboxOutputA.Items.Add(",");
                }
                ListboxOutputA.Items.RemoveAt(ListboxOutputA.Items.Count - 1);
                ListboxOutputA.Items.Add("}");

                ListboxOutputB.Items.Clear();
                ListboxOutputB.Items.Add("B = {");
                foreach (var count in ListboxB.Items)
                {
                    ListboxOutputB.Items.Add(count);
                    ListboxOutputB.Items.Add(",");
                }
                ListboxOutputB.Items.RemoveAt(ListboxOutputB.Items.Count - 1);
                ListboxOutputB.Items.Add("}");

                ListboxOutput.Items.Clear();
                ListboxOutput.Items.Add("= {");
                for (int Count = 0; Count < ListboxA.Items.Count; Count++)
                {
                    for (int Count2 = 0; Count2 < ListboxB.Items.Count; Count2++)
                    {
                        if (ListboxA.Items[Count].ToString() == ListboxB.Items[Count2].ToString())
                        {
                            ListboxOutput.Items.Add(ListboxA.Items[Count].ToString());
                            ListboxOutput.Items.Add(",");
                        }
                    }
                }
                ListboxOutput.Items.RemoveAt(ListboxOutput.Items.Count - 1);
                ListboxOutput.Items.Add("}");
                
            }
            else if (Operation.SelectedIndex == 2)
            {
                //Difference
                Diagram.Source = new BitmapImage(new Uri(@"\Resources\Difference.jpg", UriKind.Relative));

                ListboxOutputA.Items.Clear();
                ListboxOutputA.Items.Add("A = {");
                foreach (var count in ListboxA.Items)
                {
                    ListboxOutputA.Items.Add(count);
                    ListboxOutputA.Items.Add(",");
                }
                ListboxOutputA.Items.RemoveAt(ListboxOutputA.Items.Count - 1);
                ListboxOutputA.Items.Add("}");

                ListboxOutputB.Items.Clear();
                ListboxOutputB.Items.Add("B = {");
                foreach (var count in ListboxB.Items)
                {
                    ListboxOutputB.Items.Add(count);
                    ListboxOutputB.Items.Add(",");
                }
                ListboxOutputB.Items.RemoveAt(ListboxOutputB.Items.Count - 1);
                ListboxOutputB.Items.Add("}");

                ListboxOutput.Items.Clear();
                ListboxOutput.Items.Add("= {");
                foreach (var count in ListboxA.Items)
                {
                    if (!ListboxB.Items.Contains(count))
                    {
                        ListboxOutput.Items.Add(count);
                        ListboxOutput.Items.Add(",");
                    }
                }
                ListboxOutput.Items.RemoveAt(ListboxOutput.Items.Count - 1);
                ListboxOutput.Items.Add("}");
            }
            else if (Operation.SelectedIndex == 3)
            {
                //Symmetrical
                Diagram.Source = new BitmapImage(new Uri(@"\Resources\Symmetrical.jpg", UriKind.Relative));

                ListboxOutputA.Items.Clear();
                ListboxOutputA.Items.Add("A = {");
                foreach (var count in ListboxA.Items)
                {
                    ListboxOutputA.Items.Add(count);
                    ListboxOutputA.Items.Add(",");
                }
                ListboxOutputA.Items.RemoveAt(ListboxOutputA.Items.Count - 1);
                ListboxOutputA.Items.Add("}");

                ListboxOutputB.Items.Clear();
                ListboxOutputB.Items.Add("B = {");
                foreach (var count in ListboxB.Items)
                {
                    ListboxOutputB.Items.Add(count);
                    ListboxOutputB.Items.Add(",");
                }
                ListboxOutputB.Items.RemoveAt(ListboxOutputB.Items.Count - 1);
                ListboxOutputB.Items.Add("}");

                ListboxOutput.Items.Clear();
                ListboxOutput.Items.Add("= {");
                foreach (var count in ListboxA.Items)
                {
                    if (!ListboxB.Items.Contains(count))
                    {
                        ListboxOutput.Items.Add(count);
                        ListboxOutput.Items.Add(",");
                    }
                }
                foreach (var count in ListboxB.Items)
                {
                    if (!ListboxA.Items.Contains(count))
                    {
                        ListboxOutput.Items.Add(count);
                        ListboxOutput.Items.Add(",");
                    }
                }
                ListboxOutput.Items.RemoveAt(ListboxOutput.Items.Count - 1);
                ListboxOutput.Items.Add("}");             
                //compliment
                //for (int i = 0; i < ListboxA.Items.Count; i++)
                //{
                //    string A = ListboxA.Items[i].ToString();
                //    for (int j = 0; j < ListboxB.Items.Count; j++)
                //    {
                //        string B = ListboxB.Items[j].ToString();
                //        ListboxOutput.Items.Add(A + ": " + B);
                //    }
                //}
            }
        }
    }
}
