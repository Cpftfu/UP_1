﻿using System;
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
using UP_1.MagazineDataSetTableAdapters;

namespace UP_1
{
	/// <summary>
	/// Логика взаимодействия для ThirdGrid.xaml
	/// </summary>
	public partial class ThirdGrid : Page
	{
		OrdersTableAdapter orders = new OrdersTableAdapter();

		public ThirdGrid()
		{
			InitializeComponent();
			OrdersDataGrid.ItemsSource = orders.GetData();
		}
	}
}
