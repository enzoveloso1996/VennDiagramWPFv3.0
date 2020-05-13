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

        //Enter key to add element in set A
        private void EnterToA(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                if (ListboxA.Items.Count != 20)
                {
                    if (ElementA.Text != "")
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
                    ElementA.IsEnabled = false;
                }
            }
        }

        //Enter key to add element in set B
        private void EnterToB(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
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
                else
                {
                   MessageBox.Show("You have already 20 elements");
                   ElementA.Text = "";
                   ElementA.IsEnabled = false;
                }
            }
        }

        //Enter key to add element in set C
        private void EnterToC(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
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
                else
                {
                    MessageBox.Show("You have already 20 elements");
                    ElementC.Text = "";
                    ElementC.IsEnabled = false;
                }
            }
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
                ElementA.IsEnabled = false;
            }
        }

        //Remove last element from set A
        private void RemoveToA(object sender, RoutedEventArgs e)
        {
            if(ListboxA.Items.Count < 1)
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
            else
            {
                MessageBox.Show("You have already 20 elements");
                ElementB.Text = "";
                ElementB.IsEnabled = false;
            }
        }

        //Remove last element from set B
        private void RemoveToB(object sender, RoutedEventArgs e)
        {
            if (ListboxB.Items.Count < 1)
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
            else
            {
                MessageBox.Show("You have already 20 elements");
                ElementC.Text = "";
                ElementC.IsEnabled = false;
            }

        }

        //Remove last element from set C
        private void RemoveToC(object sender, RoutedEventArgs e)
        {
            if (ListboxC.Items.Count < 1)
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
                ForThreeSets.Visibility = Visibility.Visible;
            }
            else
            {
                SetC.Visibility = Visibility.Collapsed;
                ListboxC.Visibility = Visibility.Collapsed;
                ListboxOutputC.Visibility = Visibility.Collapsed;
                ForThreeSets.Visibility = Visibility.Collapsed;
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
            ElementA.IsEnabled = true;
            ElementB.IsEnabled = true;
            ElementC.IsEnabled = true;
            SetC.Visibility = Visibility.Collapsed;
            ListboxA.Items.Clear();
            ListboxB.Items.Clear();
            ListboxC.Items.Clear();
            AB.Items.Clear();
            BC.Items.Clear();
            AC.Items.Clear();
            ListboxOutputA.Items.Clear();
            ListboxOutputB.Items.Clear();
            ListboxOutputC.Items.Clear();
            ListboxOutput.Items.Clear();
            ListboxOutput2.Items.Clear();
            hiddenAB.Items.Clear();
            hiddenBC.Items.Clear();
            hiddenAC.Items.Clear();
            Diagram.Source = new BitmapImage(new Uri(@"\Resources\", UriKind.Relative));
            Operation.Text = "--- Select operation ---";
        }

        //Operations for 2 sets
        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (!ListboxA.Items.IsEmpty && !ListboxB.Items.IsEmpty && ListboxC.Items.IsEmpty)
            {
                ForThreeSets.Visibility = Visibility.Collapsed;
                ListboxOutputC.Visibility = Visibility.Collapsed;

                //Union of 2 sets
                if (Operation.SelectedIndex == 0)
                {
                    ListboxOutputA.Items.Clear();
                    ListboxOutputB.Items.Clear();
                    ListboxOutputC.Items.Clear();
                    ListboxOutput.Items.Clear();
                    ListboxOutput2.Items.Clear();
                    hiddenAB.Items.Clear();
                    hiddenBC.Items.Clear();
                    hiddenAC.Items.Clear();
                    ShowSetC.IsEnabled = false;
                    AddA.IsEnabled = false;
                    AddB.IsEnabled = false;
                    AddC.IsEnabled = false;
                    RemoveA.IsEnabled = false;
                    RemoveB.IsEnabled = false;
                    RemoveC.IsEnabled = false;

                    //Union Venn Diagram
                    Diagram.Source = new BitmapImage(new Uri(@"\Resources\Union Two.jpg", UriKind.Relative));

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
                    ListboxOutput2.Items.Add("A ∪ B = {");
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
                    ListboxOutputA.Items.Clear();
                    ListboxOutputB.Items.Clear();
                    ListboxOutputC.Items.Clear();
                    ListboxOutput.Items.Clear();
                    ListboxOutput2.Items.Clear();
                    hiddenAB.Items.Clear();
                    hiddenBC.Items.Clear();
                    hiddenAC.Items.Clear();
                    ShowSetC.IsEnabled = false;
                    AddA.IsEnabled = false;
                    AddB.IsEnabled = false;
                    AddC.IsEnabled = false;
                    RemoveA.IsEnabled = false;
                    RemoveB.IsEnabled = false;
                    RemoveC.IsEnabled = false;

                    //Intersection Venn Diagram
                    Diagram.Source = new BitmapImage(new Uri(@"\Resources\Intersection Two.jpg", UriKind.Relative));

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
                    ListboxOutput2.Items.Add("A ∩ B = {");
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
                    ListboxOutputA.Items.Clear();
                    ListboxOutputB.Items.Clear();
                    ListboxOutputC.Items.Clear();
                    ListboxOutput.Items.Clear();
                    ListboxOutput2.Items.Clear();
                    hiddenAB.Items.Clear();
                    hiddenBC.Items.Clear();
                    hiddenAC.Items.Clear();
                    ShowSetC.IsEnabled = false;
                    AddA.IsEnabled = false;
                    AddB.IsEnabled = false;
                    AddC.IsEnabled = false;
                    RemoveA.IsEnabled = false;
                    RemoveB.IsEnabled = false;
                    RemoveC.IsEnabled = false;

                    //Difference Venn Diagram
                    Diagram.Source = new BitmapImage(new Uri(@"\Resources\Difference Two.jpg", UriKind.Relative));

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
                    ListboxOutput2.Items.Add("A - B = {");
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
                    ListboxOutputA.Items.Clear();
                    ListboxOutputB.Items.Clear();
                    ListboxOutputC.Items.Clear();
                    ListboxOutput.Items.Clear();
                    ListboxOutput2.Items.Clear();
                    hiddenAB.Items.Clear();
                    hiddenBC.Items.Clear();
                    hiddenAC.Items.Clear();
                    ShowSetC.IsEnabled = false;
                    AddA.IsEnabled = false;
                    AddB.IsEnabled = false;
                    AddC.IsEnabled = false;
                    RemoveA.IsEnabled = false;
                    RemoveB.IsEnabled = false;
                    RemoveC.IsEnabled = false;

                    //Symmetrical Venn Diagram
                    Diagram.Source = new BitmapImage(new Uri(@"\Resources\Symmetrical Two.jpg", UriKind.Relative));

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
                    ListboxOutput2.Items.Add("A ∆ B = {");
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

                ForThreeSets.Visibility = Visibility.Visible;
                ListboxOutputC.Visibility = Visibility.Visible;

                //Union of 3 sets
                if (Operation.SelectedIndex == 0)
                {
                    ListboxOutputA.Items.Clear();
                    ListboxOutputB.Items.Clear();
                    ListboxOutputC.Items.Clear();
                    ListboxOutput.Items.Clear();
                    ListboxOutput2.Items.Clear();
                    hiddenAB.Items.Clear();
                    hiddenBC.Items.Clear();
                    hiddenAC.Items.Clear();
                    ShowSetC.IsEnabled = false;
                    AddA.IsEnabled = false;
                    AddB.IsEnabled = false;
                    AddC.IsEnabled = false;
                    RemoveA.IsEnabled = false;
                    RemoveB.IsEnabled = false;
                    RemoveC.IsEnabled = false;

                    //Union Venn Diagram
                    Diagram.Source = new BitmapImage(new Uri(@"\Resources\Union Three.jpg", UriKind.Relative));

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

                    //A and B
                    AB.Items.Clear();
                    AB.Items.Add("A ∪ B = {");
                    foreach (var count in ListboxA.Items)
                    {
                        if (!ListboxB.Items.Contains(count))
                        {
                            AB.Items.Add(count);
                            AB.Items.Add(",");
                        }
                    }
                    for (int Count = 0; Count < ListboxA.Items.Count; Count++)
                    {
                        for (int Count2 = 0; Count2 < ListboxB.Items.Count; Count2++)
                        {
                            if (ListboxA.Items[Count].ToString() == ListboxB.Items[Count2].ToString())
                            {
                                AB.Items.Add(ListboxA.Items[Count].ToString());
                                AB.Items.Add(",");
                            }
                        }
                    }
                    foreach (var count in ListboxB.Items)
                    {
                        if (!ListboxA.Items.Contains(count))
                        {
                            AB.Items.Add(count);
                            AB.Items.Add(",");
                        }
                    }
                    AB.Items.RemoveAt(AB.Items.Count - 1);
                    AB.Items.Add("}");

                    //A and B
                    BC.Items.Clear();
                    BC.Items.Add("B ∪ C = {");
                    foreach (var count in ListboxB.Items)
                    {
                        if (!ListboxC.Items.Contains(count))
                        {
                            BC.Items.Add(count);
                            BC.Items.Add(",");
                        }
                    }
                    for (int Count = 0; Count < ListboxB.Items.Count; Count++)
                    {
                        for (int Count2 = 0; Count2 < ListboxC.Items.Count; Count2++)
                        {
                            if (ListboxB.Items[Count].ToString() == ListboxC.Items[Count2].ToString())
                            {
                                BC.Items.Add(ListboxB.Items[Count].ToString());
                                BC.Items.Add(",");
                            }
                        }
                    }
                    foreach (var count in ListboxC.Items)
                    {
                        if (!ListboxB.Items.Contains(count))
                        {
                            BC.Items.Add(count);
                            BC.Items.Add(",");
                        }
                    }
                    BC.Items.RemoveAt(BC.Items.Count - 1);
                    BC.Items.Add("}");

                    //A and C
                    AC.Items.Clear();
                    AC.Items.Add("A ∪ C = {");
                    foreach (var count in ListboxA.Items)
                    {
                        if (!ListboxC.Items.Contains(count))
                        {
                            AC.Items.Add(count);
                            AC.Items.Add(",");
                        }
                    }
                    for (int Count = 0; Count < ListboxA.Items.Count; Count++)
                    {
                        for (int Count2 = 0; Count2 < ListboxC.Items.Count; Count2++)
                        {
                            if (ListboxA.Items[Count].ToString() == ListboxC.Items[Count2].ToString())
                            {
                                AC.Items.Add(ListboxA.Items[Count].ToString());
                                AC.Items.Add(",");
                            }
                        }
                    }
                    foreach (var count in ListboxC.Items)
                    {
                        if (!ListboxA.Items.Contains(count))
                        {
                            AC.Items.Add(count);
                            AC.Items.Add(",");
                        }
                    }
                    AC.Items.RemoveAt(AC.Items.Count - 1);
                    AC.Items.Add("}");

                    //Union of 3 sets
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

                    ListboxOutput2.Items.Add("A ∪ B ∪ C = {");
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
                    ListboxOutputA.Items.Clear();
                    ListboxOutputB.Items.Clear();
                    ListboxOutputC.Items.Clear();
                    ListboxOutput.Items.Clear();
                    ListboxOutput2.Items.Clear();
                    hiddenAB.Items.Clear();
                    hiddenBC.Items.Clear();
                    hiddenAC.Items.Clear();
                    ShowSetC.IsEnabled = false;
                    AddA.IsEnabled = false;
                    AddB.IsEnabled = false;
                    AddC.IsEnabled = false;
                    RemoveA.IsEnabled = false;
                    RemoveB.IsEnabled = false;
                    RemoveC.IsEnabled = false;

                    //Intersection Venn Diagram
                    Diagram.Source = new BitmapImage(new Uri(@"\Resources\Intersection Three.jpg", UriKind.Relative));

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

                    //A and B Intersection
                    for (int Count = 0; Count < ListboxA.Items.Count; Count++)
                    {
                        for (int Count2 = 0; Count2 < ListboxA.Items.Count; Count2++)
                        {
                            if (ListboxA.Items[Count].ToString() == ListboxB.Items[Count2].ToString())
                            {
                                hiddenAB.Items.Add(ListboxA.Items[Count].ToString());
                            }
                        }
                    }
                    AB.Items.Clear();
                    AB.Items.Add("A ∩ B = {");
                    if (hiddenAB.Items.Count < 1)
                    {
                        AB.Items.Add(",");
                    }
                    else
                    {
                        for (int Count = 0; Count < hiddenAB.Items.Count; Count++)
                        {
                            AB.Items.Add(hiddenAB.Items[Count].ToString());
                            AB.Items.Add(",");
                        }
                    }
                    AB.Items.RemoveAt(AB.Items.Count - 1);
                    AB.Items.Add("}");

                    //B and C Intersection
                    for (int Count = 0; Count < ListboxB.Items.Count; Count++)
                    {
                        for (int Count2 = 0; Count2 < ListboxC.Items.Count; Count2++)
                        {
                            if (ListboxB.Items[Count].ToString() == ListboxC.Items[Count2].ToString())
                            {
                                hiddenBC.Items.Add(ListboxB.Items[Count].ToString());
                            }
                        }
                    }
                    BC.Items.Clear();
                    BC.Items.Add("B ∩ C = {");
                    if (hiddenBC.Items.Count < 1)
                    {
                        BC.Items.Add(",");
                    }
                    else
                    {
                        for (int Count = 0; Count < hiddenBC.Items.Count; Count++)
                        {
                            BC.Items.Add(hiddenBC.Items[Count].ToString());
                            BC.Items.Add(",");
                        }
                    }
                    BC.Items.RemoveAt(BC.Items.Count - 1);
                    BC.Items.Add("}");

                    //A and C Intersection
                    for (int Count = 0; Count < ListboxA.Items.Count; Count++)
                    {
                        for (int Count2 = 0; Count2 < ListboxC.Items.Count; Count2++)
                        {
                            if (ListboxA.Items[Count].ToString() == ListboxC.Items[Count2].ToString())
                            {
                                hiddenAC.Items.Add(ListboxA.Items[Count].ToString());
                            }
                        }
                    }
                    AC.Items.Clear();
                    AC.Items.Add("A ∩ C = {");
                    if (hiddenAC.Items.Count < 1)
                    {
                        AC.Items.Add(",");
                    }
                    else
                    {
                        for (int Count = 0; Count < hiddenAC.Items.Count; Count++)
                        {
                            AC.Items.Add(hiddenAC.Items[Count].ToString());
                            AC.Items.Add(",");
                        }
                    }
                    AC.Items.RemoveAt(AC.Items.Count - 1);
                    AC.Items.Add("}");

                    //A and B and C Intersection
                    ListboxOutput2.Items.Clear();
                    ListboxOutput2.Items.Add("A ∩ B ∩ C= {");
                    if (hiddenAB.Items.Count < 1)
                    {
                        ListboxOutput2.Items.Add(",");
                        ListboxOutput2.Items.RemoveAt(ListboxOutput2.Items.Count - 1);
                    }
                    else
                    {
                        for (int Count = 0; Count < hiddenAB.Items.Count; Count++)
                        {
                            for (int Count2 = 0; Count2 < ListboxC.Items.Count; Count2++)
                            {
                                if (hiddenAB.Items[Count].ToString() == ListboxC.Items[Count2].ToString())
                                {
                                    ListboxOutput2.Items.Add(hiddenAB.Items[Count].ToString());
                                    ListboxOutput2.Items.Add(",");
                                }
                                else
                                {
                                    ListboxOutput2.Items.Add(",");
                                }
                            }
                        }
                    }
                    ListboxOutput2.Items.RemoveAt(ListboxOutput2.Items.Count - 1);
                    ListboxOutput2.Items.RemoveAt(ListboxOutput2.Items.Count - 1);
                    ListboxOutput2.Items.RemoveAt(ListboxOutput2.Items.Count - 1);
                    ListboxOutput2.Items.Add("}");
                }

                //Difference of 3 sets
                else if (Operation.SelectedIndex == 2)
                {
                    ListboxOutputA.Items.Clear();
                    ListboxOutputB.Items.Clear();
                    ListboxOutputC.Items.Clear();
                    ListboxOutput.Items.Clear();
                    ListboxOutput2.Items.Clear();
                    hiddenAB.Items.Clear();
                    hiddenBC.Items.Clear();
                    hiddenAC.Items.Clear();
                    ShowSetC.IsEnabled = false;
                    AddA.IsEnabled = false;
                    AddB.IsEnabled = false;
                    AddC.IsEnabled = false;
                    RemoveA.IsEnabled = false;
                    RemoveB.IsEnabled = false;
                    RemoveC.IsEnabled = false;

                    //Difference Venn Diagram
                    Diagram.Source = new BitmapImage(new Uri(@"\Resources\Difference Three.jpg", UriKind.Relative));

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

                    //A and B Difference
                    foreach (var count in ListboxA.Items)
                    {
                        if (!ListboxB.Items.Contains(count))
                        {
                            hiddenAB.Items.Add(count);
                        }
                    }
                    AB.Items.Clear();
                    AB.Items.Add("A - B = {");
                    if(hiddenAB.Items.Count < 1)
                    {
                        AB.Items.Add(",");
                    }
                    else
                    {
                        foreach (var count in hiddenAB.Items)
                        {
                            AB.Items.Add(count);
                            AB.Items.Add(",");
                        }
                    }
                    AB.Items.RemoveAt(AB.Items.Count - 1);
                    AB.Items.Add("}");

                    //B and C Difference
                    foreach (var count in ListboxB.Items)
                    {
                        if (!ListboxC.Items.Contains(count))
                        {
                            hiddenBC.Items.Add(count);
                        }
                    }
                    BC.Items.Clear();
                    BC.Items.Add("B - C = {");
                    if (hiddenBC.Items.Count < 1)
                    {
                        BC.Items.Add(",");
                    }
                    else
                    {
                        foreach (var count in hiddenBC.Items)
                        {
                            BC.Items.Add(count);
                            BC.Items.Add(",");
                        }
                    }
                    BC.Items.RemoveAt(BC.Items.Count - 1);
                    BC.Items.Add("}");

                    //A and C Difference
                    foreach (var count in ListboxA.Items)
                    {
                        if (!ListboxC.Items.Contains(count))
                        {
                            hiddenAC.Items.Add(count);
                        }
                    }
                    AC.Items.Clear();
                    AC.Items.Add("A - C = {");
                    if (hiddenAC.Items.Count < 1)
                    {
                        AC.Items.Add(",");
                    }
                    else
                    {
                        foreach (var count in hiddenAC.Items)
                        {
                            AC.Items.Add(count);
                            AC.Items.Add(",");
                        }
                    }
                    AC.Items.RemoveAt(AC.Items.Count - 1);
                    AC.Items.Add("}");


                    //A and B and C Difference
                    ListboxOutput2.Items.Clear();
                    ListboxOutput2.Items.Add("A - B - C = {");
                    if (hiddenAB.Items.Count < 1 && hiddenBC.Items.Count < 1 && hiddenAC.Items.Count < 1)
                    {
                        ListboxOutput2.Items.Add(",");
                    }
                    else
                    {
                        foreach (var count in hiddenAB.Items)
                        {
                            if (!ListboxC.Items.Contains(count))
                            {
                                ListboxOutput2.Items.Add(count);
                                ListboxOutput2.Items.Add(",");
                            }
                            else
                            {
                                ListboxOutput2.Items.Add(",");
                                ListboxOutput2.Items.RemoveAt(ListboxOutput2.Items.Count - 1);
                            }
                        }
                    }
                    ListboxOutput2.Items.RemoveAt(ListboxOutput2.Items.Count - 1);
                    ListboxOutput2.Items.Add("}");
                }

                //Symmetrical of 3 sets
                else if (Operation.SelectedIndex == 3)
                {
                    ListboxOutputA.Items.Clear();
                    ListboxOutputB.Items.Clear();
                    ListboxOutputC.Items.Clear();
                    ListboxOutput.Items.Clear();
                    ListboxOutput2.Items.Clear();
                    hiddenAB.Items.Clear();
                    hiddenBC.Items.Clear();
                    hiddenAC.Items.Clear();
                    ShowSetC.IsEnabled = false;
                    AddA.IsEnabled = false;
                    AddB.IsEnabled = false;
                    AddC.IsEnabled = false;
                    RemoveA.IsEnabled = false;
                    RemoveB.IsEnabled = false;
                    RemoveC.IsEnabled = false;

                    //Symmetrical Venn Diagram
                    Diagram.Source = new BitmapImage(new Uri(@"\Resources\Symmetrical Three.jpg", UriKind.Relative));

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

                    //A and B Symmetrical
                    foreach (var count in ListboxA.Items)
                    {
                        if (!ListboxB.Items.Contains(count))
                        {
                            hiddenAB.Items.Add(count);
                            hiddenAB.Items.Add(",");
                        }
                    }
                    foreach (var count in ListboxB.Items)
                    {
                        if (!ListboxA.Items.Contains(count))
                        {
                            hiddenAB.Items.Add(count);
                            hiddenAB.Items.Add(",");
                        }
                    }
                    AB.Items.Clear();
                    AB.Items.Add("A ∆ B = {");
                    if (hiddenAB.Items.Count < 1)
                    {
                        AB.Items.Add(",");
                    }
                    else
                    {
                        foreach (var count in ListboxA.Items)
                        {
                            if (!ListboxB.Items.Contains(count))
                            {
                                AB.Items.Add(count);
                                AB.Items.Add(",");
                            }
                        }
                        foreach (var count in ListboxB.Items)
                        {
                            if (!ListboxA.Items.Contains(count))
                            {
                                AB.Items.Add(count);
                                AB.Items.Add(",");
                            }
                        }
                    }
                    AB.Items.RemoveAt(AB.Items.Count - 1);
                    AB.Items.Add("}");

                    //B and C Symmetrical
                    foreach (var count in ListboxB.Items)
                    {
                        if (!ListboxC.Items.Contains(count))
                        {
                            hiddenBC.Items.Add(count);
                            hiddenBC.Items.Add(",");
                        }
                    }
                    foreach (var count in ListboxC.Items)
                    {
                        if (!ListboxB.Items.Contains(count))
                        {
                            hiddenBC.Items.Add(count);
                            hiddenBC.Items.Add(",");
                        }
                    }
                    BC.Items.Clear();
                    BC.Items.Add("B ∆ C = {");
                    if (hiddenBC.Items.Count < 1)
                    {
                        BC.Items.Add(",");
                    }
                    else
                    {
                        foreach (var count in ListboxB.Items)
                        {
                            if (!ListboxC.Items.Contains(count))
                            {
                                BC.Items.Add(count);
                                BC.Items.Add(",");
                            }
                        }
                        foreach (var count in ListboxC.Items)
                        {
                            if (!ListboxB.Items.Contains(count))
                            {
                                BC.Items.Add(count);
                                BC.Items.Add(",");
                            }
                        }
                    }
                    BC.Items.RemoveAt(BC.Items.Count - 1);
                    BC.Items.Add("}");

                    //A and C Symmetrical
                    foreach (var count in ListboxA.Items)
                    {
                        if (!ListboxC.Items.Contains(count))
                        {
                            hiddenAC.Items.Add(count);
                            hiddenAC.Items.Add(",");
                        }
                    }
                    foreach (var count in ListboxC.Items)
                    {
                        if (!ListboxA.Items.Contains(count))
                        {
                            AC.Items.Add(count);
                            AC.Items.Add(",");
                        }
                    }
                    AC.Items.Clear();
                    AC.Items.Add("A ∆ C = {");
                    if (hiddenAC.Items.Count < 1)
                    {
                        AC.Items.Add(",");
                    }
                    else
                    {
                        foreach (var count in ListboxA.Items)
                        {
                            if (!ListboxC.Items.Contains(count))
                            {
                                AC.Items.Add(count);
                                AC.Items.Add(",");
                            }
                        }
                        foreach (var count in ListboxC.Items)
                        {
                            if (!ListboxA.Items.Contains(count))
                            {
                                AC.Items.Add(count);
                                AC.Items.Add(",");
                            }
                        }
                    }
                    AC.Items.RemoveAt(AC.Items.Count - 1);
                    AC.Items.Add("}");

                    //Symmetrical of 3 sets
                    ListboxOutput2.Items.Clear();
                    ListboxOutput2.Items.Add("A ∆ B ∆ C = {");
                    if (hiddenAB.Items.Count < 1 && hiddenBC.Items.Count < 1 && hiddenAC.Items.Count < 1)
                    {
                        ListboxOutput2.Items.Add(",");
                    }
                    else
                    {
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
