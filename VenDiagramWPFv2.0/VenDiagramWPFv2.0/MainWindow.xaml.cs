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

        //A
        public void AddToA(object sender, RoutedEventArgs e)
        {
            if (ListboxA.Items.Count != 20)
            {
                if(ElementA.Text != "")
                {
                    if (!ListboxA.Items.Contains(ElementA.Text))
                    {
                        ListboxA.Items.Add(ElementA.Text);
                        ElementA.Text = "";
                    }
                    else
                    {
                        ElementA.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("Input an element!");
                }
                
            }
            else
            {
                MessageBox.Show("You have already 20 elements");
                ElementA.Text = "";
            }
        }

        private void SaveA(object sender, RoutedEventArgs e)
        {
            ListboxA.Items.RemoveAt(ListboxA.Items.Count - 1);
        }

        //B
        private void AddToB(object sender, RoutedEventArgs e)
        {
            if (ListboxB.Items.Count != 20)
            {
                if (ElementB.Text != "")
                {
                    if (!ListboxB.Items.Contains(ElementB.Text))
                    {
                        ListboxB.Items.Add(ElementB.Text);
                        ElementB.Text = "";
                    }
                    else
                    {
                        ElementB.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("Input an element!");
                }
            }
        }

        private void SaveB(object sender, RoutedEventArgs e)
        {
           ListboxB.Items.RemoveAt(ListboxB.Items.Count - 1);
        }

        //C
        private void AddToC(object sender, RoutedEventArgs e)
        {
            if (ListboxC.Items.Count != 20)
            {
                if (ElementC.Text != "")
                {
                    if (!ListboxC.Items.Contains(ElementC.Text))
                    {
                        ListboxC.Items.Add(ElementC.Text);
                        ElementC.Text = "";
                    }
                    else
                    {
                        ElementC.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("Input an element!");
                }
            }

        }
        private void SaveC(object sender, RoutedEventArgs e)
        {
            ListboxC.Items.RemoveAt(ListboxB.Items.Count - 1);
        }

        //To add set C
        private void AddSetC(object sender, RoutedEventArgs e)
        {
            if (SetC.Visibility == Visibility.Collapsed)
            {
                SetC.Visibility = Visibility.Visible;
                ListboxC.Visibility = Visibility.Visible;
            }
            else
            {
                SetC.Visibility = Visibility.Collapsed;
                ListboxC.Visibility = Visibility.Collapsed;
            }
        }

        //Reset all
        private void Reset(object sender, RoutedEventArgs e)
        {
            ShowSetC.IsEnabled = true;
            ElementA.Text = "";
            ElementB.Text = "";
            ElementC.Text = "";
            ListboxA.Items.Clear();
            ListboxB.Items.Clear();
            ListboxC.Items.Clear();
            ListboxOutputA.Items.Clear();
            ListboxOutputB.Items.Clear();
            ListboxOutputC.Items.Clear();
            ListboxOutput.Items.Clear();
            Diagram.Source = new BitmapImage(new Uri(@"\Resources\", UriKind.Relative));
        }
        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (!ListboxA.Items.IsEmpty && !ListboxB.Items.IsEmpty)
            {
                if (Operation.SelectedIndex == 0)
                {
                    ShowSetC.IsEnabled = false;

                    //Union Venn Diagram
                    Diagram.Source = new BitmapImage(new Uri(@"\Resources\Union.jpg", UriKind.Relative));

                    //Output A
                    ListboxOutputA.Items.Clear();
                    ListboxOutputA.Items.Add("A = {");
                    foreach (var count in ListboxA.Items)
                    {
                        ListboxOutputA.Items.Add(count);
                        ListboxOutputA.Items.Add(",");
                    }
                    ListboxOutputA.Items.RemoveAt(ListboxOutputA.Items.Count - 1);
                    ListboxOutputA.Items.Add("}");

                    //Output B
                    ListboxOutputB.Items.Clear();
                    ListboxOutputB.Items.Add("B = {");
                    foreach (var count in ListboxB.Items)
                    {
                        ListboxOutputB.Items.Add(count);
                        ListboxOutputB.Items.Add(",");
                    }
                    ListboxOutputB.Items.RemoveAt(ListboxOutputB.Items.Count - 1);
                    ListboxOutputB.Items.Add("}");

                    //Output C
                    ListboxOutputC.Items.Clear();
                    ListboxOutputC.Items.Add("B = {");
                    foreach (var count in ListboxC.Items)
                    {
                        ListboxOutputC.Items.Add(count);
                        ListboxOutputC.Items.Add(",");
                    }
                    ListboxOutputC.Items.RemoveAt(ListboxOutputC.Items.Count - 1);
                    ListboxOutputC.Items.Add("}");

                    //Union Operation
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
                    ShowSetC.IsEnabled = false;

                    //Intersection Venn Diagram
                    Diagram.Source = new BitmapImage(new Uri(@"\Resources\Intersection.jpg", UriKind.Relative));

                    //Output A
                    ListboxOutputA.Items.Clear();
                    ListboxOutputA.Items.Add("A = {");
                    foreach (var count in ListboxA.Items)
                    {
                        ListboxOutputA.Items.Add(count);
                        ListboxOutputA.Items.Add(",");
                    }
                    ListboxOutputA.Items.RemoveAt(ListboxOutputA.Items.Count - 1);
                    ListboxOutputA.Items.Add("}");

                    //Output B
                    ListboxOutputB.Items.Clear();
                    ListboxOutputB.Items.Add("B = {");
                    foreach (var count in ListboxB.Items)
                    {
                        ListboxOutputB.Items.Add(count);
                        ListboxOutputB.Items.Add(",");
                    }
                    ListboxOutputB.Items.RemoveAt(ListboxOutputB.Items.Count - 1);
                    ListboxOutputB.Items.Add("}");

                    //Output C
                    ListboxOutputC.Items.Clear();
                    ListboxOutputC.Items.Add("B = {");
                    foreach (var count in ListboxC.Items)
                    {
                        ListboxOutputC.Items.Add(count);
                        ListboxOutputC.Items.Add(",");
                    }
                    ListboxOutputC.Items.RemoveAt(ListboxOutputC.Items.Count - 1);
                    ListboxOutputC.Items.Add("}");

                    //Intersection Operation
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
                    ShowSetC.IsEnabled = false;

                    //Difference Venn Diagram
                    Diagram.Source = new BitmapImage(new Uri(@"\Resources\Difference.jpg", UriKind.Relative));

                    //Output A
                    ListboxOutputA.Items.Clear();
                    ListboxOutputA.Items.Add("A = {");
                    foreach (var count in ListboxA.Items)
                    {
                        ListboxOutputA.Items.Add(count);
                        ListboxOutputA.Items.Add(",");
                    }
                    ListboxOutputA.Items.RemoveAt(ListboxOutputA.Items.Count - 1);
                    ListboxOutputA.Items.Add("}");

                    //Output B
                    ListboxOutputB.Items.Clear();
                    ListboxOutputB.Items.Add("B = {");
                    foreach (var count in ListboxB.Items)
                    {
                        ListboxOutputB.Items.Add(count);
                        ListboxOutputB.Items.Add(",");
                    }
                    ListboxOutputB.Items.RemoveAt(ListboxOutputB.Items.Count - 1);
                    ListboxOutputB.Items.Add("}");

                    //Output C
                    ListboxOutputC.Items.Clear();
                    ListboxOutputC.Items.Add("B = {");
                    foreach (var count in ListboxC.Items)
                    {
                        ListboxOutputC.Items.Add(count);
                        ListboxOutputC.Items.Add(",");
                    }
                    ListboxOutputC.Items.RemoveAt(ListboxOutputC.Items.Count - 1);
                    ListboxOutputC.Items.Add("}");

                    //Difference Operation
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
                    ShowSetC.IsEnabled = false;

                    //Symmetrical Venn Diagram
                    Diagram.Source = new BitmapImage(new Uri(@"\Resources\Symmetrical.jpg", UriKind.Relative));

                    //Output A
                    ListboxOutputA.Items.Clear();
                    ListboxOutputA.Items.Add("A = {");
                    foreach (var count in ListboxA.Items)
                    {
                        ListboxOutputA.Items.Add(count);
                        ListboxOutputA.Items.Add(",");
                    }
                    ListboxOutputA.Items.RemoveAt(ListboxOutputA.Items.Count - 1);
                    ListboxOutputA.Items.Add("}");

                    //Output B
                    ListboxOutputB.Items.Clear();
                    ListboxOutputB.Items.Add("B = {");
                    foreach (var count in ListboxB.Items)
                    {
                        ListboxOutputB.Items.Add(count);
                        ListboxOutputB.Items.Add(",");
                    }
                    ListboxOutputB.Items.RemoveAt(ListboxOutputB.Items.Count - 1);
                    ListboxOutputB.Items.Add("}");

                    //Output C
                    ListboxOutputC.Items.Clear();
                    ListboxOutputC.Items.Add("B = {");
                    foreach (var count in ListboxC.Items)
                    {
                        ListboxOutputC.Items.Add(count);
                        ListboxOutputC.Items.Add(",");
                    }
                    ListboxOutputC.Items.RemoveAt(ListboxOutputC.Items.Count - 1);
                    ListboxOutputC.Items.Add("}");

                    //Symmetrical Operation
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
            else
            {
                MessageBox.Show("Null sets is not allowed! Please enter elements.");
            }
        }
    }
}
