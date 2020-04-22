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

        //Add Element to set A
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

        //Remove last element to set A
        private void RemoveToA(object sender, RoutedEventArgs e)
        {
            if(ElementA.Text == "")
            {
                MessageBox.Show("Empty set already!");
            }
            else
            {
                ListboxA.Items.RemoveAt(ListboxA.Items.Count - 1);
            }
           
        }

        //Add Element to set B
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

        //Remove last element to set B
        private void RemoveToB(object sender, RoutedEventArgs e)
        {
            if (ElementB.Text == "")
            {
                MessageBox.Show("Empty set already!");
            }
            else
            {
                ListboxB.Items.RemoveAt(ListboxB.Items.Count - 1);
            }
            
        }

        //Add Element to set C
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

        //Remove last element to set C
        private void RemoveToC(object sender, RoutedEventArgs e)
        {
            if (ElementC.Text == "")
            {
                MessageBox.Show("Empty set already!");
            }
            else
            {
                ListboxC.Items.RemoveAt(ListboxC.Items.Count - 1);
            }
            
        }

        //Add set C
        private void AddSetC(object sender, RoutedEventArgs e)
        {
            if (SetC.Visibility == Visibility.Collapsed)
            {
                SetC.Visibility = Visibility.Visible;
                ListboxC.Visibility = Visibility.Visible;
                ListboxOutputC.Visibility = Visibility.Visible;
            }
            else
            {
                SetC.Visibility = Visibility.Collapsed;
                ListboxC.Visibility = Visibility.Collapsed;
                ListboxOutputC.Visibility = Visibility.Collapsed;
            }
        }

        //Reset all
        private void Reset(object sender, RoutedEventArgs e)
        {
            ShowSetC.IsEnabled = true;
            AddA.IsEnabled = true;
            AddB.IsEnabled = true;
            AddC.IsEnabled = true;
            RemoveA.IsEnabled = true;
            RemoveB.IsEnabled = true;
            RemoveC.IsEnabled = true;
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

        //Operations
        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (!ListboxA.Items.IsEmpty && !ListboxB.Items.IsEmpty && ListboxC.Items.IsEmpty)
            {
                //Union of 2 sets
                if (Operation.SelectedIndex == 0)
                {
                    ShowSetC.IsEnabled = false;
                    AddA.IsEnabled = false;
                    AddB.IsEnabled = false;
                    AddC.IsEnabled = false;
                    RemoveA.IsEnabled = false;
                    RemoveB.IsEnabled = false;
                    RemoveC.IsEnabled = false;

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
                    ListboxOutputC.Items.Add("C = {");
                    foreach (var count in ListboxC.Items)
                    {
                        ListboxOutputC.Items.Add(count);
                        ListboxOutputC.Items.Add(",");
                    }
                    ListboxOutputC.Items.RemoveAt(ListboxOutputC.Items.Count - 1);
                    ListboxOutputC.Items.Add("}");

                    //Union Operation
                    ListboxOutput2.Items.Clear();
                    ListboxOutput2.Items.Add("= {");
                    foreach (var count in ListboxA.Items)
                    {
                        if (!ListboxB.Items.Contains(count))
                        {
                            ListboxOutput2.Items.Add(count);
                            ListboxOutput2.Items.Add(",");
                        }
                    }
                    for (int Count = 0; Count < ListboxA.Items.Count; Count++)
                    {
                        for (int Count2 = 0; Count2 < ListboxB.Items.Count; Count2++)
                        {
                            if (ListboxA.Items[Count].ToString() == ListboxB.Items[Count2].ToString())
                            {
                                ListboxOutput2.Items.Add(ListboxA.Items[Count].ToString());
                                ListboxOutput2.Items.Add(",");
                            }
                        }
                    }
                    foreach (var count in ListboxB.Items)
                    {
                        if (!ListboxA.Items.Contains(count))
                        {
                            ListboxOutput2.Items.Add(count);
                            ListboxOutput2.Items.Add(",");
                        }
                    }
                    ListboxOutput2.Items.RemoveAt(ListboxOutput2.Items.Count - 1);
                    ListboxOutput2.Items.Add("}");

                }

                //Intersection of 2 sets
                else if (Operation.SelectedIndex == 1)
                {
                    ShowSetC.IsEnabled = false;
                    AddA.IsEnabled = false;
                    AddB.IsEnabled = false;
                    AddC.IsEnabled = false;
                    RemoveA.IsEnabled = false;
                    RemoveB.IsEnabled = false;
                    RemoveC.IsEnabled = false;

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
                    ListboxOutput2.Items.Clear();
                    ListboxOutput2.Items.Add("= {");
                    for (int Count = 0; Count < ListboxA.Items.Count; Count++)
                    {
                        for (int Count2 = 0; Count2 < ListboxB.Items.Count; Count2++)
                        {
                            if (ListboxA.Items[Count].ToString() == ListboxB.Items[Count2].ToString())
                            {
                                ListboxOutput2.Items.Add(ListboxA.Items[Count].ToString());
                                ListboxOutput2.Items.Add(",");
                            }
                        }
                    }
                    ListboxOutput2.Items.RemoveAt(ListboxOutput2.Items.Count - 1);
                    ListboxOutput2.Items.Add("}");

                }

                //Difference of 2 sets
                else if (Operation.SelectedIndex == 2)
                {
                    ShowSetC.IsEnabled = false;
                    AddA.IsEnabled = false;
                    AddB.IsEnabled = false;
                    AddC.IsEnabled = false;
                    RemoveA.IsEnabled = false;
                    RemoveB.IsEnabled = false;
                    RemoveC.IsEnabled = false;

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
                    ListboxOutput2.Items.Clear();
                    ListboxOutput2.Items.Add("= {");
                    foreach (var count in ListboxA.Items)
                    {
                        if (!ListboxB.Items.Contains(count))
                        {
                            ListboxOutput2.Items.Add(count);
                            ListboxOutput2.Items.Add(",");
                        }
                    }
                    ListboxOutput2.Items.RemoveAt(ListboxOutput2.Items.Count - 1);
                    ListboxOutput2.Items.Add("}");
                }

                //Symmetrical of 2 sets
                else if (Operation.SelectedIndex == 3)
                {
                    ShowSetC.IsEnabled = false;
                    AddA.IsEnabled = false;
                    AddB.IsEnabled = false;
                    AddC.IsEnabled = false;
                    RemoveA.IsEnabled = false;
                    RemoveB.IsEnabled = false;
                    RemoveC.IsEnabled = false;

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
                    ListboxOutput2.Items.Clear();
                    ListboxOutput2.Items.Add("= {");
                    foreach (var count in ListboxA.Items)
                    {
                        if (!ListboxB.Items.Contains(count))
                        {
                            ListboxOutput2.Items.Add(count);
                            ListboxOutput2.Items.Add(",");
                        }
                    }
                    foreach (var count in ListboxB.Items)
                    {
                        if (!ListboxA.Items.Contains(count))
                        {
                            ListboxOutput2.Items.Add(count);
                            ListboxOutput2.Items.Add(",");
                        }
                    }
                    ListboxOutput2.Items.RemoveAt(ListboxOutput2.Items.Count - 1);
                    ListboxOutput2.Items.Add("}");
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
            else if (!ListboxA.Items.IsEmpty && !ListboxB.Items.IsEmpty && !ListboxC.Items.IsEmpty)
            {
                //Union of 3 sets
                if (Operation.SelectedIndex == 0)
                {
                    ShowSetC.IsEnabled = false;
                    AddA.IsEnabled = false;
                    AddB.IsEnabled = false;
                    AddC.IsEnabled = false;
                    RemoveA.IsEnabled = false;
                    RemoveB.IsEnabled = false;
                    RemoveC.IsEnabled = false;

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
                    ListboxOutputC.Items.Add("C = {");
                    foreach (var count in ListboxC.Items)
                    {
                        ListboxOutputC.Items.Add(count);
                        ListboxOutputC.Items.Add(",");
                    }
                    ListboxOutputC.Items.RemoveAt(ListboxOutputC.Items.Count - 1);
                    ListboxOutputC.Items.Add("}");

                    //Union Operation
                    ListboxOutput.Items.Clear();
                    ListboxOutput2.Items.Clear();
                    foreach (var count in ListboxA.Items)
                    {
                        if (!ListboxB.Items.Contains(count))
                        {
                            ListboxOutput.Items.Add(count);
                        }
                    }

                    for (int Count = 0; Count < ListboxA.Items.Count; Count++)
                    {
                        for (int Count2 = 0; Count2 < ListboxB.Items.Count; Count2++)
                        {
                            if (ListboxA.Items[Count].ToString() == ListboxB.Items[Count2].ToString())
                            {
                                ListboxOutput.Items.Add(ListboxA.Items[Count].ToString());
                            }
                        }
                    }

                    foreach (var count in ListboxB.Items)
                    {
                        if (!ListboxOutput.Items.Contains(count))
                        {
                            ListboxOutput.Items.Add(count);
                        }
                    }

                    ListboxOutput2.Items.Add("= {");
                    foreach (var count in ListboxOutput.Items)
                    {
                        if (!ListboxC.Items.Contains(count))
                        {
                            ListboxOutput2.Items.Add(count);
                            ListboxOutput2.Items.Add(",");
                        }
                    }

                    for (int Count = 0; Count < ListboxOutput.Items.Count; Count++)
                    {
                        for (int Count2 = 0; Count2 < ListboxC.Items.Count; Count2++)
                        {
                            if (ListboxOutput.Items[Count].ToString() == ListboxC.Items[Count2].ToString())
                            {
                                ListboxOutput2.Items.Add(ListboxOutput.Items[Count].ToString());
                                ListboxOutput2.Items.Add(",");
                            }
                        }
                    }

                    foreach (var count in ListboxC.Items)
                    {
                        if (!ListboxOutput.Items.Contains(count))
                        {
                            ListboxOutput2.Items.Add(count);
                            ListboxOutput2.Items.Add(",");
                        }
                    }

                    ListboxOutput2.Items.RemoveAt(ListboxOutput2.Items.Count - 1);
                    ListboxOutput2.Items.Add("}");
                }

                //Intersection 3 sets
                else if (Operation.SelectedIndex == 1)
                {
                    ShowSetC.IsEnabled = false;
                    AddA.IsEnabled = false;
                    AddB.IsEnabled = false;
                    AddC.IsEnabled = false;
                    RemoveA.IsEnabled = false;
                    RemoveB.IsEnabled = false;
                    RemoveC.IsEnabled = false;

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
                    ListboxOutputC.Items.Add("C = {");
                    foreach (var count in ListboxC.Items)
                    {
                        ListboxOutputC.Items.Add(count);
                        ListboxOutputC.Items.Add(",");
                    }
                    ListboxOutputC.Items.RemoveAt(ListboxOutputC.Items.Count - 1);
                    ListboxOutputC.Items.Add("}");

                    //Intersection Operation
                    //ListboxOutput2.Items.Clear();
                    //ListboxOutput2.Items.Add("= {");
                    //for (int Count = 0; Count < ListboxA.Items.Count; Count++)
                    //{
                    //    for (int Count2 = 0; Count2 < ListboxB.Items.Count; Count2++)
                    //    {
                    //        if (ListboxA.Items[Count].ToString() == ListboxB.Items[Count2].ToString())
                    //        {
                    //            ListboxOutput2.Items.Add(ListboxA.Items[Count].ToString());
                    //            ListboxOutput2.Items.Add(",");
                    //        }
                    //    }
                    //}
                    //ListboxOutput2.Items.RemoveAt(ListboxOutput2.Items.Count - 1);
                    //ListboxOutput2.Items.Add("}");
                }

                //Difference of 3 sets
                else if (Operation.SelectedIndex == 2)
                {
                    ShowSetC.IsEnabled = false;
                    AddA.IsEnabled = false;
                    AddB.IsEnabled = false;
                    AddC.IsEnabled = false;
                    RemoveA.IsEnabled = false;
                    RemoveB.IsEnabled = false;
                    RemoveC.IsEnabled = false;

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
                    ListboxOutputC.Items.Add("C = {");
                    foreach (var count in ListboxC.Items)
                    {
                        ListboxOutputC.Items.Add(count);
                        ListboxOutputC.Items.Add(",");
                    }
                    ListboxOutputC.Items.RemoveAt(ListboxOutputC.Items.Count - 1);
                    ListboxOutputC.Items.Add("}");

                    //Difference Operation
                    //ListboxOutput2.Items.Clear();
                    //ListboxOutput2.Items.Add("= {");
                    //foreach (var count in ListboxA.Items)
                    //{
                    //    if (!ListboxB.Items.Contains(count))
                    //    {
                    //        ListboxOutput2.Items.Add(count);
                    //        ListboxOutput2.Items.Add(",");
                    //    }
                    //}
                    //ListboxOutput2.Items.RemoveAt(ListboxOutput2.Items.Count - 1);
                    //ListboxOutput2.Items.Add("}");
                }

                //Symmetrical of 3 sets
                else if (Operation.SelectedIndex == 3)
                {
                    ShowSetC.IsEnabled = false;
                    AddA.IsEnabled = false;
                    AddB.IsEnabled = false;
                    AddC.IsEnabled = false;
                    RemoveA.IsEnabled = false;
                    RemoveB.IsEnabled = false;
                    RemoveC.IsEnabled = false;

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
                    ListboxOutputC.Items.Add("C = {");
                    foreach (var count in ListboxC.Items)
                    {
                        ListboxOutputC.Items.Add(count);
                        ListboxOutputC.Items.Add(",");
                    }
                    ListboxOutputC.Items.RemoveAt(ListboxOutputC.Items.Count - 1);
                    ListboxOutputC.Items.Add("}");

                    //Symmetrical Operation

                    ListboxOutput2.Items.Clear();
                    ListboxOutput2.Items.Add("= {");
                    foreach (var count in ListboxA.Items)
                    {
                        if (!ListboxB.Items.Contains(count))
                        {
                            ListboxOutput2.Items.Add(count);
                            ListboxOutput2.Items.Add(",");
                        }
                    }

                    foreach (var count in ListboxB.Items)
                    {
                        if (!ListboxOutputA.Items.Contains(count))
                        {
                            ListboxOutput2.Items.Add(count);
                            ListboxOutput2.Items.Add(",");
                        }
                    }

                    foreach (var count in ListboxC.Items)
                    {
                        if (!ListboxOutputA.Items.Contains(count) && !ListboxOutputB.Items.Contains(count))
                        {
                            ListboxOutput2.Items.Add(count);
                            ListboxOutput2.Items.Add(",");
                        }
                    }

                    ListboxOutput2.Items.RemoveAt(ListboxOutput2.Items.Count - 1);
                    ListboxOutput2.Items.Add("}");
                }
            }
            else
            {
                MessageBox.Show("Null sets is not allowed! Please enter elements.");
            }
        }
    }
}
