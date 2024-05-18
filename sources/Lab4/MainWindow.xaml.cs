﻿using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Lab4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public class Person
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }

        public MainWindow()
        {
            InitializeComponent();

            this.DataContext = new Person()
            {
                Id = 1,
                Name = string.Empty,
            };

        }
    }
}